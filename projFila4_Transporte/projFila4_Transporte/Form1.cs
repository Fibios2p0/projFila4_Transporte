using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projFila4_Transporte
{
    public partial class Form1 : Form
    {
        Veiculo veiculo;
        Veiculos veiculos;       
        Visitantes visitantes;
        Viagens viagens;
        //TimeSpan tempoRestante;

        #region construtor do form e eventos associados


        public Form1()
        {
            viagens = new Viagens();
            veiculos = new Veiculos();
            visitantes = new Visitantes();
            //tempoRestante = new TimeSpan(0, 30, 0);


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
                //formatando a placa
                string placa = txtPlacaVeiculo.Text;
                if (placa.Count() == 7)
                {
                    placa = placa.Substring(0, 3).ToUpper() + "-" + placa.Substring(3, 4);
                }
                else placa = placa.Substring(0, 3).ToUpper() + placa.Substring(3, 4);
                //inicializando um veículo
                if (validarPlaca(placa) && int.Parse(txtLotacao.Text) > 0)
                {
                    veiculo = new Veiculo(placa, txtNomeMotorista.Text, int.Parse(txtLotacao.Text));

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
                    //Posso viajar? eviando o sender (do botão) para o método
                    viajar(sender);
                }
                else MessageBox.Show("Favor verificar placa e lotação");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                //limpando list
                lstFilaEmbarque.Items.Clear();
                //inicializando visitante
                Visitante visitante = new Visitante(int.Parse(txtNumInscricao.Text));
               
                if (!visitantes.adicionarVisitante(visitante))
                    MessageBox.Show("Visitante já na fila");
                else
                {
                    //iniciando o timer.
                    timerTempoRestante.Stop();
                    timerTempoRestante.Start();
                    limpaText();
                }
                //atualização do lstBox
                foreach (Visitante vis in visitantes.FilaDeVisitantes)
                {
                    lstFilaEmbarque.Items.Add(vis.dadosDoVisitante());
                }
                //Posso viajar? eviando o sender (do botão) para o método
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
                //testando se o metodo foi chamado por um botão caso contrario foi o timer
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
            catch
            {
                try
                {
                    if (visitantes.FilaDeVisitantes.Count() > 0 && veiculos.FilaDeVeiculos.Count() > 0)
                    {

                        veiculo = veiculos.FilaDeVeiculos.Dequeue();
                        veiculos.FilaDeVeiculos.Enqueue(veiculo);

                        Viagem viagem = new Viagem(veiculo, DateTime.Now, visitantes.FilaDeVisitantes);
                        viagens.adicionarViagens(viagem);
                        MessageBox.Show("Viagem iniciada pelo tempo");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ninguém viajou");
                }
                //TIMER negando a afirmação, caso haja visitantes o timer continua
                if (!(visitantes.FilaDeVisitantes.Count() > 0))
                {
                    timerTempoRestante.Stop();
                }
            }
            //atualizando a lista de embarque
            lstFilaEmbarque.Items.Clear();
            foreach (Visitante vis in visitantes.FilaDeVisitantes)
                lstFilaEmbarque.Items.Add(vis.dadosDoVisitante());
        }
        private void cbbVeiculosCadastrados_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Evento combo");
            
            limpaText();
            string placa = cbbVeiculosCadastrados.SelectedItem.ToString();
            double valorTotal =0;
            //metodo que busca todas as viagens e adiciona somente a placa correspondente
            foreach (Viagem viagem in viagens.ListaViagens)
            {
                if (viagem.Veiculo.Placa == placa)
                {
                    lstViagensPorVeiculo.Items.Add(viagem.dadosDaViagem());
                    valorTotal += viagem.valorViagem();
                }
            }
            lstViagensPorVeiculo.Items.Add("");
            lstViagensPorVeiculo.Items.Add("Total do veículo: R$ " +valorTotal.ToString("C"));
        }
        void limpaText()
        {
            txtLotacao.Text = txtNomeMotorista.Text = txtNumInscricao.Text = txtPlacaVeiculo.Text = "";
            lstViagensPorVeiculo.Items.Clear();
        }
        public bool validarPlaca(string value)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value))
                return true; //se a placa for válida, retorna TRUE
            return false; //se a placa for inválida, retorna FALSE             
        }

        private void timerTempoRestante_Tick(object sender, EventArgs e)
        {
            if(veiculos.FilaDeVeiculos.Count()>0 && visitantes.FilaDeVisitantes.Count()>0)
                viajar(sender);
        }
    }
}