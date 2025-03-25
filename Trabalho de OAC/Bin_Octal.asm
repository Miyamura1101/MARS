.data
    binario: .space 512
    octal:   .space 12

.text
.globl main

main:
    li $v0, 8
    la $a0, binario
    li $a1, 128
    syscall
	
    # Converter binário para octal
    la $a0, binario	 # Numero binario
    la $a1, octal	 # Numero Octal
    jal bin_to_octal

    li $v0, 4
    la $a0, octal
    syscall
	
    li $v0, 10  # Syscall de terminar o programa
    syscall

bin_to_octal:
    move $t0, $a0
    move $t1, $a1
    li $t2, 0  # Contador de bits no grupo
    li $t3, 0  # Acumulador de bits
    li $t4, 0  # Contador total de caracteres

conta_bits:
    lb $t5, 0($t0)
    beqz $t5, calcula_zeros
    beq $t5, 10, calcula_zeros
    addi $t0, $t0, 1
    addi $t4, $t4, 1
    j conta_bits

calcula_zeros:
    li $t6, 3
    rem $t7, $t4, $t6
    beqz $t7, processa_bin
    sub $t7, $t6, $t7
    move $t2, $t7

processa_bin:
    la $t0, binario
    li $t3, 0

le_bit:
    lb $t5, 0($t0)
    beqz $t5, fim
    beq $t5, 10, fim
    sub $t5, $t5, 48
    sll $t3, $t3, 1	# Desloca o valor de $t3 para esquerda
    or $t3, $t3, $t5
    addi $t2, $t2, 1

    bne $t2, 3, avancar
    addi $t3, $t3, 48
    sb $t3, 0($t1)
    addi $t1, $t1, 1
    li $t3, 0
    li $t2, 0

avancar:
    addi $t0, $t0, 1
    j le_bit

fim:
    beqz $t2, escreve_null

escreve_null:
    sb $zero, 0($t1)
    jr $ra
