using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            var Aluno1 = new Aluno();
            var Professor1 = new Professor();

            Aluno1.Nome = "Carlos";
            Professor1.Nome = "Muguel";

            Aluno1.SeApresentar();
            Professor1.SeApresentar();

        }
    }
}
