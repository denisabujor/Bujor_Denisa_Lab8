using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bujor_Denisa_Lab8.Models;

namespace Bujor_Denisa_Lab8.Data
{
    public class Bujor_Denisa_Lab8Context : DbContext
    {
        public Bujor_Denisa_Lab8Context (DbContextOptions<Bujor_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bujor_Denisa_Lab8.Models.Book> Book { get; set; }
    }
}
