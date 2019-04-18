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
        public int QtdeCiclos { get; set; }


        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="ID"></param>
        /// <param name="Prioridade"></param>
        public Processo(string Nome, int ID, int Prioridade, int QtdeCiclos) 
        {
            this.Nome = Nome;
            this.ID = ID;
            this.Prioridade = Prioridade;
        }



    }
}
