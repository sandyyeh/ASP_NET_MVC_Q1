using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandy_MVC_20190415_Q1.Models
{
    public class CustomerModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^09[0-9]{8}$", ErrorMessage = "手機號格式不正確")]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}