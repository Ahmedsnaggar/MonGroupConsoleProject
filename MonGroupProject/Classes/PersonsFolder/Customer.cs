using System.Collections;

namespace PersonNameSpace
{
    public abstract class Customer : Person
    {
        public abstract double getBalance();
        #region Properties

        public double StartBalance { get; set; }
        public double OrderTotal { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        #endregion
        public double GetOrderTotal(double orderTotal, double tax, double discount)
        {
            return orderTotal + tax - discount;
        }



    }
}
