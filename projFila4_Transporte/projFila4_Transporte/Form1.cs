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
        // Criação dos objetos estáticos que serão manipulados na classe
        // Classes Controler
        static Veiculos veiculos = new Veiculos();
        static Viagens viagens = new Viagens();
        static Visitantes visitantes = new Visitantes();
        // Classes Model
        static Veiculo veiculo = null;
        static Viagem viagem = null;
        static Visitante visitante = null;
        static Visitantes tempVisitantes = null;
        // Propriedade para controlar viagens
        


        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnCadastroVeiculo_Click(object sender, EventArgs e)
        {
            // Criação do novo veículo e adicionando a lista de veículos
            veiculo = new Veiculo(txtPlacaVeiculo.Text, txtNomeMotorista.Text, int.Parse(txtLotacao.Text));
            veiculos.adicionarVeiculo(veiculo);
            // Limpando texts
            limparTexts();
            // Adicionando os veículos da FilaDeVeiculos na listbox
            lstVeiculosCadastrados.Items.Clear();
            foreach (Veiculo v in veiculos.FilaDeVeiculos) {
                lstVeiculosCadastrados.Items.Add(v.dadosDoVeiculo());
            }
            // Atualizando a combobox
            cbbVeiculosCadastrados.Items.Add(veiculo.Placa);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            
            // Criação do novo visitante e adicionando a lista de visitantes
            visitante = new Visitante(int.Parse(txtNumInscricao.Text));
            visitantes.adicionarVisitante(visitante);
            // Limpando texts
            limparTexts();
            // Adicionar os visitantes da FilaDeVisitantes na list box
            lstFilaEmbarque.Items.Clear();
            foreach (Visitante v in visitantes.FilaDeVisitantes) {
                lstFilaEmbarque.Items.Add(v.dadosDoVisitante());
            }
            // Verificar se existe veículos disponíveis e completou o numero de passageiros // falta autorizar embarque por hora
            if (veiculos.temVeiculo() && veiculos.FilaDeVeiculos.Peek().Lotacao==visitantes.FilaDeVisitantes.Count()) {

                int lotacao = veiculos.FilaDeVeiculos.Peek().Lotacao;
                tempVisitantes = new Visitantes();

                for (int i = lotacao; i <= 0; i--) {
                    tempVisitantes.adicionarVisitante(visitantes.FilaDeVisitantes.Dequeue());
                }
                viagem = new Viagem(veiculos.FilaDeVeiculos.Dequeue(), DateTime.Now, tempVisitantes.FilaDeVisitantes);
                viagens.adicionarViagens(viagem);
                lstFilaEmbarque.Items.Clear();
                // Limpando a lista de visitantes para reuso
                visitantes = new Visitantes();
            }

            

        }

        private void limparTexts() {
            txtLotacao.Clear();
            txtNomeMotorista.Clear();
            txtNumInscricao.Clear();
            txtPlacaVeiculo.Clear();
        }

        private void cbbVeiculosCadastrados_SelectedValueChanged(object sender, EventArgs e)
        {
            string placaVeiculo = cbbVeiculosCadastrados.SelectedItem.ToString();

            Veiculo tempVeiculo = new Veiculo(placaVeiculo, "", 0);

            // Adicionar os visitantes da FilaDeVisitantes na list box
            lstViagensPorVeiculo.Items.Clear();

            foreach (Viagem v in viagens.ListaViagens) {
                if (v.Veiculo.Placa==tempVeiculo.Placa){
                    lstViagensPorVeiculo.Items.Add(v.Dados());
                }
            }

            


        }
    }
}
