using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDopravniPodnik.Models
{
    public class Login
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Login musí být zadán")]
        public string LoginName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        [Required(ErrorMessage = "heslo musí být zadáno")]
        public string Password { get; set; }

        public void DoLogin()
        {
            CustomerService1.CusomerServiceClient sw = new CustomerService1.CusomerServiceClient();
            sw.Login(LoginName, Password);
        }

    }
}