using PersonNameSpace;

#region Luc05/08/2024

#region ListOfPersons


//List<Person> personsList = new List<Person>();

//DateTime date = new DateTime(2000, 10, 30);

//for (int i = 1; i <= 10; i++)
//{
//date = date.AddDays(1);
//Person person = new Person();
//person.Name = $"Person {i}";
//person.DOB = date.AddDays(1);
//person.Address = $"Address {i}";
//person.City = $"City {i}";
//person.PhoneNumber = $"Phone {i}";
//person.IdNumber = $"Id {i}";
//if (i % 2 == 0)
//{
//person.gender = Gender.Female;
//}
//else
//{
//person.gender = Gender.Male;
//}

//personsList.Add(person);
//}


////foreach (Person CurPerson in personsList)
////{
////    Console.WriteLine($"Person's name : {CurPerson.Name}, Person's Genger is : {CurPerson.gender}");
////}

//#endregion

//#region Indexers

//Menu menu = new Menu();

//Beverage beverage1 = menu[5];

//Console.WriteLine($"ID = {beverage1.ID}, Name = {beverage1.Name}");

//#endregion


//Console.ReadLine();
////Person person1 = null;
////Coffee coffee3 = null;
//#region Struct
//Coffee coffee = new Coffee(4, "Arabica", "Columbia");

//Coffee coffee1 = coffee;
//Console.WriteLine("==========Coffe 1 Round 1 =============");
//Console.WriteLine($"You choosed #{coffee.strength}, Beans Of {coffee.bean}, From {coffee.origin}");
//Console.WriteLine("==========Coffe 2 Round 1 =============");
//Console.WriteLine($"You choosed #{coffee1.strength}, Beans Of {coffee1.bean}, From {coffee1.origin}");

//coffee1.strength = 5;
//coffee1.bean = "Black";
//coffee1.origin = "Brazil";

//Console.WriteLine("==========Coffe 1 Round 2 =============");
//Console.WriteLine($"You choosed #{coffee.strength}, Beans Of {coffee.bean}, From {coffee.origin}");
//Console.WriteLine("==========Coffe 2 Round 2 =============");
//Console.WriteLine($"You choosed #{coffee1.strength}, Beans Of {coffee1.bean}, From {coffee1.origin}");




//public struct Coffee
//{
//    private int _strength;
//    private string _bean;
//    private string _origin;
//    public int strength { get { return _strength; } set { _strength = value; } }
//    public string bean { get { return _bean; } set { _bean = value; } }
//    public string origin { get { return _origin; } set { _origin = value; } }

//    public Coffee()
//    {

//    }

//    public Coffee(int strength, string bean, string origin)
//    {
//        _strength = strength;
//        _bean = bean;
//        _origin = origin;
//    }
//}

#endregion


//public struct Menu
//{
//    public List<Beverage> beverages = new List<Beverage>();

//    public Menu()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Beverage beverage = new Beverage();
//            beverage.ID = i;
//            beverage.Name = "Bevarege " + i.ToString();
//            beverages.Add(beverage);
//        }
//    }
//    public Beverage this[int index]
//    {
//        get { return this.beverages[index]; }
//        set { this.beverages[index] = value; }
//    }


//}

//public struct Beverage
//{
//    public int ID;
//    public string Name;
//}
#endregion

#region Luc10/08/2024
#region Stack&Queue
//Stack<int> stackList = new Stack<int>();

//for (int i = 1; i<=10; i++)
//{
//    stackList.Push(i);
//}


//for(int i = 0; i< stackList.Count; i++)
//{
//    //Console.WriteLine(stackList.Pop());
//    Console.WriteLine(stackList.ElementAt(i));
//}
//Queue<int> intQueue = new Queue<int> ();
//for (int i = 1; i <= 10; i++)
//{
//    intQueue.Enqueue (i);
//}
//intQueue.Dequeue ();
//for (int i = 0; i < intQueue.Count; i++)
//{

//    Console.WriteLine(intQueue.ElementAt(i));
//}
#endregion

#region Dictionary
//using System.Collections;

//SortedList sl = new SortedList();
//sl.Add("ID", 5);
//sl.Add("Name", "New Horiazons");

//Console.WriteLine(sl["Name"]);

//SortedList<int, string> sl2 = new SortedList<int, string>();
//for (int i = 1; i <= 10; i++)
//{
//    sl2.Add(i, $"Name {i}");
//}

////foreach(var item in sl2)
////{
////    Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
////}
//foreach (string item in sl2.Values)
//{
//    Console.WriteLine($"Value : {item}");
//}
//SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
//keyValuePairs.Add(5, 1);
//keyValuePairs.Add(1, 2);
#endregion

#region ArrayList
//using PersonNameSpace;
//using System.Collections;

//ArrayList arrayList = new ArrayList();
//Person person1 = new Person();
//arrayList.Add(1);
//arrayList.Add("Ahmed");
//arrayList.Add(false);
//arrayList.Add(person1);

//foreach (var i in arrayList)
//{
//    //if (i.GetType() == typeof(Person))
//    //{
//    //    Person person2 = (Person)i;
//    //    Console.WriteLine(i);
//    //}
//    //else { Console.WriteLine(i); }
//    if (i is Person)
//    {
//        Person person2 = (Person)i;
//        Console.WriteLine(i);
//    }
//    else { Console.WriteLine(i); }

//}
#endregion

#region Delegates
//using MonGroupProject.Classes;

//int num1 = 20;
//int num2 = 10;

////calc(num1, num2, add);
//calc(num1, num2, subtruct);
//calc(num1, num2, multi);
//calc(num1, num2, Div);

//calc(num1, num2, delegate(int num1, int num2) {  return num1 + num2; });
//calc(num1, num2, (int number1,int number2) => number1 + number2);

//void calc(int number1, int number2, Calculate ope)
//{
//   Console.WriteLine( ope(number1, number2));
//}

////int add(int number1, int number2) 
////{
////    return number1 + number2;
////}
//int subtruct(int number1, int number2)
//{
//    return number1 - number2;
//}
//int multi(int number1, int number2)
//{
//    return number1 * number2;
//}
//int Div(int number1, int number2)
//{
//    return number1 / number2;
//}

//string str = "Text";


//CallName(str, upperText);
//CallName(str, lowerCase);
//CallName(str, sub);
//CallName(str, (str1) => str1.ToUpper());
//void CallName(string text, textDelegate dlg)
//{
//    dlg(text);
//    Console.WriteLine(text);
//}

//void upperText(string text)
//{
//    Console.WriteLine(text.ToUpper());
//}
//void lowerCase(string text)
//{
//    Console.WriteLine(text.ToLower());
//}
//void sub(string text)
//{
//    Console.WriteLine(text.Substring(1, 1));
//}
#endregion

#region Products
//using MonGroupProject.Classes;

//List<Products> productsList = new List<Products>();

//for (int i = 1; i <= 50; i++)
//{
//    Random rand = new Random();
//    Products products = new Products();
//    products.Name = $"Product {i.ToString()}";
//    products.Price = rand.Next(50, 100);
//    products.Qnt = rand.Next(1, 10);
//    productsList.Add(products);
//}

//foreach (Products product in productsList)
//{
//    product.CallMassege += Message;
//    product.MyMessage(product);
//    Console.WriteLine($"Product Name : {product.Name}, Price : {product.Price}, Quantity : {product.Qnt}, Total {product.CalcPrice(product.Price, product.Qnt)}");
//}

//void Message(Products product)
//{
//    Console.WriteLine(product.Name);
//}

#endregion
#endregion

Console.ReadLine();
delegate void textDelegate(string text);
delegate int Calculate(int number1, int number2);