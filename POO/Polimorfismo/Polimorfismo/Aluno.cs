using System;
using System.Collections.Generic;
using System.Text;


    class Aluno :Pessoa
    {
        public int matricula;
        public string curso;

        public int Matricula { get ; set ; }
        public string Curso { get; set; }
         
         public override void SeApresentar()
        {
        Console.WriteLine("Olá eu sou aluno");
        }
    }

