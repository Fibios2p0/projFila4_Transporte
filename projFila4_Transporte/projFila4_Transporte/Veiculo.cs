using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace projFila4_Transporte
{
    class Veiculo
    {
        #region atributos
        private string placa, nomeMotorista;
        private int lotacao;
        #endregion
        
        #region propriedades
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value;}
        }

        #endregion

        #region construtores
        public Veiculo(string placa, string nomeMotorista, int lotacao)
        {
            Placa = placa;
            this.nomeMotorista = nomeMotorista;
            Lotacao = lotacao;
        }
        public Veiculo(string placa) : this(placa, "", 0) { }
        #endregion

        #region metodos

        public String dadosDoVeiculo() {
            String str = this.Placa + "  -  " + this.nomeMotorista + "  -  " + this.Lotacao;
            return str;
            
        }
        #endregion

        #region sobreescritas
        public override bool Equals(object obj)
        {
            Veiculo v = (Veiculo)obj;
            return this.placa.Equals(v.placa);
        }

        #endregion
    }
}
