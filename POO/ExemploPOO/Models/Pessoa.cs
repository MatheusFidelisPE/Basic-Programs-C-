using System;
namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome {get; set;}
        public int Idade {get; set;}

        public virtual void Apresentar(){
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }
    }
}