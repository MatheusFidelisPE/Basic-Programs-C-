namespace construtores.Modules
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            Y = y;
            X = x;
            Calculadora.EventoCalculadora += EventHandler;
            Calculadora.EventoCalculadora += OtherEventHandler;

        }
        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");

        }
        public void OtherEventHandler()
        {
            System.Console.WriteLine("Segundo método executado");
        }
    }
}