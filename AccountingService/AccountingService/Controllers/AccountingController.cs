using AccountingService.Models;
using AccountingService.Models.Service;
using ServiceLab.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingService.Controllers
{
    public class AccountingController : Controller
    {
        private readonly AccountBookService _AccountBookSvc;

        public AccountingController()
        {
            // Test Branch
            var unitOfWork = new EFUnitOfWork(); 
            _AccountBookSvc = new AccountBookService(unitOfWork);
        }

        public ActionResult Index()
        {
            var source = _AccountBookSvc.Lookup();

            foreach (AccountingInfoViewModel model in source)
            {
                if ("0".Equals(model.AccountingType))
                    model.AccountingType = "收入";
                if ("1".Equals(model.AccountingType))
                    model.AccountingType = "支出";
            }

            return View(source);
        }
    }
}