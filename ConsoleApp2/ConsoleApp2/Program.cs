using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1.1//
            Console.WriteLine("Exercicio 1.1");
            Console.WriteLine("Hello!");
            Console.WriteLine("Ana Coelho");
            Console.WriteLine(" ");
            //Exercicio 1.2//
            Console.WriteLine("Exercicio 1.2");
            int n, n1, soma;
            n = 3;
            n1 = 5;
            soma = n + n1;
            Console.WriteLine("A soma é: "+soma);
            Console.WriteLine(" ");
            //Exercicio 1.3//
            Console.WriteLine("Exercicio 1.3");
            string n2;
            Console.WriteLine("Introduza um valor: ");
            n2 = Console.ReadLine();
            Console.WriteLine(n2);
            Console.WriteLine(" ");
            //Exercicio 2.1//
            Console.WriteLine("Exercicio 2.1");
            string n3, n4;
            Console.WriteLine("Introduza um valor: "); 
            n3 = Console.ReadLine();
            Console.WriteLine("Introduza outro valor: ");
            n4 = Console.ReadLine();
            Console.WriteLine(n4 +" "+ n3);
            //Exercicio 2.2//
            string n5, n6, n7;
            int multi;
            Console.WriteLine("Introduza 1º valor: ");
            n5 = Console.ReadLine();
            Console.WriteLine("Introduza 2º valor: ");
            n6 = Console.ReadLine();
            Console.WriteLine("Introduza 3º valor: ");
            n7 = Console.ReadLine();
            multi = n5 * n6 * n7;
            Console.WriteLine("A multiplicação dos valores é: " + multi);




        }
    }
}
