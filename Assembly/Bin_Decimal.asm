.data
	binary_str:  .space 512    
.text
    .globl main

main:
	li $v0, 8
	la $a0, binary_str
	li $a1, 128
	syscall
   
    	la $t1, binary_str  # Ponteiro para string binaria
    	li $t0, 0           # Acumulador para conversao

converter_Bin_Decimal:
	lb $t2, 0($t1)
	beqz $t2, Saida
	
	mul $t0, $t0, 2
	
	li $t3, '1'
	beq $t2, $t3, soma_um
	j loop
	
soma_um:
	addi $t0, $t0, 1
loop:
	addi $t1, $t1, 1
	j converter_Bin_Decimal
Saida:

	div $t0, $t0, 2
	
	li $v0, 1
	move $a0, $t0
	syscall
	
	li $v0, 10
	syscall