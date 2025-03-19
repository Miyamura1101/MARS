using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models
{
    public class Hexa
    {
        public static void HexaBin()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Hexa_Bin.asm";
            MARS.Conversao(url);
        }
        public static void HexaDecimal()
        {
            HexaBin();
            Arquivos.Arquivo();
            Binario.Bin_Decimal();
        }
        public static void HexaOctal()
        {
            HexaBin();
            Arquivos.Arquivo();
            Binario.Bin_Octal();
        }
    }
}