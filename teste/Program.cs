using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
           Inter teste = new Inter();

           teste.Nome = "testando";

           Console.WriteLine(teste.Nome);
            var pessoa1 = (Pessoas)0;
            var pessoa2 = Pessoas.Joao;
        }
    }
}