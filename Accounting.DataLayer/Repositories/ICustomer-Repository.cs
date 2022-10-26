using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Bank;
using Accounting.ViewModels;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomer_Repository
    {


        List<Customers> GetAllCustomers();


        IEnumerable<Customers> GetCustomersByFilter(String parameter);

        List<ListCustomerModelView> GetNameCustomers(String filter="");

        Customers GetCustomerById(int customerId);

        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomerById(int customerId);

        int GetCustomerIdByName(String name);
        string GetCustomerNameById(int customerId);
    
    }
}
