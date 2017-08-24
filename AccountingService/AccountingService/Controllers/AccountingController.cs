using AccountingService.Models;
using AccountingService.Models.Service;
using PagedList;
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

        int defaultPageSize = 10;

        public AccountingController()
        {
            // Test Branch
            var unitOfWork = new EFUnitOfWork(); 
            _AccountBookSvc = new AccountBookService(unitOfWork);
        }

        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var source = _AccountBookSvc.Lookup().OrderBy(x => x.DateTime);

            

            return View(source.ToPagedList(page, pagesize));
        }
    }
}