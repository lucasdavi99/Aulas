using System;

namespace ExemploPOO.Models
{
    public  class Professor : pessoa
    {
            public double Salario { get; set; }

            public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor, e ganho {Salario}");
        }
    }
}