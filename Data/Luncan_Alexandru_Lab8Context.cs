using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Luncan_Alexandru_Lab8.Models;

namespace Luncan_Alexandru_Lab8.Data
{
    public class Luncan_Alexandru_Lab8Context : DbContext
    {
        public Luncan_Alexandru_Lab8Context (DbContextOptions<Luncan_Alexandru_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Luncan_Alexandru_Lab8.Models.Book> Book { get; set; }
    }
}
