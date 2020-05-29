using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalNetCore.Models
{
    public class MovieRental
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
        public decimal Penalty { get; set; }

        public decimal Amount { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
