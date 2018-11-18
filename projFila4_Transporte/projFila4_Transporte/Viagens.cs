using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFila4_Transporte
{
    class Viagens
    {
        #region atributos
        Queue<Viagem> listaViagens = new Queue<Viagem>();
        #endregion

        #region propriedades
        public Queue<Viagem> ListaViagens { get { return this.listaViagens; } set { this.listaViagens = value; } }
        #endregion

        #region construtores
        #endregion

        #region metodos

        public bool adicionarViagens(Viagem viagem)
        {
            if (!isViagem(viagem))
            {
                ListaViagens.Enqueue(viagem);
                return true;
            }
            else return false;
        }

        public bool isViagem(Viagem viagem)
        {
            foreach (Viagem v in ListaViagens)
            {
                if (v.Equals(v)) return true;
            }
            return false;
        }

        #endregion


    }
}
