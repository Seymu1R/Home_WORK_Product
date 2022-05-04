using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    abstract class Product
    {
        public string Name;
        public double Price;
        public static int count=100;
        public static double TotalIncome;
        public static int Totalsale ;

        public Product(string name,double price)
        {
           
            Name = name;
            Price = price;
        }
        public abstract void Sell();
            
        
    }
}
