using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFila4_Transporte
{
    class Viagem
    {
        #region atributos
        Veiculo veiculo;
        DateTime horaViagem;
        Queue<Visitante> passageiros = new Queue<Visitante>();
        #endregion

        #region propriedades

        public DateTime HoraViagem { get { return this.horaViagem; } set  {horaViagem = value;} }
        public Veiculo Veiculo { get { return this.veiculo; } set { veiculo = value; } }
        public Queue<Visitante> Passageiros { get { return this.passageiros; } set { this.passageiros = value; } }

        #endregion

        #region construtores

        public Viagem() {

        }

        public Viagem(Veiculo veiculo, DateTime horaViagem, Queue<Visitante> passageiros) {
            this.Veiculo = veiculo;
            this.HoraViagem = horaViagem;
            this.Passageiros = passageiros;
        }

        #endregion

        #region metodos
        public string Dados()
        {
            return $"Veiculo placa {Veiculo.Placa} Hora: {HoraViagem} Tranferiu os vistantes:\n{Passageiros}  ";
        }
        #endregion
    }
}
