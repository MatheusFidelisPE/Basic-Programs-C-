namespace teste
{
    public interface IPrimeiraInterface
    {
         
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);

    }
    class Inter: IPrimeiraInterface{
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IPrimeiraInterface.Nome(string nome){
            this.Nome = nome;
        }
        void IPrimeiraInterface.Dono(string nomeDono){
            this.Dono = nomeDono;
        }
        void IPrimeiraInterface.Especie(string especie){
            this.Especie = especie;
        }
    }
}