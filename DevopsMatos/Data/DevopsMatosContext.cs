using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevopsMatos.Models;

namespace DevopsMatos.Data
{
    public class DevopsMatosContext : DbContext
    {
        public DevopsMatosContext (DbContextOptions<DevopsMatosContext> options)
            : base(options)
        {
        }

        public DbSet<DevopsMatos.Models.Aluno> Aluno { get; set; } = default!;
    }
}
