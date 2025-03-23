using System;
using System.Diagnostics;
using System.IO;

using MARS.Models.Operações.Float;
using MARS.Models.Temperatura;
using MARS.Models.Operações.Inteiro;
using MARS.Models.Conversões;
public class MarsExecutor
{
    static void Main()
    {
        // Console.WriteLine(Kelvin_Fahrenheit.Operacao(50.0f));
        // Console.WriteLine(Soma_F.Operacao(10.0f, 123.1f));

        Console.WriteLine(Decimal_1.Decimal_Bin("379"));
    }
}