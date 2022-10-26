using Accounting.DataLayer.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Accounting.DataLayer.Bank;
using System.Runtime.Remoting.Contexts;
using Accounting.ViewModels;

namespace Accounting.DataLayer.Services
{
    public class Customer_Repository : ICustomer_Repository
    {
        Accounting_DBEntities db;
        public Customer_Repository(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteCustomer(Customers customer)
        {

            try
            {
                db.Entry(customer).State = EntityState.Deleted; 
                return true;




            }
            catch
            {

                return false;
            }

        }

        public bool DeleteCustomerById(int customerId)
        {
            try
            {

                DeleteCustomer(GetCustomerById(customerId));
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName==name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
           return db.Customers.Find(customerId).FullName;
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
           
           return db.Customers.Where(c=>
           c.Email.Contains(parameter) ||
           c.FullName.Contains(parameter) ||
           c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerModelView> GetNameCustomers(string filter = "")
        {
            if (filter=="")
            {
               return db.Customers.Select(c=> new ListCustomerModelView()
               {
                   CustomerID= c.CustomerID,
                   FullName= c.FullName,
               }).ToList();
            }
          
                return db.Customers.Where(c=> c.FullName.Contains(filter)).Select(c => new ListCustomerModelView()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,
                }).ToList();

            
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {

                db.Customers.Add(customer);
                return true;
            }
            catch
            {

                return false;
            }
        }

        

        public bool UpdateCustomer(Customers customer)
        {
            try
            {

                var local = db.Set<Customers>()
                         .Local
                         .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(customer).State = EntityState.Modified;
                return true;


            }
            catch
            {

                return false;
            }
        }
    }
}
