using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
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
