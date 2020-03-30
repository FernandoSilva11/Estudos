using System;
using System.Collections.Generic;
using ChainOfResponsibility;
using ChainOfResposability;
namespace ChainOfResposability
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA",250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("BORRACHA", 250));
            orcamento.AdicionaItem(new Item("APONTADOR", 250));
            orcamento.AdicionaItem(new Item("MOCHILA", 250));
            orcamento.AdicionaItem(new Item("LANCHEIRA", 250));

            double desconto = calculador.Cacula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
