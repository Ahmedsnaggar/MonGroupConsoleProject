using PersonNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes.Interfaces
{
    public interface IGenericCrudInterface<T>
    {
        public List<T> GetAll();
        public T GetItem(int id);
        public T Add(T item);
        public void Delete(T item);
    }
}
