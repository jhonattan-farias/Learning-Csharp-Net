using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = returnName();
            string[] nomes = {name,"alessandra"};

            Console.WriteLine(nomes[0]);
            Console.ReadLine();
        }
        static string returnName(){
            return "jhon";
        }
    }
}
