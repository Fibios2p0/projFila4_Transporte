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
        List<Visitante> passageiros = new List<Visitante>();
        #endregion

        #region propriedades
        #endregion

        #region construtores
        #endregion

        #region metodos
        public string Dados()
        {
            return $"Veiculo placa {veiculo.Placa} Hora: {horaViagem} Tranferiu os vistantes:\n{passageiros}  ";
        }
        #endregion
    }
}
