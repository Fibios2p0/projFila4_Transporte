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

        #region construtor do form e eventos associados

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHoraAtual.Start();
            timerTempoRestante.Start();
        }

        #endregion

        #region atributos estáticos
            static Veiculos veiculos = new Veiculos();
            static Viagens viagens = new Viagens();
            static Visitantes visitantes = new Visitantes();
            static Veiculo veiculo = null;
            static TimeSpan tempoRestante = new TimeSpan(0, 30, 0);
            static TimeSpan proximaViagem = new TimeSpan();
        #endregion

        #region timer


        private void timerHoraAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = this.queHorasSao().ToLongTimeString();
        }

        private void timerTempoRestante_Tick(object sender, EventArgs e)
        {
            try
            {
                if (visitantes.FilaDeVisitantes.Count() > 0 && veiculos.FilaDeVeiculos.Peek().Lotacao > 0)
                {
                                     
                    // segurando uma cópia do veículo pra reinserir na fila de veiculos
                    Veiculo tempVeiculo = veiculo;
                    // calculando o saldo do motorista

                    // Prepara os dados, embarca os visitantes no veículo e salva a viagem na lista de viagens
                    veiculo.Saldo += (visitantes.FilaDeVisitantes.Count() * 5);
                    viagens.adicionarViagens(new Viagem(veiculos.FilaDeVeiculos.Dequeue(), DateTime.Now, visitantes.FilaDeVisitantes));

                    // Adicionando o tempo estabelecido para próxima viagem
                    TimeSpan ultimaViagem = new TimeSpan(viagens.ListaViagens.Peek().HoraViagem.Ticks);
                    proximaViagem = ultimaViagem.Add(ultimaViagem);

                    // Alimentando o label timer
                    lblTimer.Text = proximaViagem.Minutes.ToString() + ":" + proximaViagem.Seconds.ToString();

                    // Mostra mensagem informando o número de passageiros embarcando no veículo da vez
                    MessageBox.Show(viagens.ListaViagens.Peek().Visitantes.Count().ToString() + " passageiros embarcando.");
                    
                    
                    // limpando os objetos do form e a lista de visitantes static do form
                    lstFilaEmbarque.Items.Clear();
                    limparTexts();
                    visitantes = new Visitantes();

                    // Devolvendo o veiculo que fez a viagem a fila de veiculos
                    veiculos.adicionarVeiculo(tempVeiculo);
                }
            }
            catch
            {

            }
        }



        #endregion

        #region eventos

            #region eventos dos botões

            private void btnCadastroVeiculo_Click(object sender, EventArgs e)
                {
                    // Criação do novo veículo e adicionando a lista de veículos
                    veiculo = new Veiculo(txtPlacaVeiculo.Text, txtNomeMotorista.Text, int.Parse(txtLotacao.Text));
                    veiculos.adicionarVeiculo(veiculo);
                    
                    // Limpando texts de todos os panels
                    limparTexts();
                    lstVeiculosCadastrados.Items.Clear();
                    // Atualizando a combobox do panel viagens
                    cbbVeiculosCadastrados.Items.Add(veiculo.Placa);

                    // Adicionando os veículos da FilaDeVeiculos na listbox veiculos cadastrados
                    foreach (Veiculo v in veiculos.FilaDeVeiculos) {
                        lstVeiculosCadastrados.Items.Add(v.dadosDoVeiculo());
                    }
                    
                    try
                    {
                        if (visitantes.FilaDeVisitantes.Count() > 0)
                        {

                            // segurando uma cópia do veículo pra reinserir na fila de veiculos
                            Veiculo tempVeiculo = veiculo;

                            // Prepara os dados, embarca os visitantes no veículo e salva a viagem na lista de viagens
                            Visitantes tempVisitantes = new Visitantes();                            
                            for (int i = veiculo.Lotacao; i == 0; i--){
                                tempVisitantes.FilaDeVisitantes.Enqueue(visitantes.FilaDeVisitantes.Dequeue());
                            }                            
                            
                            // calculando o saldo do motorista
                            veiculo.Saldo += (tempVisitantes.FilaDeVisitantes.Count() * 5);

                            // adicionando a viagem na lista de viagens
                            viagens.adicionarViagens(new Viagem(veiculos.FilaDeVeiculos.Dequeue(), DateTime.Now, tempVisitantes.FilaDeVisitantes));

                            // Mostra mensagem informando o número de passageiros embarcando no veículo da vez
                            MessageBox.Show(tempVisitantes.FilaDeVisitantes.Count.ToString() + " passageiros embarcando.");

                            // limpando os objetos do form e a lista de visitantes static do form
                            lstFilaEmbarque.Items.Clear();
                            limparTexts();
                            tempVisitantes = new Visitantes();

                            // Devolvendo o veiculo que fez a viagem a fila de veiculos
                            veiculos.adicionarVeiculo(tempVeiculo);
                        }
                    }
                    catch
                    {

                    }


                }

            // Evento que controla o evento "click" no botão check-in no panel 
            private void btnCheckin_Click(object sender, EventArgs e)
            {
                // adicionando o visitante a lista de visitantes corrente
                visitantes.adicionarVisitante(new Visitante(int.Parse(txtNumInscricao.Text)));

                // Adicionar os visitantes a fila de embarque
                limparTexts();
                lstFilaEmbarque.Items.Clear();
                foreach (Visitante v in visitantes.FilaDeVisitantes)
                {
                    lstFilaEmbarque.Items.Add(v.dadosDoVisitante());
                }

                // verificar a cada inserção se o número de passageiros já alcançou a lotação
                //    e posteriomente se é(ou) hora do embarque, qual dois ocorrerem primeiro
                //    e então embarcá-los. Resetando a lista de visitantes aguardando embarque

                try {
                    // Já tem carro disponível pra fazer as viagens? Se sim, o número de visitantes já lota 1 carro?
                    if (visitantes.FilaDeVisitantes.Count() == veiculos.FilaDeVeiculos.Peek().Lotacao && veiculos.FilaDeVeiculos.Count() > 0)
                    {

                        // segurando uma cópia do veículo pra reinserir na fila de veiculos
                        Veiculo tempVeiculo = veiculo;
                        // adicionando o saldo ao veículo
                        veiculo.Saldo += (visitantes.FilaDeVisitantes.Count() * 5);             
                        viagens.adicionarViagens(new Viagem(veiculos.FilaDeVeiculos.Dequeue(), DateTime.Now, visitantes.FilaDeVisitantes));


                        // Disparando o timer de tempo restante
                        timerTempoRestante.Start();

                        // preenchendo a variavel static proximaViagem com a hora da próxima viagem
                        TimeSpan tsUltimaViagem = new TimeSpan(viagens.ListaViagens.Peek().HoraViagem.Ticks);
                        proximaViagem = tsUltimaViagem.Add(new TimeSpan(0, 30, 0));
                        MessageBox.Show(viagens.ListaViagens.Peek().Visitantes.Count() + " passageiros embarcando.");

                        // limpando os objetos do form e a lista de visitantes static do form
                        lstFilaEmbarque.Items.Clear();  limparTexts();
                        visitantes = new Visitantes();

                        // Devolvendo o veiculo que fez a viagem a fila de veiculos
                        veiculos.adicionarVeiculo(tempVeiculo);


                    }
                }
                catch
                {

                }

            }

            // Evento que controla o evento: "mudança de valor selecionado" na combo box Veiculos Cadastrados no painel viagens
            private void cbbVeiculosCadastrados_SelectedValueChanged(object sender, EventArgs e)
            {
                // criando um veiculo vazio apenas pra comparar com veiculos contidos na lista de viagens
                Veiculo tempVeiculo = new Veiculo(cbbVeiculosCadastrados.SelectedItem.ToString(), "", 0);
                // limpando o list box
                lstViagensPorVeiculo.Items.Clear();

                // Adicionar os visitantes da FilaDeVisitantes na list box
                foreach (Viagem v in viagens.ListaViagens)
                {
                    if (v.Veiculo.Placa == tempVeiculo.Placa)
                    {
                        lstViagensPorVeiculo.Items.Add(v.dadosDaViagem());
                    }
                }

                lstViagensPorVeiculo.Items.Add("");
                lstViagensPorVeiculo.Items.Add("");
                lstViagensPorVeiculo.Items.Add("A receber: R$ " + veiculo.Saldo.ToString());

            }

            #endregion


            // Controle do tempo restante

            private void btnTempoRestante_Click(object sender, EventArgs e)
            {
                string temporizador = lblHoraAtual.Text;
                string[] arrayTemporizador = temporizador.Split(':');
                tempoRestante = new TimeSpan(int.Parse(arrayTemporizador[0]), int.Parse(arrayTemporizador[1]), int.Parse(arrayTemporizador[2]));
                
                // Reprogramando o temporizador tempo restante
                timerTempoRestante.Stop();
                timerTempoRestante.Interval = 5000;//tempoRestante.TotalMilliseconds;
                timerTempoRestante.Start();

                
            }

            private void mtbAjustarHora_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
            {
                if (e.ReturnValue != null)
                {
                    DateTime valor = (DateTime)e.ReturnValue;
                }
                else
                    MessageBox.Show("Informe uma hora válida!");
            }

        #endregion

        #region métodos funcionais

        private void limparTexts()
        {
            txtLotacao.Clear();
            txtNomeMotorista.Clear();
            txtNumInscricao.Clear();
            txtPlacaVeiculo.Clear();
        }

        private DateTime queHorasSao()
        {
            return DateTime.Now;
        }



        #endregion

    }
}
