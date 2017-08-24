using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingService.Models.Enum
{
    public class Common { }

    public enum AccountingCategory
    {
        [Display(Name = "支出")]
        支出 = 0,
        [Display(Name = "收入")]
        收入
    }
}