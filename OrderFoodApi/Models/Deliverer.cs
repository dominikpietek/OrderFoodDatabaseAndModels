﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using OrderFoodApi.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace OrderFoodApi.Models
{
    public class Deliverer : ModelBase
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [PhoneNumber]
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<DelivererReview> Reviews { get; set; } = new List<DelivererReview>();
    }
}
