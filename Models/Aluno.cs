using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
           Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anosde idade, meu e-mail é {Email} e inha nota é {Nota}");
        }
        
    }
}