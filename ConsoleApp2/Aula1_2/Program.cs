using System;

namespace Aula1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2.1//
            Console.WriteLine("Exercicio 2.1");
            string n3, n4;
            Console.WriteLine("Introduza um valor: ");
            n3 = Console.ReadLine();
            Console.WriteLine("Introduza outro valor: ");
            n4 = Console.ReadLine();
            Console.WriteLine(n4 + " " + n3);
            Console.WriteLine(" ");
            //Exercicio 2.2//
            Console.WriteLine("Exercicio 2.2");
            int n5, n6, n7;
            int multi;
            Console.WriteLine("Introduza 1º valor: ");
            n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 2º valor: ");
            n6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 3º valor: ");
            n7 = int.Parse(Console.ReadLine());
            multi = n5 * n6 * n7;
            Console.WriteLine("A multiplicação dos valores é: " + multi);
            Console.WriteLine(" ");
            //Exercicio 2.3//
            
        }
    }
}
