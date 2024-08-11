using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes
{
    public class Products
    {
        public delegate void ShowMessage(Products product);
        public event ShowMessage CallMassege;
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qnt { get; set; }
        public void MyMessage(Products product)
        {
            CallMassege?.Invoke(product);
        }
        public double CalcPrice(double price, double Qnt)
        {
            return price * Qnt;
        }
    }
}
