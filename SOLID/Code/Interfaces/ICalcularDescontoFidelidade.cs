using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Code.Interfaces
{
    public interface ICalcularDescontoFidelidade
    {
        decimal CalculaDescontoPorFidelidade(int tempoDeContaEmAnos);
    }
}
