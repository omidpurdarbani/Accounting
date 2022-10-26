using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

using System;

namespace Accounting.DataLayer.Bank
{
    public class SqlBank : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomer_Repository _customer_repository = null;

        public ICustomer_Repository Customer_Repository
        {
            get
            {
                if (_customer_repository == null)
                {
                    _customer_repository = new Customer_Repository(db);
                }

                return _customer_repository;
            }
        }


        private MainRepository<Accounting> _accountingRepository = null;

        public MainRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new MainRepository<Accounting>(db);
                }
                return _accountingRepository;
            }

        }


        private MainRepository<AccountingTypes> _accountingTypeRepository = null;

        public MainRepository<AccountingTypes> AccountingTypeRepository
        {
            get
            {
                if (_accountingTypeRepository == null)
                {
                    _accountingTypeRepository = new MainRepository<AccountingTypes>(db);
                }
                return _accountingTypeRepository;
            }

        }


        private MainRepository<Login> _LoginDB = null;

        public MainRepository<Login> LoginDB
        {
            get
            {
                if (_LoginDB == null)
                {
                    _LoginDB = new MainRepository<Login>(db);
                }
                return _LoginDB;
            }

        }


        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
