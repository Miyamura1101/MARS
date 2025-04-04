.data 	
	valor_sub: .float 32
 	valor_div: .float 1.8
.text 
 	# Formula de fahrenheit para celsius: (fahrenheit - 32) / 1.8 
 	li $v0, 6
 	syscall
 	
 	l.s $f1, valor_sub # Carregando o valor 32 para o registrador $f1
 	l.s $f2, valor_div # Carregando o valor 1.8 para o regustrador $f2
 	
 	sub.s $f0, $f0, $f1 
 	
 	div.s $f0, $f0, $f2 
 	
 	mov.s $f12, $f0 
 	
 	li $v0, 2 
 	syscall