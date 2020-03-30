using ChainOfResposability;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {
        public double Cacula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDe500Reais();
            IDesconto d3 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            return d1.Desconta(orcamento);
        }


    }
}
