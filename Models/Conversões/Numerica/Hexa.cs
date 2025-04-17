using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models.Conversões
{
    public class Hexa
    {
        public static string Hexa_Bin(string numero)
        {
            string url = @"C:/Trabalho de OAC/Hexa_Bin.asm";
            return IntegracaoAssembly.MARS(url, numero);
        }
        public static string Hexa_Decimal(string numero)
        {
            return Binario.Bin_Decimal(Hexa_Bin(numero));
        }
        public static string Hexa_Octal(string numero)
        {
            return Binario.Bin_Octal(Hexa_Bin(numero));
        }
    }
}