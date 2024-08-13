namespace PersonNameSpace
{
    public sealed class CairoCustomers : Customer
    {
        public override double getBalance()
        {
            return 1500;
        }
        public override string ShowMessage()
        {
            return "Hello from Cairo Customers";
        }
    }
}
