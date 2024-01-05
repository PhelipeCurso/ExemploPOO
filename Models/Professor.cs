using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} tenho {Idade} anos de idade,Meu e-mail é {Email} e meu salario é {Salario}");
        }
    }
}