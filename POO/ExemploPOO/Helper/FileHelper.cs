namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            string[] diretorios = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach (string item in diretorios)
            {
                Console.WriteLine(item);
            }
        }
        public void ListarArquivosDiretorio(string caminho)
        {
            string[] arquivos = Directory.GetFiles(caminho,"*2*",SearchOption.AllDirectories);

            foreach (string item in arquivos)
            {
                System.Console.WriteLine(item);
            }
        }
        public void CriarDiretorio(string nomeDiretorio)
        {
            DirectoryInfo retorno = Directory.CreateDirectory(nomeDiretorio);
            if (retorno.Exists){
                nomeDiretorio = nomeDiretorio + "(1)";
            }
            Directory.CreateDirectory(nomeDiretorio);
            Console.WriteLine(retorno.Exists);

        }
        public void ApagarDiretorio(string caminho)
        {
            Directory.Delete(caminho,true);
        }

        public void criarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
                File.WriteAllText(caminho, conteudo);
            else{
                Console.WriteLine("O Arquivo de texto já existe!");
            } 

        }
        public void CriarArquivoTextoStream(string caminho, List<string> linhas)
        {
            using(StreamWriter stream = File.CreateText(caminho))
            {
                foreach(string item in linhas)
                {
                    stream.WriteLine(item);
                }
            }
        }
        public void EditarArquivoTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);

        }   

        public void EditarTextoStream(string caminho, List<string> linhas)
        {
            using(StreamWriter stream = File.AppendText(caminho))
            {
                foreach(string item in linhas)
                {
                    stream.WriteLine(item);
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            string[] linhas = File.ReadAllLines(caminho);
            foreach (string item in linhas)
            {
                Console.WriteLine(item);
            }            
        }
        public void LerArquivoStream(string caminho)        
        {
            string linha = string.Empty;

            using(StreamReader stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminhoAtual, string caminhoNovo)
        {
            File.Move(caminhoAtual,caminhoNovo);
        }
        public void CopiarArquivo(string caminhoAtual, string caminhoNovo)
        {
            File.Copy(caminhoAtual,caminhoNovo);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}