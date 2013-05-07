using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiqroMoney.Models;

namespace MiqroMoney.ViewModels
{
    public class AccountViewModel
    {
        public MiqroMoney.Models.LocalPasswordModel LocalPassword { get; set; }
        public MiqroMoney.Models.UserProfile Profile { get; set; }
    }
}