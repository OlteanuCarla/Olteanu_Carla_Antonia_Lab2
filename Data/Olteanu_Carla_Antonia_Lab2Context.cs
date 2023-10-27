using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Olteanu_Carla_Antonia_Lab2.Models;

namespace Olteanu_Carla_Antonia_Lab2.Data
{
    public class Olteanu_Carla_Antonia_Lab2Context : DbContext
    {
        public Olteanu_Carla_Antonia_Lab2Context (DbContextOptions<Olteanu_Carla_Antonia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Olteanu_Carla_Antonia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Olteanu_Carla_Antonia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Olteanu_Carla_Antonia_Lab2.Models.Author>? Authors { get; set; }

        public DbSet<Olteanu_Carla_Antonia_Lab2.Models.Category>? Category { get; set; }
    }
}
