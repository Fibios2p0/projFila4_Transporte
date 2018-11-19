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

        public bool adicionarVeiculo(Veiculo veiculo){
            try{
                filaDeVeiculos.Enqueue(veiculo);
                return true;
            }
            catch (Exception e){
                return false;
            }
        }

        public bool temVeiculo() {
            if (filaDeVeiculos.Count() > 0) {
                return true;
            }
            return false;
        }

        #endregion
    }
}
