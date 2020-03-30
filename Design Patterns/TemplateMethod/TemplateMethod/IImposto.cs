using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
   public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
