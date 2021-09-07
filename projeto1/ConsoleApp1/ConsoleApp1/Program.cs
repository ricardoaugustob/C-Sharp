using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome, " seja bem vindo");
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            adulto(idade);
            Console.ReadLine();



        }

        static void adulto(int idade)
        {
            if(idade >0 && idade < 18)
            {
                Console.WriteLine("Você não é adulto");

            }
            else if(idade>=18)
            {
                Console.WriteLine("Você é adulto!!");
            }
            else
            {
                Console.WriteLine("Idade fora do intervalo");
            }
        }
    }
}
