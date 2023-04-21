﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookShopAsp.Models
{
    public class Order
    {
        // Order ID
        public int Id { get; set; }
        // Customer's first and last name
        [Required]
        [Display(Name = "Customer")]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
        // Customer's address
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        // Book ID
        [Required, Display(Name = "Book")]
        public int BookId { get; set; }
        public Book? Book { get; set; }
        // Purchase date
        [DataType(DataType.Date), Display(Name = "Date")]
        public DateTime Date { get; set; }
    }
}