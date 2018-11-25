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
        Queue<Visitante> visitantes;
        #endregion

        #region propriedades

        public DateTime HoraViagem { get { return this.horaViagem; } set  {horaViagem = value;} }
        public Veiculo Veiculo { get { return this.veiculo; } set { veiculo = value; } }
        public Queue<Visitante> Visitantes { get { return this.visitantes; } set { this.visitantes = value; } }

        #endregion

        #region construtores

        public Viagem() {
        }

        public Viagem(Veiculo veiculo, DateTime horaViagem, Queue<Visitante> filaVis) {
            this.visitantes = new Queue<Visitante>();
            //consumindo a fila
            if (veiculo.Lotacao <= filaVis.Count())
            {
                for (int x = 1; x <= veiculo.Lotacao && veiculo.Lotacao != 0; x++)
                {
                    this.visitantes.Enqueue(filaVis.Dequeue());
                }
            }
            else
            {
                for(int x=0; x < filaVis.Count();x++)
                {
                    this.visitantes.Enqueue(filaVis.Dequeue());
                }
            }

            this.veiculo = veiculo;
            this.horaViagem = horaViagem;
        }
        public Viagem(Veiculo vei):this(vei, DateTime.Now, null) { }

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
        public double valorViagem()
        {
            return visitantes.Count() * 5;
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
