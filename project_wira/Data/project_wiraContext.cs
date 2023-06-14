using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project_wira.Models;

namespace project_wira.Data
{
    public class project_wiraContext : DbContext
    {
        public project_wiraContext (DbContextOptions<project_wiraContext> options)
            : base(options)
        {
        }

        public DbSet<project_wira.Models.Agen> Agen { get; set; } = default!;
    }
}
