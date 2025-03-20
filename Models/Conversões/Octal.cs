using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MARS.Models.Conversao
{
    public class Octal
    {
        public static void OctalBin()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Octal_bin.asm";
            MARS.Conversao(url);
        }
        public static void OctalDecimal()
        {
            OctalBin();
            Arquivos.Arquivo();
            Binario.Bin_Decimal();
        }
        public static void OctalHexa()
        {
            OctalBin();
            Arquivos.Arquivo();
            Binario.Bin_Hexa();
        }
    }
}