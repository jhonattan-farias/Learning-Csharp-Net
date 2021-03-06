using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {   
        Console.WriteLine("Qual a nota do aluno?");
           int nota = int.Parse(Console.ReadLine());

            bool alunoA = nota >= 80;
            bool alunoB = nota >= 70;
            bool alunoC = nota >= 60;
            bool alunoD = nota >= 50;
            bool alunoE = nota <= 49;

            switch(true){
                case alunoA: 
                    Console.WriteLine("Parabens, nota A!");
                break;
                
                case alunoB: 
                    Console.WriteLine("Você tirou nota B");
                break;
                    
                case alunoC:
                    Console.WriteLine("Você tirou nota C");
                break;

                case alunoD:
                    Console.WriteLine("Voce tirou nota D");
                break;

                case alunoE:
                    Console.WriteLine("Você tirou nota E");
                break;
                default:
                break;
            }


        }
    }
}
