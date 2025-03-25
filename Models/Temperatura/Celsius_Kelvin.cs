using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class Celsius_Kelvin
    {
        public static string Operacao(float num1)
        {
            string url = @"C:/Trabalho de OAC/Temperatura/celsius_para_kelvin.asm";
            return EntradaPadrao.MARS(url, num1);
        } 
    }
}