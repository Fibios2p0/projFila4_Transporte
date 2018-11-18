using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFila4_Transporte
{
    class Veiculos
    {
        #region atributos
        private Queue<Veiculo> filaVeicDisp = new Queue<Veiculo>();
        #endregion

        #region propriedades
        public Queue<Veiculo> FilaVeicDisp { get { return filaVeicDisp; } }
        #endregion

        #region construtores
        public Veiculos() { }
        #endregion

        #region metodos
        public bool adicionarVeiculo(Veiculo veiculo)
        {
            if (!isVeiculo(veiculo))
            {
                FilaVeicDisp.Enqueue(veiculo);
                return true;
            }
            else return false;
        }

        public bool isVeiculo(Veiculo veiculo)
        {
            foreach (Veiculo v in filaVeicDisp)
            {
                if (v.Equals(veiculo)) return true ;
            }
            return false;
        }



        #endregion
    }
}
