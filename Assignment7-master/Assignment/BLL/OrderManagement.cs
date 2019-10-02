using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Assignment9.Repository;

namespace Assignment9.BLL
{
    class OrderManagement
    {
        OrderRepository _orderRepository = new OrderRepository();

        public bool addOrder(string name, string item, int quantity, int totalPrice)
        {
            return _orderRepository.addOrder(name, item,quantity, totalPrice);
        }
        public bool DeleteOrder(int id)
        {
            return _orderRepository.DeleteOrder( id);
        }
        public DataTable ShowCustomerInfo()
        {
            return _orderRepository.ShowCustomerInfo();
        }
        public bool UpdateOrder(string name, string item, int quantity, int totalPrice, int id)
        {
            return _orderRepository.UpdateOrder( name, item, quantity, totalPrice, id);
        }
        public DataTable SearchOrder(string name)
        {
            return _orderRepository.SearchOrder(name);
        }
    }
}
