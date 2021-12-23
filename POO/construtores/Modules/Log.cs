namespace construtores.Modules
{
    public class Log
    {
        private static Log log;
        private Log()
        {

        }
        public string nome { get; set; }
        public static Log getInstance()
        {
            if(log == null)
                log = new Log();
            return log;
        }

    }
}