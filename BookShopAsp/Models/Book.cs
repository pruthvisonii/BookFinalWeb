using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookShopAsp.Models
{
    public class Book
    {
        // Book ID
        public int Id { get; set; }
        // Book name
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        // Book author
        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        // Book price
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

    }
}
