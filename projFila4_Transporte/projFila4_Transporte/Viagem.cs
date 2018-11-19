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
        Queue<Visitante> visitantes = new Queue<Visitante>();
        #endregion

        #region propriedades

        public DateTime HoraViagem { get { return this.horaViagem; } set  {horaViagem = value;} }
        public Veiculo Veiculo { get { return this.veiculo; } set { veiculo = value; } }
        public Queue<Visitante> Visitantes { get { return this.visitantes; } set { this.visitantes = value; } }

        #endregion

        #region construtores

        public Viagem() {

        }

        public Viagem(Veiculo veiculo, DateTime horaViagem, Queue<Visitante> passageiros) {
            this.Veiculo = veiculo;
            this.HoraViagem = horaViagem;
            this.Visitantes = passageiros;
        }

        #endregion

        #region metodos
        public string Dados()
        {
            StringBuilder strBuild = new StringBuilder();

            foreach (Visitante v in visitantes) {

                strBuild.Append(v);
                strBuild.Append(", ");
                
            }

            return $"Veículo: {this.veiculo.Placa} Hora: {this.HoraViagem.Hour} Visitantes: {strBuild.ToString()}";
        }
        #endregion


        #region sobreescritas

        public override bool Equals(object obj)
        {
            Viagem v = (Viagem)obj;
            return this.HoraViagem.Equals(v.HoraViagem);
        }

        #endregion
    }
}
