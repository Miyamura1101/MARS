using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MARS.Models.Conversao
{
    public class Octal
    {
        public static void Octal_Bin()
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Octal_bin.asm";
            MARS.Conversao(url);
        }
        public static void Octal_Decimal()
        {
            Octal_Bin();
            Arquivos.Arquivo();
            Binario.Bin_Decimal();
        }
        public static void Octal_Hexa()
        {
            Octal_Bin();
            Arquivos.Arquivo();
            Binario.Bin_Hexa();
        }
    }
}