using ServiceLab.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingService.Models.Service
{
    public class AccountBookService
    {
        private readonly IRepository<AccountBook> _AccountBookRep;
        private readonly IUnitOfWork _unitOfWork;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _AccountBookRep = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountingInfoViewModel> Lookup()
        {
            var source = _AccountBookRep.LookupAll();
            var result = source.Select(accounting => new AccountingInfoViewModel()
            {
                AccountingType = accounting.Categoryyy.ToString(),
                DateTime = accounting.Dateee,
                Amount = accounting.Amounttt 
            }).ToList();
            return result;
        }

        public void Add(AccountingInfoViewModel ViewModel)
        {
            var AccountBook = new AccountBook()
            {
                Categoryyy = int.Parse(ViewModel.AccountingType) ,
                Dateee = ViewModel.DateTime,
                Amounttt = Convert.ToInt32(ViewModel.Amount) 
            };
            _AccountBookRep.Create(AccountBook);
        }

        public bool Save()
        {
            try
            {
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}