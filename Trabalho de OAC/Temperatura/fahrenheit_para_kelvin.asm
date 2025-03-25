.data
	valor_soma: .float 273.15
	valor_sub: .float 32
 	valor_div: .float 1.8
.text
	# formula para converter fahrenheit para kelvin é (fahrenheit-32)/1.8 + 273,15 (Converter de fahrenheit para celsius e celsius para Kelvin)
	
	li $v0, 6 # Valor lido estará em $f0
	syscall
	
	l.s $f1, valor_sub # Carregando o valor 32 para o registrador $f1
	l.s $f2, valor_div # Carregando o valor 1.8 para o registrador $f2
	l.s $f3, valor_soma # Carregando o valor 273.15 para o registrador $f3
	
	sub.s $f0, $f0, $f1 # Subtraindo o valor de $f0 com $f1
	
	div.s $f0, $f0, $f2 # Divindo o valor de $f0 com $f2
	
	add.s $f0, $f0, $f3 # Somando o valor de $f0 com $f3
	
	li $v0, 2 # Escrevendo na tela
	mov.s $f12, $f0 # Movendo $f0 para $f12
	syscall
