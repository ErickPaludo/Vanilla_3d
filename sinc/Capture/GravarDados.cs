using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class GravarDados
    {
        public GravarDados()
        {
        }

        public GravarDados(int rua, int predio, int la)
        {
            this.rua = rua;
            this.predio = predio;
            this.la = la;
        }

        public int rua {  get; set; }
        public int predio { get; set; }
        public int la { get; set; }
        public void GravarJson(GravarDados dados)
        {
            string novoJson = JsonConvert.SerializeObject(dados);

            // Anexa os novos dados ao arquivo JSON, criando o arquivo se ele não existir
            File.AppendAllText(@"C:\Users\erick\source\Repos\Capture\Capture\obj\Debug\net8.0\dados.json", novoJson + Environment.NewLine);
        }

        public void ExcluirArquivo()
        {
            // Verifica se o arquivo existe antes de tentar excluí-lo
            if (File.Exists(@"C:\Users\erick\source\Repos\Capture\Capture\obj\Debug\net8.0\dados.json"))
            {
                File.Delete((@"C:\Users\erick\source\Repos\Capture\Capture\obj\Debug\net8.0\dados.json"));
            }
        }
    }
}
