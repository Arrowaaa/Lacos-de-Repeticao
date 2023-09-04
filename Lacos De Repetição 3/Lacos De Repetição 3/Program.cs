using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lacos_De_Repetição_3
{
    class Program
    {
        static void Main()
        {   
            //Crie um programa que solicite ao usuário uma quantidade de números a serem somados. Em seguida, peça que o usuário insira esses números e exiba a soma total.

            Console.Write("Digite a quantidade de números a serem somados: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write("Digite o " + i + " número: ");
                int numero = int.Parse(Console.ReadLine());

                soma += numero;
            }

            Console.WriteLine("A soma dos " + quantidadeNumeros + " números é : " + soma);
            Console.ReadKey();
        }
        
    
    }
    
}