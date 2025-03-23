using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MARS.Models.Conversões
{
    public class Octal
    {
        public static string Octal_Bin(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Octal_bin.asm";
            return EntradaPadrao.MARS(url, numero);
        }
        public static string Octal_Decimal(string numero)
        {
            return Binario.Bin_Decimal(Octal_Bin(numero));
        }
        public static string Octal_Hexa(string numero)
        {
            return Binario.Bin_Hexa(Octal_Bin(numero));
        }
    }
}