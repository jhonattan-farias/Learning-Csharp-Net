using System;

namespace criandoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o Modelo do seu carro?");
            string model = Console.ReadLine();
           
            Console.WriteLine("Qual o ano é o ano do seu carro?");
            int year = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual o preço do seu Carro?");
            float price = float.Parse(Console.ReadLine());

            Carro carro1 = new Carro(model,year,price);
            
            Console.WriteLine("O modelo do seu carro é " + carro1.model);
            Console.WriteLine("O ano é " + carro1.year);
            Console.WriteLine("E o preço do carro é " + carro1.price + " Certo?");
            Console.ReadLine();
            Console.WriteLine(Carro.registeresCars);
        }
    }
}
