using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class Celsius_Fahrenheit
    {
        public static string Operacao(float num1)
        {
            string url = @"C:/Trabalho de OAC/Temperatura/celsius_para_fahrenheit.asm";
            return IntegracaoAssembly.MARS(url, num1);
        } 
    }
}