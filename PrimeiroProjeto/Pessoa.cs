using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"O meu nome é {Nome} e eu tenho {Idade} de idade");
        }
    }

   
}
