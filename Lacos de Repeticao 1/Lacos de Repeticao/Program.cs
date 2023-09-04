using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Contagem Crescente: ");
            int meneu = int.Parse(Console.ReadLine());

            if (meneu == 1)
            {   
                int contador = 1;

                Console.Write("Escolha O Numéro Desejado: ");
                int num = int.Parse(Console.ReadLine());

                while (contador <= num)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
            }

            Console.ReadKey();







        }
    }
}
