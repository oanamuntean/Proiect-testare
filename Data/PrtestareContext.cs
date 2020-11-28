using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prtestare.Models;

namespace Prtestare.Data
{
    public class PrtestareContext : DbContext
    {
        public PrtestareContext (DbContextOptions<PrtestareContext> options)
            : base(options)
        {
        }

        public DbSet<Prtestare.Models.Movie> Movie { get; set; }
    }
}
