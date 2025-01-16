using System.Globalization;
using SOLID.Code.Abstracts;
using SOLID.Code.Enum;
using SOLID.Code.Implementations;
using SOLID.Code.Interfaces;

ICalcularDescontoFidelidade descFide = new CalculaDescontoPorFidelidade();

IAplicaDescontoFidelidade descAplicaFide = new AplicaDescontoFidelidade();

ICalculaDescontoStatusContaFactory descConta = new CalculaDescontoStatusContaFactory();

GeraDesconto gerDesc = new GeraDesconto(descFide, descAplicaFide, descConta);

Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

var resultado1 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteComum, 10);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado1}");

var resultado2 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado2}");

var resultado3 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteVIP, 10);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado3}");

Console.WriteLine("\n\nValor da compra 1000 e fidelidade 4 anos (4%)\n");

var resultado4 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteComum, 4);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado4}");

var resultado5 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado5}");

var resultado6 =
    gerDesc.CalcularDesconto(1000, StatusContaCliente.ClienteVIP, 4);
Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado6}");

Console.ReadLine();
