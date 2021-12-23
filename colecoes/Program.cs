using System;

namespace Colecoes 
{
    class Program
    {
        static void Main(string[]args)
        {   
            int tam_array = 10;
            int tamArrCol = 5, tamArrLin= 5;
            int[] vetor = new int[tam_array];
            int[,] array_multi = new int[tamArrLin, tamArrCol];
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
            for(int lin = 0; lin < tamArrLin; lin++)
            {
                for(int col = 0; col < tamArrCol; col++)
                {
                    array_multi[lin, col] = lin + col;
                }
            }
            for(int lin = 0; lin < tamArrLin; lin++)
            {
                for(int col = 0; col < tamArrCol; col++)
                {
                    Console.Write($"{array_multi[lin, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}