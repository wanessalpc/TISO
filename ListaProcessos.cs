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

        /// <summary>
        /// Verifica se a lista de processo se enconta vazia.
        /// </summary>
        /// <returns></returns>
        public bool Vazia()
        {
            return Sentinela.Prox == null;
        }

        /// <summary>
        /// Adiciona um processo para na fila.
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="ID"></param>
        /// <param name="Prioridade"></param>
        public void Add(string Nome, int ID, int Prioridade) 
        {
            Processo Novo = new Processo(Nome, ID, Prioridade);

        }

        /// <summary>
        /// Remove  o processo de acordo com o nome.
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        public Processo Remove(string Nome)
        {

            return null;
        }

        /// <summary>
        /// Busca um processo de acordo com sua ID.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Processo Buscar(int ID) 
        {

            return null;
        }


        /// <summary>
        /// Altera a prioridade de um processo.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Prioridade"></param>
        public void AlterarPrio(int ID, int Prioridade) 
        {

        }


        /// <summary>
        /// Retorno uma o processo em forma de string.
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return base.ToString();
        }


        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public ListaProcessos() 
        {
            Sentinela = new Processo(null, -1, -1);
            Sentinela.Prox = Sentinela;
        }
    }
}
