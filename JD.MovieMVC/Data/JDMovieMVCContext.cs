using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JD.MovieMVC.Models
{
    public class JDMovieMVCContext : DbContext
    {
        public JDMovieMVCContext(DbContextOptions<JDMovieMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JD.MovieMVC.Models.Movie> Movie { get; set; }
    }
}
