using MonGroupProject.Classes.Interfaces;
using PersonNameSpace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes.Concrets
{
    public class GenericCrudClass<T> : IGenericCrudInterface<T>, IEnumerable<T>
    {
        private List<T> _list = new List<T>();
        public T Add(T item)
        {
            _list.Add(item);
            return item;
        }

        public void Delete(T item)
        {
            _list.Remove(item);
        }

        public List<T> GetAll()
        {
            return _list;
        }

        

        public T GetItem(int id)
        {
            Predicate<T> predicate = _list.Contains;
            return _list.Find(predicate);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
