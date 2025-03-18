using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MARS.Models
{
    public class Octal_Bin
    {
        public static void MARS()
        {
            string marsPath = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar"; // Caminho do MARS
            string asmFile = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Octal_Bin.asm"; // Arquivo ASM

            // Comando para executar MARS
            string arguments = $"\"{asmFile}\""; // Aspas para evitar erros com espaços no caminho

            // Criando o processo para executar o MARS
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{marsPath}\" {arguments}",
                RedirectStandardOutput = true,  // Captura saída
                RedirectStandardError = true,   // Captura erros
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process? process = Process.Start(psi)) // Permite valores nulos para evitar warnings
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