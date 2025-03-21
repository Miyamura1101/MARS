using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Inteiro
{
    public class Divisão_I
    {
        public static void operacao(float num1, float num2)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Operações/Divisão_I.asm";
            EntradaPadrao.MARS(url, num1, num2);
        } 
    }
}