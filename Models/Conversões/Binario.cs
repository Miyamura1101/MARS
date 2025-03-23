using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models.Conversões
{
    public class Binario
    {
        public static string Bin_Decimal(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Decimal.asm";
            return EntradaPadrao.MARS(url, numero);
        }
        public static string Bin_Octal(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Octal.asm";
            return EntradaPadrao.MARS(url, numero);
        }
        public static string Bin_Hexa(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Bin_Hexa.asm";
            return EntradaPadrao.MARS(url, numero);
        }
    }
}