.data 
    valor_mult: .float 1.8
    valor_soma: .float 32
    erro: .asciiz "ERRO"
    
.text
.globl main

main:
    li $v0, 6        # Syscall para leitura de número de ponto flutuante
    syscall
    mov.s $f1, $f0   # Movendo o valor lido para $f1 (Celsius)

    l.s $f2, valor_mult   # Carregando o multiplicador (1.8) em $f2
    l.s $f3, valor_soma   # Carregando o valor de soma (32) em $f3
    
    mul.s $f4, $f1, $f2   # $f4 = Celsius * 1.8

    add.s $f4, $f4, $f3   # $f4 = $f4 + 32 (Resultado final)

    li $v0, 2             # Syscall para imprimir valor de ponto flutuante
    mov.s $f12, $f4       # Movendo o resultado para $f12 para impressão
    syscall
    
    li $v0, 10
    syscall
