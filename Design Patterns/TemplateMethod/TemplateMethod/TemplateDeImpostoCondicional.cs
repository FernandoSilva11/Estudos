﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional :IImposto
    {
        protected double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
