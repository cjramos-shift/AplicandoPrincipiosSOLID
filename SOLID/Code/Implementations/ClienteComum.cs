using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Abstracts;
using SOLID.Code.Interfaces;

namespace SOLID.Code.Implementations
{
    public class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal CalculaDescontoStatusConta(decimal precoDepoisDoDesconto)
        {
            precoDepoisDoDesconto -= (Constantes.DESCONTO_CLIENTE_COMUM * precoDepoisDoDesconto);

            return precoDepoisDoDesconto;
        }
    }
}
