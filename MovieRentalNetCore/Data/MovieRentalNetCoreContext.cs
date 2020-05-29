using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieRentalNetCore.Models;

namespace MovieRentalNetCore.Data
{
    public class MovieRentalNetCoreContext : DbContext
    {
        public MovieRentalNetCoreContext (DbContextOptions<MovieRentalNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MovieRentalNetCore.Models.Movie> Movie { get; set; }
    }
}
