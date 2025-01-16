using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Abstracts;
using SOLID.Code.Interfaces;

namespace SOLID.Code.Implementations
{
    public class CalcularDescontoFidelidade : ICalcularDescontoFidelidade
    {
        public decimal CalculaDescontoPorFidelidade(int tempoDeContaEmAnos)
        {
            if (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE)
            {
                return (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100;
            }
            else
            {
                return (decimal)tempoDeContaEmAnos / 100;
            }
        }
    }
}
