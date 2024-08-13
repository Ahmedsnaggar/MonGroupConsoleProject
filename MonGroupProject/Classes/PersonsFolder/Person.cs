namespace PersonNameSpace
{
    public class Person
    {
        #region Fields
        private string _Name;
        private DateTime _DOB;
        private string _City;
        private string _Address;
        private string _PhoneNumber;
        private string _IdNumber;
        private Gender _Gender;
        #endregion
        #region Propeties
        public string Name { get { return _Name; } set { _Name = value; } }
        public DateTime DOB { get { return _DOB; } set { _DOB = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }
        public string IdNumber { get { return _IdNumber; } set { _IdNumber = value; } }
        public Gender gender { get { return _Gender; } set { _Gender = value; } }
        #endregion
        #region Constructors
        public Person()
        {
            _Name = "Name 1";
            _DOB = new DateTime(2000, 05, 10);
            _City = "Cairo";
            _Address = "Maady";
            _PhoneNumber = "111555";
            _IdNumber = "12345";
            _Gender = Gender.Male;
        }
        public Person(string pName, DateTime pDOB, string pCity, string pAddress, string phoneNumber, string idNumber)
        {
            _Name = pName;
            _DOB = pDOB;
            _City = pCity;
            _Address = pAddress;
            _PhoneNumber = phoneNumber;
            _IdNumber = idNumber;
        }

        public Person(Person p)
        {
            _Name = p.Name;
            _DOB = p.DOB;
            _City = p.City;
            _Address = p.Address;
            _PhoneNumber = p.PhoneNumber;
            _IdNumber = p._IdNumber;
        }
        #endregion
        #region Methods
        public string ShowName()
        {
            return _Name;
        }
        public static int ShowNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public virtual string ShowMessage()
        {
            return "Hello from Persons";
        }
        #endregion
    }
}
