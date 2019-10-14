using Assignment8.DAL;
using Assignment8.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer _customer)
        {
            return _customerRepository.Add(_customer);
        }
        public bool IsNameExists(Customer _customer)
        {
            return _customerRepository.IsNameExists(_customer);
        }
        public DataTable Display()
        {
            return _customerRepository.Display();
        }
        public bool Delete(Customer _customer)
        {
            return _customerRepository.Delete(_customer);
        }
        public bool Update(Customer _customer)
        {
            return _customerRepository.Update(_customer);
        }
        public DataTable Search(Customer _customer)
        {
            return _customerRepository.Search(_customer);
        }
    }
}
