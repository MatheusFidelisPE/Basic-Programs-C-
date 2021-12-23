// See https://aka.ms/new-console-template for more information
using System;
using PilhaName.Exemplos;
namespace prog 
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();
            p.Empilha(1);
            p.Empilha(3);
          
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }    
    }
}

