using System;

namespace EsquerdaVolver_.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeComandos = 1;
            
            string historicoDireção = "";
            
            Console.WriteLine("Esquerda Volver!");
            while (quantidadeComandos != 0) { 
            Console.WriteLine("Digite a quantidade de comandos:");
            quantidadeComandos = Convert.ToInt32(Console.ReadLine());
                if(quantidadeComandos == 0) 
                    continue;
            Console.WriteLine("Digite os comandos para fazer:");
                string direçãoVolver = "N";
                string comandos = Console.ReadLine();
            char[] instruções = comandos.ToCharArray();
            
                for (int j = 0; j < instruções.Length; j++)
                {

                    //se a intrução for E para todos os lados terá que trocar de direção 90º para a esquerda
                    if (instruções[j] == 'E' || instruções[j] == 'e')
                    {
                        if (direçãoVolver == "N" || direçãoVolver == "n")
                        {
                            direçãoVolver = "O";
                        }
                        else if (direçãoVolver == "L" || direçãoVolver == "l")
                        {
                            direçãoVolver = "N";
                        }
                        else if (direçãoVolver == "S" || direçãoVolver == "s")
                        {
                            direçãoVolver = "L";
                        }
                        else if (direçãoVolver == "O" || direçãoVolver == "o")
                        {
                            direçãoVolver = "S";
                        }
                    }
                    //se a intrução for D para todos os lados terá que trocar de direção 90º para a direita
                    else if (instruções[j] == 'D' || instruções[j] == 'd')
                    {
                        if (direçãoVolver == "N" || direçãoVolver == "n")
                        {
                            direçãoVolver = "L";
                        }
                        else if (direçãoVolver == "L" || direçãoVolver == "l")
                        {
                            direçãoVolver = "S";
                        }
                        else if (direçãoVolver == "S" || direçãoVolver == "s")
                        {
                            direçãoVolver = "O";
                        }
                        else if (direçãoVolver == "O" || direçãoVolver == "o")
                        {
                            direçãoVolver = "N";
                        }
                    }
                    
                    
                }
                
                historicoDireção =  historicoDireção + " - " + direçãoVolver;
                Console.Write(direçãoVolver);
                Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.WriteLine("Resultados:");
            Console.WriteLine(historicoDireção);
            Console.ReadLine();
            
        }
    }
}
