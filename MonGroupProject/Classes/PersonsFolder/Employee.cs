namespace PersonNameSpace
{
    public class Employee : Person
    {
        private double _Salary;
        private double _Detaction;
        private double _Tax;
        private double _Bonus;

        public double Salary { get { return _Salary; } set { _Salary = value; } }
        public double Detaction { get { return _Detaction; } set { _Detaction = value; } }
        public double Tax { get { return _Tax; } set { _Tax = value; } }
        public double Bonus { get { return _Bonus; } set { _Bonus = value; } }
        public Employee()
        {
            
        }
        public Employee(string pName, DateTime pDOB, string pCity, string pAddress, string phoneNumber, string idNumber) : base(pName, pDOB, pCity, pAddress, phoneNumber, idNumber)
        {
            base.Name = pName;
        }

        public override string ShowMessage()
        {
            return "Hello from Employees";
        }
    }
}
