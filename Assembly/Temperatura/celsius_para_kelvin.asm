.data
	valor_soma: .float 273.15
.text
	# Formula de celsius para kelvin: celsius + 273.15
	
	li $v0, 6 
	syscall
	
	l.s $f1, valor_soma 
	
	add.s $f0, $f0, $f1 
	
	mov.s $f12, $f0 
	li $v0, 2 
	syscall