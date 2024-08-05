using PersonNameSpace;
#region ListOfPersons


List<Person> personsList = new List<Person>();

DateTime date = new DateTime(2000, 10, 30);

for (int i = 1; i <= 10; i++)
{
    date = date.AddDays(1);
    Person person = new Person();
    person.Name = $"Person {i}";
    person.DOB = date.AddDays(1);
    person.Address = $"Address {i}";
    person.City = $"City {i}";
    person.PhoneNumber = $"Phone {i}";
    person.IdNumber = $"Id {i}";
    if(i%2 == 0)
    {
        person.gender = Gender.Female;
    }
    else
    {
        person.gender = Gender.Male;
    }
    
    personsList.Add(person);
}


//foreach (Person CurPerson in personsList)
//{
//    Console.WriteLine($"Person's name : {CurPerson.Name}, Person's Genger is : {CurPerson.gender}");
//}

#endregion

#region Indexers

Menu menu = new Menu();

Beverage beverage1 = menu[5];

Console.WriteLine($"ID = {beverage1.ID}, Name = {beverage1.Name}");

#endregion


Console.ReadLine();
//Person person1 = null;
//Coffee coffee3 = null;
#region Struct
Coffee coffee = new Coffee(4, "Arabica", "Columbia");

Coffee coffee1 = coffee;
Console.WriteLine("==========Coffe 1 Round 1 =============");
Console.WriteLine($"You choosed #{coffee.strength}, Beans Of {coffee.bean}, From {coffee.origin}");
Console.WriteLine("==========Coffe 2 Round 1 =============");
Console.WriteLine($"You choosed #{coffee1.strength}, Beans Of {coffee1.bean}, From {coffee1.origin}");

coffee1.strength = 5;
coffee1.bean = "Black";
coffee1.origin = "Brazil";

Console.WriteLine("==========Coffe 1 Round 2 =============");
Console.WriteLine($"You choosed #{coffee.strength}, Beans Of {coffee.bean}, From {coffee.origin}");
Console.WriteLine("==========Coffe 2 Round 2 =============");
Console.WriteLine($"You choosed #{coffee1.strength}, Beans Of {coffee1.bean}, From {coffee1.origin}");




public struct Coffee
{
    private  int _strength;
    private string _bean;
    private string _origin;
    public int strength { get { return _strength; } set { _strength = value; } }
    public string bean { get { return _bean; } set { _bean = value; } }
    public string origin { get { return _origin; } set { _origin = value; } }

    public Coffee()
    {
        
    }

    public Coffee(int strength, string bean, string origin)
    {
        _strength = strength;
        _bean = bean;
        _origin = origin;
    }
}

#endregion


public struct Menu
{
    public List<Beverage> beverages = new List<Beverage>();
   
    public Menu()
    {
        for (int i = 1; i <= 10; i++)
        {
            Beverage beverage = new Beverage();
            beverage.ID = i;
            beverage.Name = "Bevarege " + i.ToString();
            beverages.Add(beverage);
        }
    }
    public Beverage this[int index]
    {
        get { return this.beverages[index]; }
        set { this.beverages[index] = value; }
    }


}

public struct Beverage
{
    public int ID;
    public string Name;
}

