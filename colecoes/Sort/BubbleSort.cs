namespace colecoes
{
    public class BubbleSort : OperacoesArrays
    {
        int [] vetor;
        public BubbleSort(int[] vetor) : base(vetor)
        {
            this.vetor = vetor;
        }

        public void OrdenarBubbleSort()
        {
            bool trocas = false;
            do{
                trocas = false;
                for (int i = 0; i < this.vetor.Length - 1; i++)
                {                  
                    if(this.vetor[i] > this.vetor[i+1])
                    {
                        trocas = true;
                        troca(i, i+1);
                    }
                }
            }while(trocas);
        }

        private void troca(int x, int y)
        {
            int temporaria;
            temporaria = this.vetor[x];
            this.vetor[x] = this.vetor[y];
            this.vetor[y] = temporaria;
        }

    }
}