using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                    string conteudo = File.ReadAllText(saida);

                    if (int.TryParse(conteudo, out int numero))
                    {
                        File.WriteAllText(dados, numero.ToString());
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