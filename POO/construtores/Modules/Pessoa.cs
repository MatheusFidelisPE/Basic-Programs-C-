namespace construtores.Modules
{
    public class Pessoa
    {
        private readonly string nome;
        private string sobrenome;

        // public Pessoa()
        // {

        // }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {this.nome} {this.sobrenome}");
        }
    }
}