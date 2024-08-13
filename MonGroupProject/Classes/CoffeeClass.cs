using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes
{
    public class CoffeeClass
    {
        public delegate void OutOfBeansHadler(CoffeeClass coffee);
        public event OutOfBeansHadler OnOutOfBeansHadler;

        public string name {  get; set; }
        public double Pric { get; set; }

        public void outOfBeans(CoffeeClass coffee)
        {
            OnOutOfBeansHadler?.Invoke(coffee);
        }
    }
}
