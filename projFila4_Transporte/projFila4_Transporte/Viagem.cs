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

        public Viagem(Veiculo veiculo, DateTime horaViagem, Queue<Visitante> visitantes) {
            this.Veiculo = veiculo;
            this.HoraViagem = horaViagem;
            this.Visitantes = visitantes;
        }

        #endregion

        #region metodos
        public string dadosDaViagem()
        {
            return $"Veículo: {this.veiculo.Placa} - Hora: {this.HoraViagem.ToLongTimeString()} - Passageiros: {listaDePassageiros()}";
        }

        private string listaDePassageiros() {

            StringBuilder strB = new StringBuilder();
            int qtdVisitantes = visitantes.Count();
            foreach (Visitante vis in this.visitantes) {

                if (qtdVisitantes > 1)
                {
                    strB.Append(vis.dadosDoVisitante());
                    strB.Append(", ");
                    qtdVisitantes--;
                }
                else {
                    strB.Append(vis.dadosDoVisitante());
                }
                

            }
            return strB.ToString();    
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
