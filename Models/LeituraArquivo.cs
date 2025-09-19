using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {

            try
            {
                string[] Linhas = File.ReadAllLines(caminho);
                return (true, Linhas, Linhas.Count());
            }catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}