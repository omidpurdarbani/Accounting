using Accounting.DataLayer.Bank;
using Accounting.ViewModels.Accounting;
using System;
using System.Linq;
using System.Runtime.Remoting.Proxies;

namespace Accounting.Business
{
    public class Account
    {
        public static ReciveViewModel ReportFomMain()
        {
            ReciveViewModel reciveViewModel = new ReciveViewModel();
            using (SqlBank db = new SqlBank())
            {
              

                var recive = db.AccountingRepository.Get(a => a.TypeID == 1).Select(a=>a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeID == 2).Select(a => a.Amount).ToList();
                var credit = db.AccountingRepository.Get(a => a.TypeID == 3).Select(a => a.Amount).ToList();
                var more = db.AccountingRepository.Get(a => a.TypeID == 4).Select(a => a.Amount).ToList();
                reciveViewModel.Recive = recive.Sum();
                reciveViewModel.Pay = pay.Sum();
                reciveViewModel.Balance = (recive.Sum()-pay.Sum());
                reciveViewModel.Credit = credit.Sum();
                reciveViewModel.More = more.Sum();
            }
            return reciveViewModel;
        }
        public static ReciveViewModel ReportFomMainThisMonth()
        {
            ReciveViewModel reciveViewModel = new ReciveViewModel();
            using (SqlBank db = new SqlBank())
            {

                DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var recive = db.AccountingRepository.Get(a => a.TypeID == 1&&a.DateTime>=start&&a.DateTime<=end).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTime >= start && a.DateTime <= end).Select(a => a.Amount).ToList();
                var credit = db.AccountingRepository.Get(a => a.TypeID == 3 && a.DateTime >= start && a.DateTime <= end).Select(a => a.Amount).ToList();
                var more = db.AccountingRepository.Get(a => a.TypeID == 4 && a.DateTime >= start && a.DateTime <= end).Select(a => a.Amount).ToList();
                reciveViewModel.Recive = recive.Sum();
                reciveViewModel.Pay = pay.Sum();
                reciveViewModel.Balance = (recive.Sum() - pay.Sum());
                reciveViewModel.Credit = credit.Sum();
                reciveViewModel.More = more.Sum();
            }
            return reciveViewModel;
        }
    }
}
