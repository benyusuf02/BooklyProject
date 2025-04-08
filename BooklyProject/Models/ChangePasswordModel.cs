using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooklyProject.Models
{
    public class ChangePasswordModel
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        [Compare("NewPassword",ErrorMessage ="Şifreler Uyuşmamakta")]
        public string ConfirmPassword { get; set; }
    }
}