using Microsoft.EntityFrameworkCore;
using Prestamos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prestamos.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
