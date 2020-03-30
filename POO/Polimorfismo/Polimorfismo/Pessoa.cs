using System;
using System.Collections.Generic;
using System.Text;


    public class Pessoa
    {
        private string nome;
        private int idade;
        private string sexo;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public virtual void SeApresentar() 
    { }
    }

