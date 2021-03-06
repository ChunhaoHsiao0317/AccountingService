﻿using AccountingService.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace AccountingService.Models
{
    public class AccountingInfoViewModel
    {
        [Display(Name = "類別")]
        public AccountingCategory AccountingType { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateTime { get; set; }
        
        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:#,0}")]
        public decimal Amount { get; set; }
    }
}