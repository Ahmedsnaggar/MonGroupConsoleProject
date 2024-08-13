namespace PersonNameSpace
{
    public class MaadiCustomers : Customer
    {
        public override double getBalance()
        {
            return 5000;
        }
        public override string ShowMessage()
        {
            return "Hello from Maadi Customers";
        }
    }
}
