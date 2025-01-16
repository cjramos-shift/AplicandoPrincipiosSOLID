using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Code.Abstracts;
using SOLID.Code.Enum;
using SOLID.Code.Interfaces;

namespace SOLID.Code.Implementations
{
    public class GeraDesconto : IGeraDesconto
    {
        public decimal precoProduto { get; set; }
        public int tempoDeContaEmAnos { get; set; }
        public decimal descontoPorFidelidade { get; set; }
        private decimal precoDepoisDoDesconto { get; set; } = 0;

        private readonly ICalcularDescontoFidelidade _calcularDescontoFidelidade;
        private readonly IAplicaDescontoFidelidade _aplicaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory;

        public GeraDesconto(ICalcularDescontoFidelidade calcularDescontoFidelidade, IAplicaDescontoFidelidade aplicaDescontoFidelidade, ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
        {
            _calcularDescontoFidelidade = calcularDescontoFidelidade;
            _aplicaDescontoFidelidade = aplicaDescontoFidelidade;
            _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;
        }

        public decimal CalcularDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = _calcularDescontoFidelidade.CalculaDescontoPorFidelidade(tempoDeContaEmAnos);

            precoDepoisDoDesconto = _calculaDescontoStatusContaFactory.GetCalculoDescontoStatusConta(statusContaCliente).CalculaDescontoStatusConta(precoProduto);

            precoDepoisDoDesconto = _aplicaDescontoFidelidade.AplicaDescontoPorFidelidade(precoDepoisDoDesconto, descontoPorFidelidade);

            return precoDepoisDoDesconto;
        }

    }
}

