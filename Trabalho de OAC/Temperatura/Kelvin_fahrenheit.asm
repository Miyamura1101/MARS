.data 
	valor_sub: .float 273.15
	valor_Mult: .float 1.8
	valor_soma: .float 32.0

.text
.globl main

main:
	li $v0, 6
	syscall
	
	mov.s $f1, $f0  
	
	l.s $f2, valor_sub  # 273.0
	l.s $f3, valor_Mult  # 1.8
	l.s $f4, valor_soma  # 32.0
	
	sub.s $f5, $f1, $f2  

	mul.s $f6, $f5, $f3  

	add.s $f7, $f6, $f4  

	li $v0, 2
	mov.s $f12, $f7
	syscall
	
	li $v0, 10
	syscall
