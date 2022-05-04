using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Milk : Product
    {
        public double Fatness;
        protected double _volume;
        public double Volume
        {
            get { return _volume; }
            set
            {
                while(value != 1)
                {
                    Console.WriteLine("Milk can only be a liter");
                    value = double.Parse(Console.ReadLine());
                }

                
                    _volume = value;
            }
        }
        public Milk(string name, double price,double fatness, double volume):base(name,price)
        {
            Fatness = fatness;
            Volume = volume;
        }
        public override void Sell()
        {
            if (count>0)
            {
                count--;
                TotalIncome += Price;
                Totalsale++;
                Console.WriteLine("The amount of product in stock  =" + " "+count);
                Console.WriteLine("Total income from the product =" + " "+TotalIncome);
                Console.WriteLine("Total sale for the product =" + " " + Totalsale);
                Console.WriteLine("The process is over");
            }
            else
            {
                Console.WriteLine("This product is not in stock");
                Console.WriteLine("The process is over");
            }
        }
    }
}
