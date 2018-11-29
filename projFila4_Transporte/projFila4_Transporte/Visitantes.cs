using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFila4_Transporte
{
    class Visitantes
    {
        #region atributos
        private Queue<Visitante> filaDeVisitantes = new Queue<Visitante>();
        #endregion

        #region propriedades
        public Queue<Visitante> FilaDeVisitantes { get { return filaDeVisitantes; } }
        #endregion

        #region metodos

        public bool adicionarVisitante(Visitante visitante)
        {
            if (pesquisar(visitante) == null)
            {
                FilaDeVisitantes.Enqueue(visitante);
                return true;
            }
            else
                return false;
        }
        public Visitante pesquisar(Visitante visitante)
        {
            foreach (Visitante vis in filaDeVisitantes)
            {
                if (vis.Equals(visitante))
                    return vis;
            }
            return null;
        }

        #endregion
    }
}
