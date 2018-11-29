namespace projFila4_Transporte
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbCadastroVeiculos = new System.Windows.Forms.TabPage();
            this.lblVeiculosCadastrados = new System.Windows.Forms.Label();
            this.lstVeiculosCadastrados = new System.Windows.Forms.ListBox();
            this.btnCadastroVeiculo = new System.Windows.Forms.Button();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.tbCheckin = new System.Windows.Forms.TabPage();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumInscricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblFilaEmbarque = new System.Windows.Forms.Label();
            this.lstFilaEmbarque = new System.Windows.Forms.ListBox();
            this.tbViagens = new System.Windows.Forms.TabPage();
            this.lblViagensPorVeiculo = new System.Windows.Forms.Label();
            this.lstViagensPorVeiculo = new System.Windows.Forms.ListBox();
            this.cbbVeiculosCadastrados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.timerTempoRestante = new System.Windows.Forms.Timer(this.components);
            this.tbControl.SuspendLayout();
            this.tbCadastroVeiculos.SuspendLayout();
            this.tbCheckin.SuspendLayout();
            this.tbViagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbCadastroVeiculos);
            this.tbControl.Controls.Add(this.tbCheckin);
            this.tbControl.Controls.Add(this.tbViagens);
            this.tbControl.Location = new System.Drawing.Point(13, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(352, 596);
            this.tbControl.TabIndex = 0;
            // 
            // tbCadastroVeiculos
            // 
            this.tbCadastroVeiculos.Controls.Add(this.lblVeiculosCadastrados);
            this.tbCadastroVeiculos.Controls.Add(this.lstVeiculosCadastrados);
            this.tbCadastroVeiculos.Controls.Add(this.btnCadastroVeiculo);
            this.tbCadastroVeiculos.Controls.Add(this.txtLotacao);
            this.tbCadastroVeiculos.Controls.Add(this.lblLotacao);
            this.tbCadastroVeiculos.Controls.Add(this.txtNomeMotorista);
            this.tbCadastroVeiculos.Controls.Add(this.lblNomeMotorista);
            this.tbCadastroVeiculos.Controls.Add(this.txtPlacaVeiculo);
            this.tbCadastroVeiculos.Controls.Add(this.lblPlacaVeiculo);
            this.tbCadastroVeiculos.Location = new System.Drawing.Point(4, 22);
            this.tbCadastroVeiculos.Name = "tbCadastroVeiculos";
            this.tbCadastroVeiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroVeiculos.Size = new System.Drawing.Size(344, 570);
            this.tbCadastroVeiculos.TabIndex = 0;
            this.tbCadastroVeiculos.Text = "Cadastro de Veículos";
            this.tbCadastroVeiculos.UseVisualStyleBackColor = true;
            // 
            // lblVeiculosCadastrados
            // 
            this.lblVeiculosCadastrados.AutoSize = true;
            this.lblVeiculosCadastrados.Location = new System.Drawing.Point(18, 139);
            this.lblVeiculosCadastrados.Name = "lblVeiculosCadastrados";
            this.lblVeiculosCadastrados.Size = new System.Drawing.Size(114, 13);
            this.lblVeiculosCadastrados.TabIndex = 8;
            this.lblVeiculosCadastrados.Text = "Veículos Cadastrados:";
            // 
            // lstVeiculosCadastrados
            // 
            this.lstVeiculosCadastrados.FormattingEnabled = true;
            this.lstVeiculosCadastrados.Location = new System.Drawing.Point(21, 155);
            this.lstVeiculosCadastrados.Name = "lstVeiculosCadastrados";
            this.lstVeiculosCadastrados.Size = new System.Drawing.Size(302, 394);
            this.lstVeiculosCadastrados.TabIndex = 7;
            // 
            // btnCadastroVeiculo
            // 
            this.btnCadastroVeiculo.Location = new System.Drawing.Point(21, 106);
            this.btnCadastroVeiculo.Name = "btnCadastroVeiculo";
            this.btnCadastroVeiculo.Size = new System.Drawing.Size(302, 23);
            this.btnCadastroVeiculo.TabIndex = 6;
            this.btnCadastroVeiculo.Text = "Cadastrar";
            this.btnCadastroVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastroVeiculo.Click += new System.EventHandler(this.btnCadastroVeiculo_Click);
            // 
            // txtLotacao
            // 
            this.txtLotacao.Location = new System.Drawing.Point(119, 68);
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.Size = new System.Drawing.Size(204, 20);
            this.txtLotacao.TabIndex = 5;
            // 
            // lblLotacao
            // 
            this.lblLotacao.AutoSize = true;
            this.lblLotacao.Location = new System.Drawing.Point(18, 71);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.Size = new System.Drawing.Size(89, 13);
            this.lblLotacao.TabIndex = 4;
            this.lblLotacao.Text = "Lotação Veículo:";
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Location = new System.Drawing.Point(119, 42);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(204, 20);
            this.txtNomeMotorista.TabIndex = 3;
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.Location = new System.Drawing.Point(18, 45);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(84, 13);
            this.lblNomeMotorista.TabIndex = 2;
            this.lblNomeMotorista.Text = "Nome Motorista:";
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(119, 16);
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(204, 20);
            this.txtPlacaVeiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(18, 19);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(80, 13);
            this.lblPlacaVeiculo.TabIndex = 0;
            this.lblPlacaVeiculo.Text = "Placa Veículo: ";
            // 
            // tbCheckin
            // 
            this.tbCheckin.Controls.Add(this.btnCheckin);
            this.tbCheckin.Controls.Add(this.label3);
            this.tbCheckin.Controls.Add(this.txtNumInscricao);
            this.tbCheckin.Controls.Add(this.label4);
            this.tbCheckin.Controls.Add(this.lblHoraAtual);
            this.tbCheckin.Controls.Add(this.lblFilaEmbarque);
            this.tbCheckin.Controls.Add(this.lstFilaEmbarque);
            this.tbCheckin.Location = new System.Drawing.Point(4, 22);
            this.tbCheckin.Name = "tbCheckin";
            this.tbCheckin.Padding = new System.Windows.Forms.Padding(3);
            this.tbCheckin.Size = new System.Drawing.Size(344, 570);
            this.tbCheckin.TabIndex = 1;
            this.tbCheckin.Text = "Check-In Visitantes";
            this.tbCheckin.UseVisualStyleBackColor = true;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(23, 102);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(302, 23);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Fazer Check-In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº Inscrição no evento:";
            // 
            // txtNumInscricao
            // 
            this.txtNumInscricao.Location = new System.Drawing.Point(145, 76);
            this.txtNumInscricao.Name = "txtNumInscricao";
            this.txtNumInscricao.Size = new System.Drawing.Size(180, 20);
            this.txtNumInscricao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hora atual:";
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.Location = new System.Drawing.Point(17, 35);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(0, 24);
            this.lblHoraAtual.TabIndex = 21;
            // 
            // lblFilaEmbarque
            // 
            this.lblFilaEmbarque.AutoSize = true;
            this.lblFilaEmbarque.Location = new System.Drawing.Point(20, 139);
            this.lblFilaEmbarque.Name = "lblFilaEmbarque";
            this.lblFilaEmbarque.Size = new System.Drawing.Size(92, 13);
            this.lblFilaEmbarque.TabIndex = 15;
            this.lblFilaEmbarque.Text = "Fila de Embarque:";
            // 
            // lstFilaEmbarque
            // 
            this.lstFilaEmbarque.FormattingEnabled = true;
            this.lstFilaEmbarque.Location = new System.Drawing.Point(23, 155);
            this.lstFilaEmbarque.Name = "lstFilaEmbarque";
            this.lstFilaEmbarque.Size = new System.Drawing.Size(302, 394);
            this.lstFilaEmbarque.TabIndex = 14;
            // 
            // tbViagens
            // 
            this.tbViagens.Controls.Add(this.lblViagensPorVeiculo);
            this.tbViagens.Controls.Add(this.lstViagensPorVeiculo);
            this.tbViagens.Controls.Add(this.cbbVeiculosCadastrados);
            this.tbViagens.Controls.Add(this.label1);
            this.tbViagens.Location = new System.Drawing.Point(4, 22);
            this.tbViagens.Name = "tbViagens";
            this.tbViagens.Size = new System.Drawing.Size(344, 570);
            this.tbViagens.TabIndex = 2;
            this.tbViagens.Text = "Viagens";
            this.tbViagens.UseVisualStyleBackColor = true;
            // 
            // lblViagensPorVeiculo
            // 
            this.lblViagensPorVeiculo.AutoSize = true;
            this.lblViagensPorVeiculo.Location = new System.Drawing.Point(19, 62);
            this.lblViagensPorVeiculo.Name = "lblViagensPorVeiculo";
            this.lblViagensPorVeiculo.Size = new System.Drawing.Size(90, 13);
            this.lblViagensPorVeiculo.TabIndex = 10;
            this.lblViagensPorVeiculo.Text = "Viagens/Veículo:";
            // 
            // lstViagensPorVeiculo
            // 
            this.lstViagensPorVeiculo.FormattingEnabled = true;
            this.lstViagensPorVeiculo.Location = new System.Drawing.Point(22, 78);
            this.lstViagensPorVeiculo.Name = "lstViagensPorVeiculo";
            this.lstViagensPorVeiculo.Size = new System.Drawing.Size(302, 472);
            this.lstViagensPorVeiculo.TabIndex = 9;
            // 
            // cbbVeiculosCadastrados
            // 
            this.cbbVeiculosCadastrados.FormattingEnabled = true;
            this.cbbVeiculosCadastrados.Location = new System.Drawing.Point(119, 13);
            this.cbbVeiculosCadastrados.Name = "cbbVeiculosCadastrados";
            this.cbbVeiculosCadastrados.Size = new System.Drawing.Size(205, 21);
            this.cbbVeiculosCadastrados.TabIndex = 1;
            this.cbbVeiculosCadastrados.SelectedValueChanged += new System.EventHandler(this.cbbVeiculosCadastrados_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo/Placa:";
            // 
            // timerHoraAtual
            // 
            this.timerHoraAtual.Interval = 1000;
            this.timerHoraAtual.Tick += new System.EventHandler(this.timerHoraAtual_Tick);
            // 
            // timerTempoRestante
            // 
            this.timerTempoRestante.Interval = 15000;
            this.timerTempoRestante.Tick += new System.EventHandler(this.timerTempoRestante_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 620);
            this.Controls.Add(this.tbControl);
            this.Name = "Form1";
            this.Text = "Controle de Viagens - Centro de Exposições X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbControl.ResumeLayout(false);
            this.tbCadastroVeiculos.ResumeLayout(false);
            this.tbCadastroVeiculos.PerformLayout();
            this.tbCheckin.ResumeLayout(false);
            this.tbCheckin.PerformLayout();
            this.tbViagens.ResumeLayout(false);
            this.tbViagens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbCadastroVeiculos;
        private System.Windows.Forms.TabPage tbCheckin;
        private System.Windows.Forms.Button btnCadastroVeiculo;
        private System.Windows.Forms.TextBox txtLotacao;
        private System.Windows.Forms.Label lblLotacao;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.TextBox txtPlacaVeiculo;
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.Label lblVeiculosCadastrados;
        private System.Windows.Forms.ListBox lstVeiculosCadastrados;
        private System.Windows.Forms.Label lblFilaEmbarque;
        private System.Windows.Forms.ListBox lstFilaEmbarque;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.TextBox txtNumInscricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbViagens;
        private System.Windows.Forms.Label lblViagensPorVeiculo;
        private System.Windows.Forms.ListBox lstViagensPorVeiculo;
        private System.Windows.Forms.ComboBox cbbVeiculosCadastrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Timer timerHoraAtual;
        private System.Windows.Forms.Timer timerTempoRestante;
    }
}

