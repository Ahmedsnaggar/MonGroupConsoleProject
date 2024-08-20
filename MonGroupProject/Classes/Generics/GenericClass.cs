using System.Collections;

namespace MonGroupProject.Classes.Generics
{
    public class GenericClass<T> : IEnumerable<T>
    {
        private List<T> _genericList = new List<T>();

        public void AddItem(T itme)
        {
            _genericList.Add(itme);
        }
        public void RemoveItem(T itme) 
        { 
            _genericList.Remove(itme);
        }
        public List<T> GetAllItems()
        {
            return _genericList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _genericList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
