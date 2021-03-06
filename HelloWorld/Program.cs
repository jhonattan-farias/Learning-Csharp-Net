using System;

namespace NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Qual é a sua idade?:");
            int idade = int.Parse(Console.ReadLine());
            if(idade < 18 && idade > 0){
                Console.WriteLine("Você é uma criança");
            }
            else if(idade >= 18){
                Console.WriteLine("Você é um adulto");
            }
            else{
                Console.WriteLine("Você é um idoso");
            }
            Console.WriteLine("Hello World");

        }
    }
}
