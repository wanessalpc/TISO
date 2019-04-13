using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TISO
{
    public class Processo
    {
        public Processo Prox { get; set; }
        public int Prioridade { get; set; }
        public string Nome { get; set; }
        public int ID { get; set; }
        public Processo(string Nome, int ID, int Prioridade) // Construtor.
        {
            this.Nome = Nome;
            this.ID = ID;
            this.Prioridade = Prioridade;
        }
    }
}
