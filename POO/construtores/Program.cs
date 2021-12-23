using construtores.Modules;
namespace construtores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        public static void Main(string[] args)
        {
           Operacao op = new Operacao(Calculadora.SomarStatic);
           op += Calculadora.Subtrair;
           op(10,10);

            Aritmetica.AdicionarClassEvento(10, 12);
            Calculadora.TestaNovoEvento();
            

        }
        
    }
}