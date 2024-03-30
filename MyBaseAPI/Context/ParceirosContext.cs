using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBaseAPI.Entities;
namespace MyBaseAPI.Context
{
    public class ParceirosContext : DbContext
    {
        public ParceirosContext(DbContextOptions<ParceirosContext> options) : base (options) 
        {
            
        }

        public DbSet<Contato> Contatos { get; set; } 
    }
}