namespace construtores.Modules
{
    public class Aritmetica
    {
        public static void AdicionarClassEvento(int x, int y)
        {
            Calculadora.novoDelegate += Evento;
        }

        public static int Evento()
        {
            System.Console.WriteLine("Chamada  método Evento");
            return 1;
        }
    }
}