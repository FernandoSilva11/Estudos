using ChainOfResposability;

namespace ChainOfResponsibility
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }

    }
}