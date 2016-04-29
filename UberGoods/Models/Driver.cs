using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UberGoods.Models
{
    public class Driver
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string CarBrand { get; set; }

        public string CarModel { get; set; }

        public int CreditCard { get; set; }

    }
}