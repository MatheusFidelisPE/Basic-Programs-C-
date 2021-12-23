using System;
using CadastroDeAlunos.Estudante;
using CadastroDeAlunos.Cadeira;

namespace CadastroDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {   
            string opcaoUsuario;
            Turma turma = new Turma(5);
            do
            {
                Console.WriteLine("----------------------\n        MENU         \n----------------------");
                Console.WriteLine("1- Inserir aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Calcular Média geral");
                Console.WriteLine("x- Sair");

                opcaoUsuario = Console.ReadLine();

                if (opcaoUsuario == "x")
                    break;

                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar Aluno
                        
                        Console.Write("Informe o nome do aluno: ");
                        string nome = Console.ReadLine();
                        double media;
                        Console.Write("Informe a média do aluno: ");
                        
                        if(double.TryParse(Console.ReadLine(), out double nota)){
                            media = nota;
                        }else{
                            throw new ArgumentException("Valor não é numérico!");
                        }

                        Aluno aluno = new Aluno(nome, media);
                        turma.adicionarAluno(aluno);
                        break;
                    case "2":
                        //TODO: Listar Alunos
                        turma.listarALunos();
                        break;
                    case "3":
                        //TODO: Média Geral
                        Console.WriteLine($"Média geral dos alunos adicionados: {turma.mediaAlunos()}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida!");
                        break;
                }
            }while(true);
        }
    }
}