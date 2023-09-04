using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_Repeticao_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que gere um número aleatório entre 1 e 100 e,
            //em seguida, peça ao usuário para adivinhar o número. Dê dicas se o palpite for alto ou baixo e continue até que o usuário acerte.


                Random random = new Random();
                int chutes = random.Next(1, 101);
                int tentativas = 0;
                bool acertou = false;

                Console.WriteLine("Bem-vindo Ao Jogo!");
                Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

                while (!acertou)
                {
                    Console.Write("Digite seu palpite: ");
                    int palpite = int.Parse(Console.ReadLine());
                    tentativas++;

                    if (palpite == chutes)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número " + chutes +" em " + tentativas +" tentativas.");
                        acertou = true;
                    }
                    else if (palpite < chutes)
                    {
                        Console.WriteLine("Tente novamente. Esse Seu palpite É baixo.");
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente. Esse Seu palpite foi alto.");
                    }
                    Console.ReadKey();
                }
            }
        }




    }


