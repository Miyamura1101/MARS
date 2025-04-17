.data
hex_table:   .asciiz "0123456789ABCDEF"
binary_str:  .space 512   
hex_str:     .space 128   

.text
    .globl main

main:
	li $v0, 8
	la $a0, binary_str
	li $a1, 128
	syscall
   
    	la $t1, binary_str  # Ponteiro para string bin�ria
    	la $t2, hex_str     # Ponteiro para string hexadecimal
    	li $t3, 0           # Contador de bits lidos
    	li $t4, 0           # Acumulador para convers�o
    	
conta_bits:

	lb $t5, 0($t1)
	beqz $t5, calcular_zeros
	beq $t5, 10, calcular_zeros
	addi $t1, $t1, 1
	addi $t3, $t3, 1
	j conta_bits

calcular_zeros:

	li $t6, 4
	rem $t3, $t3, $t6
	
	mfhi $t3 # Resto da divisão
	
	beq $t3, 0, volta # Se igual a 0
	sub $t3, $t6, $t3 
volta:
	la $t1, binary_str
	
converte_bin_hex:

    	lb $t5, 0($t1)   # Ler um caractere
    	beqz $t5, fim_conversao  # Se for nulo, fim
    	beq $t5, 10, ignorar     # Ignora '\n' 

    	sub $t5, $t5, 48  # Converte de ASCII para inteiro
    	sll $t4, $t4, 1   # Shift para a esquerda (multiplica por 2)
    	or $t4, $t4, $t5  # Adiciona bit ao acumulador

    	addi $t3, $t3, 1  # Incrementa contador de bits
    	beq $t3, 4, armazena_hex  # Se leu 4 bits, converte para hexadecimal

    	addi $t1, $t1, 1 
    	j converte_bin_hex

ignorar:
    	addi $t1, $t1, 1  
	j converte_bin_hex

armazena_hex:

    	la $t6, hex_table
    	add $t6, $t6, $t4  
    	lb $t7, 0($t6)     # Obtem caractere correspondente
    	sb $t7, 0($t2)     # Armazena na string de saida

    	addi $t2, $t2, 1  
    	li $t3, 0         # Reseta contador de bits
    	li $t4, 0         # Reseta acumulador
    	addi $t1, $t1, 1  

    	j converte_bin_hex

fim_conversao:
	
	li $v0, 4
	la $a0, hex_str
	syscall
	
error_arquivo:

	li $v0, 10  # Finaliza o programa
    	syscall
