using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }


    }
}
