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
        private Queue<Visitante> filaEmbarque = new Queue<Visitante>();
        #endregion

        #region propriedades
        public Queue<Visitante> FilaEmbarque { get { return filaEmbarque; } }
        #endregion

        #region construtores
        #endregion

        #region metodos

        public bool adicionarVisitante(Visitante visitante)
        {
            if (!isVisitante(visitante))
            {
                filaEmbarque.Enqueue(visitante);
                return true;
            }
            else return false;
        }

        public bool isVisitante(Visitante visitante)
        {
            foreach (Visitante v in filaEmbarque)
            {
                if (v.Equals(v)) return true;
            }
            return false;
        }


        #endregion
    }
}
