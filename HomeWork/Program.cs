using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, include product name");
            string NameMilk = Console.ReadLine();
            Console.WriteLine("Please, include product price");
            double ProductPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, include product fatness");
            double ProductFatness = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, include product volume");
            double ProductVolume = double.Parse(Console.ReadLine());
            Milk milk1 = new Milk(NameMilk,ProductPrice,ProductFatness,ProductVolume);
            milk1.Sell();
            milk1.Sell();
        }
    }
}
