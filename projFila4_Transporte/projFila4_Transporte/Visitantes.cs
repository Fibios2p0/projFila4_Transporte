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

        #region construtores
        #endregion

        #region metodos

        public bool adicionarVisitante(Visitante visitante)
        {
            try
            {
                filaDeVisitantes.Enqueue(visitante);
                return true;
            }
            catch (Exception e){
                return false;
            }
        }

        #endregion
    }
}
