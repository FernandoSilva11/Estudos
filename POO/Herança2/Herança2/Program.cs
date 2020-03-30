
using System;

namespace Herança2
{
    class Program
    {

        static void Main()
        {
            Aluno A1= new Aluno();
            var P1 = new Professor();
            A1.Nome = "Carlos Silva";
            P1.Nome = "Gerson ";
            A1.Curso = "Engenharia de Software";
            P1.Setor = "Engenharia";
            Console.WriteLine($"O nome do aluno é {A1.Nome} \nO nome do Professor é {P1.Nome}");
            Console.WriteLine($"O curso do aluno é {A1.Curso}\nO setor do Professor é {P1.Setor}");
        }
    }
}