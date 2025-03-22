using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Inteiro
{
    public class Multiplicação_I
    {
        public static void operacao(int num1, int num2)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Operações/Multiplicação_I.asm";
            EntradaPadrao.MARS(url, num1, num2);
        } 
    }
}