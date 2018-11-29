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
        private Queue<Veiculo> filaDeVeiculos = new Queue<Veiculo>();
        #endregion

        #region propriedades
        public Queue<Veiculo> FilaDeVeiculos { get { return filaDeVeiculos; } }
        #endregion

        #region construtores
        public Veiculos() { }
        #endregion

        #region metodos

        public bool adicionarVeiculo(Veiculo veiculo) {
            if (pesquisar(veiculo) == null)
            {
                filaDeVeiculos.Enqueue(veiculo);
                return true;
            }
            else
                return false;
        }
        public Veiculo pesquisar(Veiculo veiculo)
        {
            foreach(Veiculo ve in filaDeVeiculos)
            {
                if (veiculo.Equals(ve))
                    return ve;
            }
            return null;
        }
        #endregion
    }
}
