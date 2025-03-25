.data
input_file:     .asciiz "C:/Users/GabrielFraga/Desktop/asm/dados.txt"
output_file:    .asciiz "C:/Users/GabrielFraga/Desktop/asm/saida.txt"

decimal_str:    .space 16         # Número decimal em string
binary_str:     .space 64         # Resultado binário em string

.text
.globl main

main:
    # abrir arquivo de entrada
    li $v0, 13
    la $a0, input_file
    li $a1, 0         # Modo leitura
    syscall
    move $t0, $v0
    bltz $t0, error_arquivo

    li $v0, 14
    move $a0, $t0
    la $a1, decimal_str
    li $a2, 16
    syscall

    # fechar arquivo de entrada
    li $v0, 16
    move $a0, $t0
    syscall

    la $a0, decimal_str
    li $v0, 0       
    li $t1, 0       
    li $t2, 10      
primeiro_numero:
    lb $t3, 0($a0)
    beqz $t3, inicia_conversao

    sub $t3, $t3, 48    
    mul $t1, $t1, $t2
    add $t1, $t1, $t3

    addi $a0, $a0, 1
    j primeiro_numero

inicia_conversao:
    # $t1 contém o número decimal
    la $t4, binary_str     
    li $t5, 0              

    beqz $t1, binario_zero # = zero ≠

conversao_decimal_bin:
    remu $t6, $t1, 2
    addi $t6, $t6, 48         
    sb $t6, 0($t4)
    addi $t4, $t4, 1

    divu $t1, $t1, 2
    bnez $t1, conversao_decimal_bin

    sb $zero, 0($t4)

    la $a0, binary_str
    jal inverte_string

    # Abre arquivo de saida
    li $v0, 13
    la $a0, output_file
    li $a1, 1       # modo write
    syscall
    move $t0, $v0
    bltz $t0, error_arquivo

    # Escrever binário
    li $v0, 15
    move $a0, $t0
    la $a1, binary_str
    li $a2, 64
    syscall

    li $v0, 16
    move $a0, $t0
    syscall

    li $v0, 10
    syscall

binario_zero:
    li $t6, '0'
    la $t4, binary_str
    sb $t6, 0($t4)
    li $t6, 0
    sb $t6, 1($t4)
    j inicia_conversao


inverte_string:
    move $t0, $a0       
    move $t1, $a0
encontra_fim:
    lb $t2, 0($t1)
    beqz $t2, comeca_inverter
    addi $t1, $t1, 1
    j encontra_fim

comeca_inverter:
    addi $t1, $t1, -1   

loop_inverte:
    blt $t1, $t0, fim_inversao

    lb $t2, 0($t0)
    lb $t3, 0($t1)
    sb $t3, 0($t0)
    sb $t2, 0($t1)

    addi $t0, $t0, 1
    addi $t1, $t1, -1
    j loop_inverte

fim_inversao:
    jr $ra

error_arquivo:
    li $v0, 10
    syscall