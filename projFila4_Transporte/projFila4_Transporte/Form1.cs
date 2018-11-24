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
        Veiculo veiculo;
        Veiculos veiculos;
       
        Visitantes visitantes;
        Viagens viagens;
        TimeSpan tempoRestante;
        TimeSpan proximaViagem;

        #region construtor do form e eventos associados


        public Form1()
        {
            veiculos = new Veiculos();
            visitantes = new Visitantes();
            tempoRestante = new TimeSpan(0, 30, 0);
            proximaViagem = new TimeSpan();


            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timerHoraAtual.Start();
            // timerTempoRestante.Start();
        }


        #endregion

     
        #region timer

        private void timerHoraAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        private void btnCadastroVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo = new Veiculo(txtPlacaVeiculo.Text, txtNomeMotorista.Text, int.Parse(txtLotacao.Text));

                lstVeiculosCadastrados.Items.Clear();
                cbbVeiculosCadastrados.Items.Clear();

                if (!veiculos.adicionarVeiculo(veiculo))
                    MessageBox.Show("Placa já cadastrada!");
                else
                    limpaText();

                //atualização do lstBox
                foreach (Veiculo veiculo in veiculos.FilaDeVeiculos)
                {
                    lstVeiculosCadastrados.Items.Add(veiculo.dadosDoVeiculo());
                    cbbVeiculosCadastrados.Items.Add(veiculo.Placa);
                }
                //Posso viajar?
                viajar(sender);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
        }
        void limpaText()
        {
            txtLotacao.Text = txtNomeMotorista.Text = txtNumInscricao.Text = txtPlacaVeiculo.Text = "";
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                lstFilaEmbarque.Items.Clear();
                Visitante visitante = new Visitante(int.Parse(txtNumInscricao.Text));
               
                if (!visitantes.adicionarVisitante(visitante))
                    MessageBox.Show("Visitante já na fila");
                else
                    limpaText();

                //atualização do lstBox
                foreach (Visitante vis in visitantes.FilaDeVisitantes)
                {
                    lstFilaEmbarque.Items.Add(vis.dadosDoVisitante());
                }
                //chamando método viajar e enviando o sender como parametro do método
                viajar(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void viajar(object sender)
        {
            try
            {
                Button b = ((Button)sender);
                while (visitantes.FilaDeVisitantes.Count() != 0 && veiculos.FilaDeVeiculos.Count() != 0)
                {
                    if (veiculos.FilaDeVeiculos.Peek().Lotacao <= visitantes.FilaDeVisitantes.Count())
                    {
                        veiculo = veiculos.FilaDeVeiculos.Dequeue();
                        veiculos.FilaDeVeiculos.Enqueue(veiculo);

                        Viagem viagem = new Viagem(veiculo, DateTime.Now, visitantes.FilaDeVisitantes);
                        viagens.adicionarViagens(viagem);
                        MessageBox.Show("Viagem iniciada via lotação");
                                           }
                    else break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    TimeSpan timer = (TimeSpan)sender;
                    if (visitantes.FilaDeVisitantes.Count() != 0 && veiculos.FilaDeVeiculos.Count() != 0)
                    {
                        
                        veiculo = veiculos.FilaDeVeiculos.Dequeue();
                        Viagem viagem = new Viagem(veiculo, DateTime.Now, visitantes.FilaDeVisitantes);
                        viagens.adicionarViagens(viagem);
                        MessageBox.Show("Viagem iniciada pelo horário");
                    }
                }
                catch
                {
                    MessageBox.Show("Ninguém viajou");
                }
            }
            //atualizando a lista de embarque
            lstFilaEmbarque.Items.Clear();
            foreach (Visitante vis in visitantes.FilaDeVisitantes)
                lstFilaEmbarque.Items.Add(vis.dadosDoVisitante());
        }

        private void cbbVeiculosCadastrados_SelectedValueChanged(object sender, EventArgs e)
        {
            lstViagensPorVeiculo.Items.Clear();
            String placa = cbbVeiculosCadastrados.SelectedText;
            foreach (Viagem viagem in viagens.ListaViagens)
            {
                if (viagem.Veiculo.Placa == placa)
                    lstViagensPorVeiculo.Items.Add(viagem.dadosDaViagem());
            }
        }
    }
}