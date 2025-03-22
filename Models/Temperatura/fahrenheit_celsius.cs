using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class fahrenheit_celsius
    {
        public static string Operacao(float num1)
        {
            string url = @"C:\Users\felip\Documents\UFS\4 - Quarto Periodo\OAC\Trabalho de OAC\Temperatura\fahrenheit_para_celsius.asm";
            return EntradaPadrao.MARS(url, num1);
        } 
    }
}