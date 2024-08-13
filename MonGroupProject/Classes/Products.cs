using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes
{
    public class Products
    {
        public delegate void CalcTotalHandler(Products products);
        public event CalcTotalHandler CalcTotalEvent;
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qnt { get; set; }

        public void CalcTotalMethod(Products products)
        {
            CalcTotalEvent?.Invoke(products);
        }

        public double CalcPrice(double price, double Qnt)
        {
            return price * Qnt;
        }
    }
}
