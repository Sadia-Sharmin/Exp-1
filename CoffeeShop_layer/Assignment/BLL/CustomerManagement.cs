using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Assignment9.Repository;

namespace Assignment9.BLL
{
    class CustomerManagement
    {
        CustomerRepository _customerRepository  = new CustomerRepository();

        public bool InsertCustomer(string name, int number, string address, int code)
        {
            return _customerRepository.InsertCustomer( name, number, address,code);
        }
        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer( id);
        }
        public DataTable ShowCustomerInfo()
        {
            return _customerRepository.ShowCustomerInfo();
        }
        public bool UpdateCustomer(string name, int number, string address, int code, int id)
        {
            return _customerRepository.UpdateCustomer( name,number,address, code,id);
        }
        public DataTable SearchCustomer(string name)
        {
            return _customerRepository.SearchCustomer( name);
        }
        public bool UniqueCustomerName(string name)
        {
            return _customerRepository.UniqueCustomerName( name);
        }
    }
}
