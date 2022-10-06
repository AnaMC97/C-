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
            Console.WriteLine("Exercicio 2.3");
            int n8, n9, soma, s, m, d, mod;
            Console.WriteLine("Introduza um valor: ");
            n8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza outro valor: ");
            n9 = int.Parse(Console.ReadLine());
            soma = n8 + n9;
            s = n8 - n9;
            m = n8 * n9;
            d = n8 / n9;
            mod = n8 % n9;
            Console.WriteLine("Soma dos valores é " + soma);
            Console.WriteLine("Subtração dos valores é: " + s);
            Console.WriteLine("Multiplicação dos valores é: " + m);
            Console.WriteLine("Divisão dos valores é: "+ d);
            Console.WriteLine("Módulo dos valores é: "+ mod);
            //Exercicio 2.4//
            Console.WriteLine("Exercicio 2.4");
            int n10 = 10, cubo = n10 * n10 * n10;
            Console.WriteLine(cubo);
            //Exercicio 2.5//
            int media, n11, n12, n13, n14, n15;
            Console.WriteLine("Introduza 1º números: ");
            n11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 2º números: ");
            n12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 3º números: ");
            n13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 4º números: ");
            n14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 5º números: ");
            n15 = int.Parse(Console.ReadLine());
            soma = n11 + n12 + n13 + n14 + n15;
            media = soma / 5;
            Console.WriteLine("A média dos seus números é ", media);


            




        }
    }
}
