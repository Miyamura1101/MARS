using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models.Conversao
{
    public class Hexa
    {
        public static string Hexa_Bin(string numero)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Hexa_Bin.asm";
            return EntradaPadrao.MARS(url, numero);
        }
        /*public static void Hexa_Decimal()
        {
            Hexa_Bin();
            Arquivos.Arquivo();
            Binario.Bin_Decimal();
        }*/
        public static string Hexa_Octal(string numero)
        {
            return Binario.Bin_Octal(Hexa_Bin(numero));
        }
    }
}