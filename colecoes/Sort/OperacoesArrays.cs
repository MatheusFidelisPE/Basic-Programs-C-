namespace colecoes
{
    public class OperacoesArrays
    {
        int[] vetor;
        public OperacoesArrays(int[] vetor)
        {
            this.vetor = vetor;
        }
        public void ImprimirArray()
        {
            for(int i = 0; i < this.vetor.Length; i++)
            {
                System.Console.Write($"{vetor[i]} ");
            }
            System.Console.WriteLine();
        }
        public static string[] ConverterParaArrayString(int[] vetor)
        {
            return Array.ConvertAll(vetor, elemento => elemento.ToString());
        }
    }
}