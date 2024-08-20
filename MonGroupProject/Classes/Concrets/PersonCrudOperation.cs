using MonGroupProject.Classes.Interfaces;
using PersonNameSpace;

namespace MonGroupProject.Classes.Concrets
{
    public class PersonCrudOperation : IPersonCrudOperation, IBaseInterface
    {
        public List<Person> personsList = new List<Person>();
        public PersonCrudOperation()
        {
            DateTime date = new DateTime(2000, 10, 30);

            for (int i = 1; i <= 50; i++)
            {
                date = date.AddDays(1);
                Person person = new Person();
                person.Id = i;
                person.Name = $"Person {i}";
                person.DOB = date.AddDays(1);
                person.Address = $"Address {i}";
                person.City = $"City {i}";
                person.PhoneNumber = $"Phone {i}";
                person.IdNumber = $"Id {i}";
                if (i % 2 == 0)
                {
                    person.gender = Gender.Female;
                }
                else
                {
                    person.gender = Gender.Male;
                }

                personsList.Add(person);
            }
        }
        public Person AddPerson(Person person)
        {
            personsList.Add(person);
            return person;
        }

        public void DeletePerson(int Id)
        {
            Person person = GetPersonById(Id);
            personsList.Remove(person);
        }

        public List<Person> GetAllPersons()
        {
            return personsList;
        }

        public Person GetPersonById(int id)
        {
            Person person = personsList.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                person = new Person();
            }

            return person;
        }

        public Person GetPersonByName(string name)
        {
            return personsList.FirstOrDefault(p => p.Name.Contains(name));
        }

        public string ShowMessage()
        {
            throw new NotImplementedException();
        }

        public Person UpdatePerson(Person person, int id)
        {
            Person person1 = GetPersonById(id);
            person1.Name = person.Name;
            person1.Address = person.Address;
            return person1;
        }
    }
}
