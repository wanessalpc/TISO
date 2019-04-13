using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TISO
{
    public class ListaProcessos
    {
        Processo Sentinela;
        public bool Vazia()
        {
            return Sentinela.Prox == null;
        }
        public void Add(string Nome, int ID, int Prioridade) // Adicionar processo.
        {
            Processo Novo = new Processo(Nome, ID, Prioridade);

        }
        public Processo Remove(string Nome) // Remove processo.
        {

            return null;
        }
        public Processo Buscar(int ID) // Busca processo por ID.
        {

            return null;
        }
        public void AlterarPrio(int ID, int Prioridade) // Altera prioridade do processo por ID.
        {

        }
        public override string ToString() // Imprime processos.
        {
            return base.ToString();
        }
        public ListaProcessos() // Construtor.
        {
            Sentinela = new Processo(null, -1, -1);
            Sentinela.Prox = Sentinela;
        }
    }
}
