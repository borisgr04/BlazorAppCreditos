using BlazorApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CreditoContext : DbContext
    {
        public CreditoContext(DbContextOptions<CreditoContext> options) : base(options)
        {

        }
        public DbSet<Credito> Creditos { get; set; }
    }
}
