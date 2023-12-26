using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class AvisosTrafico : IAvisos
    {
        
        
        public AvisosTrafico()
        {

            remetente = "DGT";

            mensagem = "Multa. Infração 349 - Pague antes de 3 dias e terá um desconto de 50%";

            data = "";
        }

        public AvisosTrafico(string remetente, string mensagem, string data)
        {
            this.remetente = remetente;            
            this.mensagem = mensagem;
            this.data = data;
        }

        

        private string remetente;

        private string mensagem;

        private string data;

        public void MostrarAvisos()
        {
            Console.WriteLine("Mensagem {0} foi enviado por {1} no dia {2}", mensagem, remetente, data);
        }

        public string GetData() => data;
    }
}
