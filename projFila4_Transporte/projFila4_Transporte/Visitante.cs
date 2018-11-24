using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFila4_Transporte
{
    class Visitante
    {
        #region atributos
        private int numeroInscricao;
        #endregion

        #region propriedades
        #endregion

        #region construtores
        public Visitante(int numeroInscricao)
        {
            this.numeroInscricao = numeroInscricao;
        }
        #endregion

        #region metodos

        public String dadosDoVisitante()
        {
            String str = this.numeroInscricao.ToString();
            return str;
        }
        public override bool Equals(object obj)
        {
           Visitante v = (Visitante)obj;
           return this.numeroInscricao.Equals(v.numeroInscricao);
        }
        #endregion
    }
}
