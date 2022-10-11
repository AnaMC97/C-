using System;

namespace Aula1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2.1//
            Console.WriteLine("Exercicio 2.1");
            Console.WriteLine("Introduza um valor: ");
            string n3 = Console.ReadLine();
            Console.WriteLine("Introduza outro valor: ");
            string n4 = Console.ReadLine();
            Console.WriteLine(n4 + " " + n3);
            Console.WriteLine(" 1º número = {0}; 2º número = {1}", n3, n4);
            Console.WriteLine(" ");
            //Exercicio 2.2//
            Console.WriteLine("Exercicio 2.2");
            Console.WriteLine("Introduza 1º valor: ");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 2º valor: ");
            int n6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza 3º valor: ");
            int n7 = int.Parse(Console.ReadLine());
            int multi = n5 * n6 * n7;
            Console.WriteLine("A multiplicação dos valores é: " + multi);
            Console.WriteLine(" ");
            //Exercicio 2.3//
            Console.WriteLine("Exercicio 2.3");
            //int n8, n9, soma, s, m, d, mod;
            Console.WriteLine("Introduza um valor: ");
            int n8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza outro valor: ");
            int n9 = int.Parse(Console.ReadLine());
            int soma = n8 + n9;
            int s = n8 - n9;
            int m = n8 * n9;
            int d = n8 / n9;
            int mod = n8 % n9;
            Console.WriteLine("Soma dos valores é " + soma);
            Console.WriteLine("Subtração dos valores é: " + s);
            Console.WriteLine("Multiplicação dos valores é: " + m);
            Console.WriteLine("Divisão dos valores é: "+ d);
            Console.WriteLine("Módulo dos valores é: "+ mod);
            //Exercicio 2.4//
            Console.WriteLine("Exercicio 2.4");
            //int n10 = 10, cubo = n10 * n10 * n10;
            Console.WriteLine("Introduza um valor: ");
            int n10 = Convert.ToInt32(Console.ReadLine());
            double cubo = n10 * n10 * n10;
            double cubo2 = Math.Pow(n10, 3);
            Console.WriteLine("Cubo = {0}", cubo);
            //Exercicio 2.5//
            //int media = soma/5, n11, n12, n13, n14, n15;
            Console.WriteLine("Introduza 1º números: ");
            int n11 = int.Parse(Console.ReadLine());
            //int n11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza 2º números: ");
            int n12 = int.Parse(Console.ReadLine());
            //int n12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza 3º números: ");
            int n13 = int.Parse(Console.ReadLine());
            //int n13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza 4º números: ");
            int n14 = int.Parse(Console.ReadLine());
            //int n14 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza 5º números: ");
            int n15 = int.Parse(Console.ReadLine());
            //int n15 = Convert.ToInt32(Console.ReadLine());
            soma = n11 + n12 + n13 + n14 + n15;
            float media = soma / 5;
            // float = (n11 + n12 + n13 + n14 + n15) / 5;
            Console.WriteLine("A média dos seus números é "+ media);


            




        }
    }
}
