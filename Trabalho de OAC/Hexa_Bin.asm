.data 
	bin_table:  .asciiz "0000 0001 0010 0011 0100 0101 0110 0111 1000 1001 1010 1011 1100 1101 1110 1111"# Tabela de binários
	hex_number: .space 10
	binary_str:   .space 1024

.text
	.globl main

main:
	li $v0, 8
	la $a0, hex_number
	li $a1, 512
	syscall
	
	la $t1, hex_number
	la $t2, binary_str

conversao_Hex_Bin:
	lb $t3, 0($t1)
	beqz $t3, fim_conversao
	
	sub $t3, $t3, 48
	blt $t3, 10, decimal
	sub $t3, $t3, 7     # Para 'A'-'F' (ASCII 'A' - 65) => 'A' - 55 = 10
	decimal:
	
	la $t4, bin_table
	mul $t5, $t3, 5
	add $t4, $t4, $t5
	
	lb $t6, 0($t4)         # Primeiro bit    
	sb $t6, 0($t2)         
	
	lb $t6, 1($t4)         # Segundo bit     
	sb $t6, 1($t2)         

	lb $t6, 2($t4)         # Terceiro bit     
	sb $t6, 2($t2)         

	lb $t6, 3($t4)         # Quarto bit      
	sb $t6, 3($t2)         

	addi $t1, $t1, 1
	addi $t2, $t2, 4
	j conversao_Hex_Bin

fim_conversao:

	li $v0, 4
	la $a0, binary_str
	syscall

error_arquivo:
	li $v0, 10
	syscall
	
