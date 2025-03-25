.data 
	bin_table:  .asciiz "000 001 010 011 100 101 110 111"# Tabela de binários
	octal_str: .space 512
	binary_str:   .space 512
.text
.globl main

main:
	li $v0, 8
	la $a0, octal_str
	li $a1, 512
	syscall
	
	move $t1, $v0 # numero Octal
	
	la $t1, octal_str	# Numero Octal
	la $t2, binary_str      # Numero binario

conversao_Octal_Binario:
	lb $t3, 0($t1)
	beqz $t3, fim_conversao
	
	sub $t3, $t3, 48
	
	la $t4, bin_table
 	mul $t5, $t3, 4   # $t5 = $t3 * 4
 	add $t4, $t4, $t5
 	
 	lb $t6, 0($t4)      # Primeiro bit
    	sb $t6, 0($t2)

   	lb $t6, 1($t4)      # Segundo bit
    	sb $t6, 1($t2)

   	lb $t6, 2($t4)      # Terceiro bit
   	sb $t6, 2($t2)

	addi $t1, $t1, 1
	addi $t2, $t2, 3
	j conversao_Octal_Binario

fim_conversao:
	
	li $v0, 4
	la $a0, binary_str
	syscall
	
	li $v0, 10  # Syscall de terminar o programa
	syscall
	
	
	
	
