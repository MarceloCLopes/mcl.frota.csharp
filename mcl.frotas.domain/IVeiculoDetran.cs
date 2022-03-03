using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mcl.frotas.domain
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}
