using System;
using colecoes;
namespace Colecoes 
{
    class Program
    {
        static void Main(string[]args)
        {
            // int tam_array = 10;
            // int tamArrCol = 5, tamArrLin= 5;
            // int[] vetor = new int[tam_array];
            // int[,] array_multi = new int[tamArrLin, tamArrCol];
            // Carregando o array com um laço e imprimindo posteriormente
            // for(int i = 0; i < tam_array; i++){
            //     vetor[i] = i+1;
            // }
            // for(int i = 0; i < tam_array; i++)
            // {
            //     Console.WriteLine(vetor[i]);
            // }
            // foreach (int item in vetor)
            // {
            //     Console.Write($"{item} ");
            // }
            // for(int lin = 0; lin < tamArrLin; lin++)
            // {
            //     for(int col = 0; col < tamArrCol; col++)
            //     {
            //         array_multi[lin, col] = lin + col;
            //     }
            // }
            // for(int lin = 0; lin < tamArrLin; lin++)
            // {
            //     for(int col = 0; col < tamArrCol; col++)
            //     {
            //         Console.Write($"{array_multi[lin, col]} ");
            //     }
            //     Console.WriteLine();
            // }

            // int[] vetor = {20, 32, 15, 2, 45, 53, 90, 67, 34};
            // var vetorOrdenar = new BubbleSort(vetor);

            // vetorOrdenar.OrdenarBubbleSort();

            // vetorOrdenar.ImprimirArray();

            // System.Console.WriteLine(string.Join(" ", vetor));
            // BubbleSort.OrdenarBubbleRef(ref vetor);

            // int[] vetorDestino = new int[20];
            // Array.Copy(vetor, vetorDestino,vetor.Length);
            // System.Console.WriteLine(string.Join(" ", vetorDestino));
            // int valorBuscado = 15, threshold = 0;
            // System.Console.WriteLine(Array.Exists(vetor,elemento => elemento == valorBuscado));
            // System.Console.WriteLine(Array.TrueForAll(vetor, elemento => elemento > threshold));
            // System.Console.WriteLine(Array.Find(vetor, elemento => elemento == valorBuscado));
            // System.Console.WriteLine($"O elemento {valorBuscado} foi encontrado na posição {Array.FindIndex(vetor, elemento => elemento == valorBuscado)}");
            // Array.Resize(ref vetorDestino, 50);
            // System.Console.WriteLine(string.Join(" ", vetorDestino));

            // var arrayString = OperacoesArrays.ConverterParaArrayString(vetor);
            // System.Console.WriteLine();

            // List<string> lista = new List<string>();

            // lista.Add("Pernambuco");
            // lista.Add("Paraiba");
            // lista.Add("Rio Grande do Norte");
            // lista.Add("Alagoas");
            // System.Console.WriteLine($"Quantidade de elementos na lista {lista.Count()}");
            // lista.ForEach(elemento => System.Console.WriteLine(elemento));
            // lista.Remove("Paraiba");
            // lista.ForEach(elemento => System.Console.WriteLine(elemento));
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("PE");
            // fila.Enqueue("PB");
            // fila.Enqueue("BA");
            
            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine(fila.Dequeue());
            // }
            // Stack<string> pilha = new Stack<string>();

            // pilha.Push("PE");
            // pilha.Push("PB");
            // pilha.Push("BA");

            // while(pilha.Count() > 0)
            // {
            //     System.Console.WriteLine(pilha.Pop());
            // }

            // Dictionary<string, int> dicionario = new Dictionary<string, int>();

            // dicionario.Add("um", 1);
            // dicionario.Add("dois", 2);
            // dicionario.Add("tres", 3);
            // dicionario.Add("quatro", 4);
            
            // string valorProcurado = "um";


            // System.Console.WriteLine(dicionario[valorProcurado] + dicionario["dois"]);

            // dicionario["um"] = 10;
            // System.Console.WriteLine(dicionario[valorProcurado] + dicionario["dois"]);
            // dicionario.Remove("um");

            // foreach (var item in dicionario)
            // {
            //     System.Console.WriteLine(item.Key +" "+ item.Value);
            // }

            // if(dicionario.TryGetValue("dois", out int algarismoEncontrado))
            // {
            //     System.Console.WriteLine(algarismoEncontrado);
            // }
            int[] numeros = { 2, 10, 4, 13, 12, 7, 9, 9};

            IEnumerable<int> query = 
                from n in numeros
                where n % 2 == 0
                select n;
            foreach (var item in query)
            {
                System.Console.WriteLine(item);
            }
            var query2 = numeros.Where(x => x %2 == 0).OrderBy(x => x).ToList();

            foreach (var item in query2)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}