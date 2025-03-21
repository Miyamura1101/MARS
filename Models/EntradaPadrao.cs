using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MARS.Models
{
    public class EntradaPadrao
    {
        public static string MARS(string url, float num1, float num2)
        {
            string PastaMARS = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{PastaMARS}\" \"{url}\"",
                RedirectStandardInput = true,        // Permite o envio de dados pela entrada padrão
                RedirectStandardOutput = true,       // Captura a saída do MARS
                UseShellExecute = false,
                CreateNoWindow = false
            };

            using (Process? process = Process.Start(psi))
            {
                if (process == null)
                {
                    Console.WriteLine("Erro ao iniciar o processo MARS.");
                    return " "; 
                }

                using (StreamWriter sw = process.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine(num1.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        sw.WriteLine(num2.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    }
                }

                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                return output;
            }
        } 
    }
}