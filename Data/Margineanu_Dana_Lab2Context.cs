using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Margineanu_Dana_Lab2.Models;

namespace Margineanu_Dana_Lab2.Data
{
    public class Margineanu_Dana_Lab2Context : DbContext
    {
        public Margineanu_Dana_Lab2Context (DbContextOptions<Margineanu_Dana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Margineanu_Dana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Margineanu_Dana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Margineanu_Dana_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
