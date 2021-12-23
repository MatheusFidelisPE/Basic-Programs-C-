using CadastroDeAlunos.Estudante;
namespace CadastroDeAlunos.Cadeira
{
    public struct Turma
    {
        Aluno[] caderneta;
        private int tamanhoTurma;
        private int contagemAlunos;
        public Turma(int tamanhoTurma){
            this.tamanhoTurma = tamanhoTurma;
            caderneta = new Aluno[tamanhoTurma];
            this.contagemAlunos = 0;
        }

        public void adicionarAluno(Aluno aluno){
           if (contagemAlunos < tamanhoTurma){
               //TODO: adicionar aluno na turma
               this.caderneta[contagemAlunos] = aluno;
               this.contagemAlunos += 1;
           } 
           else{
               throw new ArgumentOutOfRangeException("Turma completa!");
           }
        }

        public void listarALunos(){
            foreach(Aluno a in caderneta){
                if (a != null){
                    Console.WriteLine($"{a.getNome()} --------- {(a.getMedia())}");
                }
            }
        }
        public double mediaAlunos(){
            double mediaGeral = 0;
            foreach(Aluno a in caderneta){
                if(a != null){
                    mediaGeral += a.getMedia();
                }else{
                    break;
                }
                
            }
            return mediaGeral/this.contagemAlunos;
        }

    }
}