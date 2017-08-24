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

            return View(source);
        }
    }
}