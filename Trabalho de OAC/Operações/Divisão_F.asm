.data
	erro: .asciiz "ERRO"
.text
.globl main

main:
	li $v0, 6
	syscall
	mov.s $f1, $f0
	
	li $v0, 6
	syscall
	mov.s $f2, $f0
	
	li $t0, 0
	mtc1 $t0, $f4		# Move 0 para o $f4
	c.eq.s $f2, $f4		# Compara $f2 com 0
	bc1t error	
	
	div.s $f3, $f1, $f2
	
	li $v0, 2
	mov.s $f12, $f3
	syscall
	
	li $v0, 10
	syscall

error:
	li $v0, 4
	la $a0, error
	syscall
	
	li $v0, 10
	syscall
	
