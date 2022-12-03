using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munteanu_Elena_Lab222.Models;

namespace Munteanu_Elena_Lab222.Data
{
    public class Munteanu_Elena_Lab222Context : DbContext
    {
        public Munteanu_Elena_Lab222Context (DbContextOptions<Munteanu_Elena_Lab222Context> options)
            : base(options)
        {
        }

        public DbSet<Munteanu_Elena_Lab222.Models.Book> Book { get; set; } = default!;

        public DbSet<Munteanu_Elena_Lab222.Models.Publisher> Publisher { get; set; }

        public DbSet<Munteanu_Elena_Lab222.Models.Author> Author { get; set; }
    }
}
