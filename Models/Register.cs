using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace CoffeeShop.Models
{
    public class Register
    {
        [Required]
        [Key]
        public string FirstName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}