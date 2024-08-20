using PersonNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes.Interfaces
{
    public interface IPersonCrudOperation
    {
        public List<Person> GetAllPersons();
        public Person GetPersonById(int id);
        public Person GetPersonByName(string name);
        public Person AddPerson(Person person);
        public Person UpdatePerson(Person person, int id);
        public void DeletePerson(int Id);
    }
}
