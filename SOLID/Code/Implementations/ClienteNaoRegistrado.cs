using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Abstracts;
using SOLID.Code.Interfaces;

namespace SOLID.Code.Implementations
{
    public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal CalculaDescontoStatusConta(decimal precoDepoisDoDesconto)
        {
            return precoDepoisDoDesconto;
        }
    }
}
