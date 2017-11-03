using System;
using System.IO;

namespace QuebraTexto
{
    class Program
    {
        static void Main(string[] args)
        {           
            var arqIn = "";
            var arqOut = "";
            var x = 0;
            var texto = "";
            var arqExiste = false;
            //Console.WriteLine("Digite o caminho do arquivo: ");
            while (arqExiste == false)
            {
                arqIn = @"D:\Dev\Projetos\QuebraTexto\in.txt";// + Console.ReadLine();
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
                var inicio = 0;
                var fim = x;
                var tamanho = 0;
                var resto = texto;
                var linha = "";
                var condicao = false;
                var palavra = texto.Split(' ')[0];
                Console.WriteLine(palavra);
                //Console.WriteLine("Onde deseja salvar o arquivo de origem? ");
                arqOut = @"D:\Dev\Projetos\QuebraTexto\out.txt"; //Console.ReadLine() + @"\out.txt";
                using (StreamWriter sw = new StreamWriter(arqOut))
                {
                    var teste = false;
                    while (!condicao)
                    {
                        if (resto.Length >= fim)
                        {
                            if(fim > palavra.Length)
                            {
                                teste = true;
                                while (!texto.Substring(inicio, fim).EndsWith(" "))
                                {
                                    fim--;
                                }
                                linha = texto.Substring(inicio, fim);
                                tamanho = linha.Length;
                                inicio = inicio + tamanho;
                                resto = texto.Substring(inicio);
                                fim = x + 1;
                                sw.WriteLine(linha);
                                continue;
                            }
                            else
                            {
                                string[] parte = texto.Split(' ');
                                foreach (string p in parte)
                                {
                                    sw.WriteLine(p);
                                } 
                            }
                        }
                        if(teste == true)
                        {
                            sw.WriteLine(resto);
                        }  
                        sr.Close();
                        condicao = true;
                    }
                }                
            }
        }
    }
}
