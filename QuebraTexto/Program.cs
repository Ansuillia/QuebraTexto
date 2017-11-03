using System;
using System.IO;

namespace QuebraTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string arqIn = "";
            int x = 0;
            string texto = "";
            bool arqExiste = false;
            Console.WriteLine("Digite o caminho do arquivo: ");
            while (arqExiste == false)
            { 
                arqIn = @"d:\dev\projetos\" + Console.ReadLine();
                if (File.Exists(arqIn))
                {
                    arqExiste = true;
                }
                else
                {
                    Console.WriteLine("O arquivo não existe! Digite o caminho novamente: ");
                }
            }
            using (StreamReader sr = new StreamReader(arqIn))
            {
                x = Convert.ToInt32(sr.ReadLine());
                texto = sr.ReadLine();
                Console.WriteLine(texto);
                int c = texto.Length;
                int i = 0;
                int f = x;
                int l = 0;
                string linha;
                while (c != l)
                {                   
                    while(!texto.Substring(i , f).EndsWith(" "))
                    {
                        f--;
                    }
                    linha = texto.Substring(i, f);
                    int t = linha.Length;
                    Console.WriteLine(linha);
                    i = i + t;
                    f = x + 1;
                    l = l + t;
                    int rest = c - l;
                }
                Console.Read();
            }




        }
    }
}
