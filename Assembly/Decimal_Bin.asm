.data
    decimal_str: .space 128
    binary_str: .space 128

.text
    .globl main

main:
    # Entrada do número decimal
    li $v0, 8
    la $a0, decimal_str
    li $a1, 128
    syscall
    
    la $t1, decimal_str  # Número decimal
    li $t0, 0            # Inicializa o número decimal como 0
    
converter_String_Int:

    lb $t2, 0($t1)
    beq $t2, 10, converter_Bin
    
    sub $t2, $t2, 48     # Converte o caractere para seu valor numérico
    
    mul $t0, $t0, 10     # Multiplica o número por 10
    add $t0, $t0, $t2    # Adiciona o valor ao número acumulado
    
    addi $t1, $t1, 1   
    j converter_String_Int
    
converter_Bin:
    # Se o número for zero, passa para a etapa de saída
    beqz $t0, zero
    
    la $t4, binary_str
    addi $t4, $t4, 127
    
    sb $zero, 0($t4)
    
loop:
    beqz $t0, Saida
    
    li $t2, 2            # Divide por 2
    div $t0, $t2
    mflo $t0             # Quociente
    mfhi $t3             # Resto (bit binário)
    
    addi $t3, $t3, 48    # Converte o bit para seu caractere ASCII ('0' ou '1')  
      
    addi $t4, $t4, -1    # Decrementa o ponteiro para armazenar o próximo bit
    sb $t3, 0($t4)       # Armazena o bit na posição correta
    j loop               # Repete até que o número seja zero
    
zero:

    la $t4, binary_str
    li $t2, '0'
    sb $t2, 0($t4)       
    sb $zero, 1($t4)     
    
Saida:
    la $a0, binary_str
    addi $a0, $t4, 0		
	
    li $v0, 4
    syscall
    
    li $v0, 10
    syscall
