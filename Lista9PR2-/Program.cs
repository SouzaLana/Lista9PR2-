using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2
{
    internal class Program
    {
        public static void Ex1()
        {
            int[] vet;
            float it = 0, ma;
            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);
                it += vet[i];
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
            }
            ma = it / t;
            Console.WriteLine("A média Aritimética é " + ma);
            Console.ReadKey();
        }
        public static void Ex2()
        {
            int[] vet;
            float itP = 0, itI = 0;

            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);

                if (vet[i] % 2 == 0)
                {
                    itP += vet[i];

                }
                else
                {
                    itI += vet[i];
                }
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
            }
            Console.WriteLine("A soma dos números pares contidos no vertor é " + itP);
            Console.WriteLine("A soma dos números ímpares contidos no vertor é " + itI);
        }
        public static void Ex3()
        {
            int[] vet;

            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
            }

            Array.Reverse(vet);
            Console.WriteLine(" ");

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
            }
        }
        public static void Ex4()
        {
            int[] vet;
            float it = 0, ma;

            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);

                if (vet[i] % 3 == 0 && vet[i] % 5 == 0)
                {
                    it += i;
                }
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
            }
            ma = it / t;
            Console.WriteLine("A média Aritimética é " + ma);

        }
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("===MENU===");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Ex1();
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    Ex3();
                    break;
                case 4:
                    Ex4();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}