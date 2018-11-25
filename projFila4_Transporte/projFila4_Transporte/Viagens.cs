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
        Queue<Viagem> listaViagens;
        #endregion

        #region propriedades
        public Queue<Viagem> ListaViagens { get { return this.listaViagens; } set { this.listaViagens = value; } }
        #endregion

        #region construtores
        #endregion
        public Viagens()
        {
            listaViagens = new Queue<Viagem>();
        }
        #region metodos

        public bool adicionarViagens(Viagem viagem)
        {
            try {
                this.listaViagens.Enqueue(viagem);
                return true;
            }
            catch
            {
                return false;
            }            
        }

        public Viagem pesquisar(Viagem viagem)
        {
            foreach (Viagem vig in listaViagens)
            {
                if (viagem.Equals(vig))
                    return vig;
            }
            return null;
        }


        #endregion


    }
}
