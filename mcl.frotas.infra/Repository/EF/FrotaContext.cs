using mcl.frotas.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace mcl.frotas.infra.Repository.EF
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
