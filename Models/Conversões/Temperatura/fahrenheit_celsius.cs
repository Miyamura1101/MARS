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
            string url = @"C:/Trabalho de OAC/Temperatura/fahrenheit_para_celsius.asm";
            return IntegracaoAssembly.MARS(url, num1);
        } 
    }
}