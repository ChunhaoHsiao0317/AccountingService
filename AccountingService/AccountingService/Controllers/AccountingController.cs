using AccountingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingService.Controllers
{
    public class AccountingController : Controller
    {
        // GET: Accounting
        public ActionResult Index()
        {
            var AccountList = new List<AccountingInfoViewModel>()
            {
                new AccountingInfoViewModel() { AccountingType = "支出", DateTime = DateTime.Parse("2017/01/01"), Amount = 1000 },
                new AccountingInfoViewModel() { AccountingType = "支出", DateTime = Convert.ToDateTime("2016-01-02"), Amount = 20000 },
                new AccountingInfoViewModel() { AccountingType = "支出", DateTime = Convert.ToDateTime("2016-01-03"), Amount = 30000 },
            };
            return View(AccountList);
        }
    }
}