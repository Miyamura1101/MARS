using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Float
{
    public class Soma
    {
        public static void operacao(float num1, float num2)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Operações/Soma_F.asm";
            EntradaPadrao.Float(url, num1, num2);
        } 
    }
}