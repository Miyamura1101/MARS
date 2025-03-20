using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Conversao
{
    public class Decimal_1
    {
        public static void DecimalBin()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Decimal_Bin.asm";
            MARS.Conversao(url);
        }
        public static void DecimalOctal()
        {
            DecimalBin();
            Arquivos.Arquivo();
            Binario.Bin_Octal();
        }
        public static void DecimalHexa()
        {
            DecimalBin();
            Arquivos.Arquivo();
            Binario.Bin_Hexa();
        }
    }
}