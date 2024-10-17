using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobrin_Catalina_lab2.Models;

namespace Dobrin_Catalina_lab2.Data
{
    public class Dobrin_Catalina_lab2Context : DbContext
    {
        public Dobrin_Catalina_lab2Context (DbContextOptions<Dobrin_Catalina_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dobrin_Catalina_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dobrin_Catalina_lab2.Models.Publishr> Publisher { get; set; } = default!;
    }
}
