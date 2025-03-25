.data
	valor_soma: .float 273.15
.text
	# Formula de celsius para kelvin: celsius + 273.15
	
	li $v0, 6 # Valor lido estará em $f0
	syscall
	
	l.s $f1, valor_soma # Carregando o valor 273.15 para $f1
	
	add.s $f0, $f0, $f1 # Somando o valor lido com 273.15 e colocando em $f0
	
	mov.s $f12, $f0 # Movendo o que está em $f0 para $f12 para imprimir
	li $v0, 2 # Imprimindo o valor convertido
	syscall