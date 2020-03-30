using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
        class IKCV :TemplateDeImpostoCondicional
        {

            protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
            {
                return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
            }

            protected override double MaximaTaxacao(Orcamento orcamento)
            {
            return orcamento.Valor * 0.10;
            }

            protected override double MinimaTaxacao(Orcamento orcamento)
            {
            return orcamento.Valor * 0.06;
            }

            private bool TemItemMaiorQue100Reais(Orcamento orcamento)
            {
                foreach (Item Item in orcamento.Itens)
                {
                    if (Item.Valor > 100) return true;
                }
                return false;
            }



        
        }
}
