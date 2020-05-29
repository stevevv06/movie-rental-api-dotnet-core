﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalNetCore.Models
{
    public class MovieLike
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
