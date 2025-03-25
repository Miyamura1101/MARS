using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace MARS.Models
{
    public class EntradaPadrao
    {

        public static float MARS(string url, float num1, float num2)
        {
            string PastaMARS = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar";  // Alterar para configuração da sua maquina

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
                    return 0;
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

                output = output.Replace("MARS 4.5  Copyright 2003-2014 Pete Sanderson and Kenneth Vollmar", "").Trim();

                if (!float.TryParse(output, NumberStyles.Float, CultureInfo.InvariantCulture, out float resultado))
                {
                    resultado = -1;
                }

                return resultado;
            }
        }

        public static string MARS(string url, float num1)
        {
            string PastaMARS = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar"; // Alterar para configuração da sua maquina

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
                    return "";
                }

                using (StreamWriter sw = process.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine(num1.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    }
                }

                string output = process.StandardOutput.ReadToEnd();

                output = output.Replace("MARS 4.5  Copyright 2003-2014 Pete Sanderson and Kenneth Vollmar", "").Trim();

                return output.ToString().Replace('.', ',');
            }
        }
            
        public static string MARS(string url, string num1)
        {
            string PastaMARS = @"C:/Users/felip/OneDrive/Área de Trabalho/Mars4_5.jar"; // Alterar para configuração da sua maquina

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
                    return "";
                }

                using (StreamWriter sw = process.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine(num1.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    }
                }

                string output = process.StandardOutput.ReadToEnd();

                output = output.Replace("MARS 4.5  Copyright 2003-2014 Pete Sanderson and Kenneth Vollmar", "").Trim();

                return output;
            }
        } 
    }
}