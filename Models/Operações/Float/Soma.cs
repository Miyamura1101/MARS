using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Float
{
    public class Soma_F
    {
        public static string operacao(float num1, float num2)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Operações/Soma_F.asm";
            return EntradaPadrao.MARS(url, num1, num2);
        } 
    }
}