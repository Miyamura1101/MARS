.data

.text
.globl main

main:
	li $v0, 6
	syscall
	mov.s $f1, $f0
	
	li $v0, 6
	syscall
	mov.s $f2, $f0

	sub.s $f3, $f1, $f2
	li $v0, 2
	mov.s $f12, $f3
	syscall
