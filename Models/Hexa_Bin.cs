using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MARS.Models
{
    public class Hexa_Bin
    {
        public static void MARS()
        {
            string marsPath = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar"; // MARS
            string asmFile = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Hexa_Bin.asm"; // Arquivo ASM

            string arguments = $"\"{asmFile}\""; 

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{marsPath}\" {arguments}",
                RedirectStandardOutput = true,  // Saída
                RedirectStandardError = true,   // Erros
                UseShellExecute = false,
                CreateNoWindow = false
            };

            try
            {
                using (Process? process = Process.Start(psi))
                {
                    if (process == null)
                    {
                        Console.WriteLine("Erro ao iniciar o processo MARS.");
                        return;
                    }

                    string output = process.StandardOutput.ReadToEnd(); // Garante que não será nulo
                    string error = process.StandardError.ReadToEnd();

                    Console.WriteLine("Saída do MARS:\n" + output);

                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        Console.WriteLine("Erro do MARS:\n" + error);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao executar MARS: " + e.Message);
            }
        }
    }
}