using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projFila4_Transporte
{
    public partial class Form1 : Form
    {

        static Veiculos veiculos = new Veiculos();
        static Veiculo veiculo = null;
        static Viagens viagens = new Viagens();
        Viagem viagem = new Viagem();
        static Visitantes visitantes = new Visitantes();
        


        public Form1()
        {
            InitializeComponent();
         
        }

        private void tbCadastroVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCadastroVeiculo_Click(object sender, EventArgs e)
        {
            // Criação do novo veículo e adicionando a lista de veículos
            Veiculo veiculo = new Veiculo(txtPlacaVeiculo.Text, txtNomeMotorista.Text, int.Parse(txtLotacao.Text));
            veiculos.adicionarVeiculo(veiculo);

            // Adicionando o veículo na listbox
            lstVeiculosCadastrados.Items.Add(veiculo.dadosDoVeiculo());

            // Atualizando a combobox
            cbbVeiculosCadastrados.Items.Add(veiculo.Placa);
            





        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            // Criação do novo visitante e adicionando a lista de visitantes
            Visitante visitante = new Visitante(int.Parse(txtNumInscricao.Text));
            visitantes.adicionarVisitante(visitante);

            // Adicionar o visitante na list box
            lstFilaEmbarque.Items.Add(visitante.dadosDoVisitante());

            try{
                int lotacao = veiculos.FilaVeicDisp.Peek().Lotacao;
                if(lotacao == visitantes.FilaEmbarque.Count) {
                    Queue<Visitante> tempVisitantes = new Queue<Visitante>();
                    for (; lotacao <= 0; lotacao--) {
                        tempVisitantes.Enqueue(visitantes.FilaEmbarque.Dequeue());
                    }

                    viagem = new Viagem(veiculos.FilaVeicDisp.Dequeue(), DateTime.UtcNow, tempVisitantes);
                    viagens.adicionarViagens(viagem);
                }
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
           
        }

        private void cbbVeiculosCadastrados_SelectedIndexChanged(object sender, EventArgs e) {

            lstViagensPorVeiculo.Items.Clear();


        }



        private void cbbVeiculosCadastrados_MouseClick(object sender, MouseEventArgs e){ }
        private void cbbVeiculosCadastrados_SelectedValueChanged(object sender, EventArgs e){  }
        private void cbbVeiculosCadastrados_SelectedValue(object sender, EventArgs e){


        }
    }
}
