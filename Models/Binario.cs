using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models
{
    public class Binario
    {
        public static void Bin_Decimal()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Decimal.asm";
            MARS.Conversao(url);
        }
        public static void Bin_Octal()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Octal.asm";
            MARS.Conversao(url);
        }
        public static void Bin_Hexa()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Hexa.asm";
            MARS.Conversao(url);
        }
    }
}