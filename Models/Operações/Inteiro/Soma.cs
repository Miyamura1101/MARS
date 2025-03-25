using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Inteiro
{
    public class Soma_I
    {
        public static float Operacao(int num1, int num2)
        {
            string url = @"C:/Trabalho de OAC/Operações/Soma_I.asm";
            return EntradaPadrao.MARS(url, num1, num2);
        } 
    }
}