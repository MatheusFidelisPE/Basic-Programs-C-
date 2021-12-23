namespace CadastroDeAlunos.Estudante
{
    public class Aluno
    {
        private double media;
        private string nome;

        public Aluno(string nome, double media){
            this.nome = nome;
            this.media = media;
        }

        public string getNome(){
            return this.nome;
        }
        public double getMedia(){
            return this.media;
        }
    }
}