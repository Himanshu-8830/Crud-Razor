using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_Razor.Model;

namespace Crud_Razor.Data
{
    public class Crud_RazorContext : DbContext
    {
        public Crud_RazorContext (DbContextOptions<Crud_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_Razor.Model.User> User { get; set; } = default!;
    }
}
