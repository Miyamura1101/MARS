.data
	valor_soma: .float 273.15
	valor_sub: .float 32
 	valor_div: .float 1.8
.text
	# formula para converter fahrenheit para kelvin é (fahrenheit-32)/1.8 + 273,15 (Converter de fahrenheit para celsius e celsius para Kelvin)
	
	li $v0, 6
	syscall
	
	l.s $f1, valor_sub # Carregando o valor 32 para o registrador $f1
	l.s $f2, valor_div # Carregando o valor 1.8 para o registrador $f2
	l.s $f3, valor_soma # Carregando o valor 273.15 para o registrador $f3
	
	sub.s $f0, $f0, $f1 
	
	div.s $f0, $f0, $f2 
	
	add.s $f0, $f0, $f3 
	
	li $v0, 2 
	mov.s $f12, $f0 
	syscall
