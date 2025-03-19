using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models
{
    public class Arquivos
    {
        public static void Arquivo()
        {
            string saida = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/saida.txt";
            string dados = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/dados.txt";

            try
            {
                if (File.Exists(saida))
                {
                    string[] linhas = File.ReadAllLines(saida);

                    using (StreamWriter writer = new StreamWriter(dados, false))
                    {
                        foreach (string linha in linhas)
                        {
                            string Limpo = linha.Replace(" ", " ");

                            if (!string.IsNullOrEmpty(Limpo))
                            {
                                writer.WriteLine(Limpo);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O arquivo 'saida' não existe");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                throw;
            }

        }
    }
}