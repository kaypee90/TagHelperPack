﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperPack.Sample.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; } = new Customer();

        public int CustomerId { get; set; }

        [Display(Name = "Placed on", Description = "The date and time the order was placed.")]
        public DateTime PlacedOn { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}
