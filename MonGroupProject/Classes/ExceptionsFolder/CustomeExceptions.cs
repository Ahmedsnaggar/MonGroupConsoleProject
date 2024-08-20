using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes.ExceptionsFolder
{
    public class OutOfStockException : SystemException
    {
        public OutOfStockException()
        {
            
        }
        public OutOfStockException(string message) : base(message) 
        {
            
        }
    }
    public class DatabaseNotFoundException : ApplicationException
    {
        public DatabaseNotFoundException()
        {
            
        }
        public DatabaseNotFoundException(string message) : base(message) 
        {
            
        }
    }
}
