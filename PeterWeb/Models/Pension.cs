using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeterWeb.Models
{
    public class Pension
    {
        public DateTime MyEndDate { get; set; }
        [Display(Name ="Månader kvar:")]
        public int MonthsLeft { get; set; }

        [Display(Name ="Veckor kvar:")]
        public int WeeksLeft { get; set; }
        public int DaysLeft { get; set; }
        public int HouresLeft { get; set; }
    }
}