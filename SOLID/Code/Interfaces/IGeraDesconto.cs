using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Enum;

namespace SOLID.Code.Interfaces
{
    internal interface IGeraDesconto
    {
        decimal CalcularDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos);
    }
}
