using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações
{
    public class Calculos
    {
        public static float Soma(float parcela1, float parcela2)
        {
            string url = @"C:/Trabalho de OAC/Operações/Soma_F.asm";
            return IntegracaoAssembly.MARS(url, parcela1, parcela2);
        }

        public static float Subtração(float minuendo, float subtraendo)
        {
            string url = @"C:/Trabalho de OAC/Operações/Subtração_F.asm";
            return IntegracaoAssembly.MARS(url, minuendo, subtraendo);
        }

        public static float Multiplicação(float fator1, float fator2)
        {
            string url = @"C:/Trabalho de OAC/Operações/Multiplicação_F.asm";
            return IntegracaoAssembly.MARS(url, fator1, fator2);
        }

        public static float Divisão(float dividendo, float divisor)
        {
            string url = @"C:/Trabalho de OAC/Operações/Divisão_F.asm";
            return IntegracaoAssembly.MARS(url, dividendo, divisor);
        } 
    }
}