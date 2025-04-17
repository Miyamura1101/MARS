using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class fahrenheit_kelvin
    {
        public static string Operacao(float num1)
        {
            string url = @"C:/Trabalho de OAC/Temperatura/fahrenheit_para_kelvin.asm";
            return IntegracaoAssembly.MARS(url, num1);
        }         
    }
}