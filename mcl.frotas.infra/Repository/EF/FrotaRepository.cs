using mcl.frotas.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace mcl.frotas.infra.Repository.EF
{
    public class FrotaRepository : IVeiculoRepository
    {
        private readonly FrotaContext dbContext;

        public FrotaRepository(FrotaContext dbContext) => this.dbContext = dbContext;
        public void Add(Veiculo veiculo)
        {
            dbContext.Veiculos.Add(veiculo);
            dbContext.SaveChanges();
        }

        public void Delete(Veiculo veiculo)
        {
            dbContext.Veiculos.Remove(veiculo);
            dbContext.SaveChanges();
        }

        public IEnumerable<Veiculo> GetAll() => dbContext.Veiculos.ToListAsync().Result;


        public Veiculo GetById(Guid id) => dbContext.Veiculos.SingleOrDefaultAsync().Result;
        

        public void Update(Veiculo veiculo)
        {
            dbContext.Entry(veiculo).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
