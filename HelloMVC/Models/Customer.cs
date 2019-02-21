using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class Customer
    {
        public string customerId { get; set; }

        [Display(Name = "Customer Name")]
        public string customerName { get; set; }

        [Display(Name = "Contact Number")]
        public string customerPhoneNumber { get; set; }
    }
}