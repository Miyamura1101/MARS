.data 
	valor_sub: .float 273.15

.text
.globl main

main:
	li $v0, 6
	syscall
	mov.s $f1, $f0
	
	l.s $f2, valor_sub
	sub.s $f3, $f1, $f2
	
	li $v0, 2
	mov.s $f12, $f3
	syscall
	
	li $v0, 10
	syscall