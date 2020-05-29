using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalNetCore.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }

        public int Stock { get; set;  }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal RentalPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal SalePrice { get; set; }

        [Required]
        
        public Boolean Available { get; set; }

        public List<MovieRental> MovieRentals { get; set; }

        public List<MoviePurchase> MoviePurchases { get; set; }

        public List<MovieLike> MovieLikes { get; set; }
    }
}
