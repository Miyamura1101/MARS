using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models.Conversao
{
    public class Hexa
    {
        public static void Hexa_Bin()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Hexa_Bin.asm";
            MARS.Conversao(url);
        }
        public static void Hexa_Decimal()
        {
            Hexa_Bin();
            Arquivos.Arquivo();
            Binario.Bin_Decimal();
        }
        public static void Hexa_Octal()
        {
            Hexa_Bin();
            Arquivos.Arquivo();
            Binario.Bin_Octal();
        }
    }
}