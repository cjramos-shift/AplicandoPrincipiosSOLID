using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Interfaces;

namespace SOLID.Code.Implementations
{
    public class AplicaDescontoFidelidade : IAplicaDescontoFidelidade
    {
        public decimal AplicaDescontoPorFidelidade(decimal precoAntesDoDesconto, decimal descontoPorFidelidade)
        {
            return precoAntesDoDesconto = precoAntesDoDesconto - (descontoPorFidelidade * precoAntesDoDesconto);
        }
    }
}
