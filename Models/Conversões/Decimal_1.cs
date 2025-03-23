using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Conversões
{
    public class Decimal_1
    {
        public static string Decimal_Bin(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Decimal_Bin.asm";
            return EntradaPadrao.MARS(url, numero);
        }
        public static string Decimal_Octal(string numero)
        {
            return Binario.Bin_Octal(Decimal_Bin(numero));
        }
        public static string Decimal_Hexa(string numero)
        {
            return Binario.Bin_Hexa(Decimal_Bin(numero));
        }
    }
}