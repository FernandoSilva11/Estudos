using System;
using System.Collections.Generic;
using System.Text;

    class Professor:Pessoa
    {
        private string setor;
        private bool trabalhando;

        public string Setor { get; set; }
        public bool Trabalhando { get; set; }

        
        public override void SeApresentar()
        {
        Console.WriteLine("Ola eu sou professor");
        }


    }

