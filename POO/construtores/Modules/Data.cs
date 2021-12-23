namespace construtores.Modules
{
    public class Data
    {
        private int mes;

        public int GetMes()
        {
            return this.mes;
        }
        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
            }
            else
            {
                System.Console.WriteLine("Valor inválido");
            }
        }
        public int Mes { 
            get
            {
                return this.mes;
            } 
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                }
                else
                {
                    Console.WriteLine("valor inválido");
                }
            } 
            }
    }
}