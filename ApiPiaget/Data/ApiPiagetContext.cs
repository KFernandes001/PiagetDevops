using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPiaget;

namespace ApiPiaget.Data
{
    public class ApiPiagetContext : DbContext
    {
        public ApiPiagetContext (DbContextOptions<ApiPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPiaget.Aluno> Aluno { get; set; } = default!;
    }
}
