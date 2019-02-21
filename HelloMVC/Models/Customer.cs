using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//Using Class Decoration for validation
namespace HelloMVC.Models
{
    public class Customer
    {
        public string customerId { get; set; }
        
        [Required(ErrorMessage ="Must enter Name")]
        [MinLength(3, ErrorMessage ="Name must be longer than 3 characters")]
        [Display(Name = "Customer Name")]
        public string customerName { get; set; }

        [Required(ErrorMessage = "Must enter Phone Number")]
        [Display(Name = "Contact Number")]
        public string customerPhoneNumber { get; set; }
    }
}