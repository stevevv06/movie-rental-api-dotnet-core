using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalNetCore.Models
{
    public class MoviePurchase
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
