using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes.OrdersFolder
{
    public class OrderHeader : IEnumerable<OrderDetail>
    {
        private List<OrderDetail> _orderDetails = new List<OrderDetail>();
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }
        public void AddOrderDetails(OrderDetail od)
        {
            _orderDetails.Add(od);
        }

        public IEnumerator<OrderDetail> GetEnumerator()
        {
            return _orderDetails.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
