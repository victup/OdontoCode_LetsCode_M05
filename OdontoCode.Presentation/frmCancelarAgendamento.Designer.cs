namespace OdontoCode.Presentation
{
    partial class frmCancelarAgendamento
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
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.btnEncontrarPaciente = new System.Windows.Forms.Button();
            this.lblDescricaoAgendamento = new System.Windows.Forms.Label();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txbCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblCancelarAgendamento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lstAgendamento = new System.Windows.Forms.ListBox();
            this.lblAgendamentoEncontrado = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.txtIdAgendamento = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(649, 565);
            this.btnCancelarAgendamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(219, 44);
            this.btnCancelarAgendamento.TabIndex = 63;
            this.btnCancelarAgendamento.Text = "Cancelar Agendamento";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = false;
            this.btnCancelarAgendamento.Visible = false;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(497, 153);
            this.btnEncontrarPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(86, 31);
            this.btnEncontrarPaciente.TabIndex = 62;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            this.btnEncontrarPaciente.Click += new System.EventHandler(this.btnEncontrarPaciente_Click);
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Enabled = false;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(73, 331);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(180, 20);
            this.lblDescricaoAgendamento.TabIndex = 60;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Enabled = false;
            this.lblDataAgendamento.Location = new System.Drawing.Point(73, 265);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(263, 20);
            this.lblDataAgendamento.TabIndex = 56;
            this.lblDataAgendamento.Text = "Data e Hora (yyyy-mm-ddThh:mm:ss) :";
            this.lblDataAgendamento.Visible = false;
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(73, 201);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(116, 20);
            this.lblDentista.TabIndex = 54;
            this.lblDentista.Text = "Nome Dentista :";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(352, 129);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(40, 20);
            this.lblCpfPaciente.TabIndex = 53;
            this.lblCpfPaciente.Text = "CPF :";
            // 
            // txbCpfPaciente
            // 
            this.txbCpfPaciente.Location = new System.Drawing.Point(352, 153);
            this.txbCpfPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCpfPaciente.Name = "txbCpfPaciente";
            this.txbCpfPaciente.Size = new System.Drawing.Size(130, 27);
            this.txbCpfPaciente.TabIndex = 52;
            // 
            // lblCancelarAgendamento
            // 
            this.lblCancelarAgendamento.AutoSize = true;
            this.lblCancelarAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCancelarAgendamento.Location = new System.Drawing.Point(149, 37);
            this.lblCancelarAgendamento.Name = "lblCancelarAgendamento";
            this.lblCancelarAgendamento.Size = new System.Drawing.Size(371, 46);
            this.lblCancelarAgendamento.TabIndex = 51;
            this.lblCancelarAgendamento.Text = "Cancelar Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(73, 127);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(116, 20);
            this.lblNomePaciente.TabIndex = 50;
            this.lblNomePaciente.Text = "Nome Paciente :";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(73, 151);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(263, 27);
            this.txtNomePaciente.TabIndex = 49;
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(73, 225);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(263, 27);
            this.txtNomeDentista.TabIndex = 64;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(73, 289);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(263, 27);
            this.txtData.TabIndex = 65;
            this.txtData.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 355);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 27);
            this.txtDescricao.TabIndex = 66;
            this.txtDescricao.Visible = false;
            // 
            // lstAgendamento
            // 
            this.lstAgendamento.FormattingEnabled = true;
            this.lstAgendamento.ItemHeight = 20;
            this.lstAgendamento.Location = new System.Drawing.Point(73, 433);
            this.lstAgendamento.Name = "lstAgendamento";
            this.lstAgendamento.Size = new System.Drawing.Size(795, 104);
            this.lstAgendamento.TabIndex = 67;
            this.lstAgendamento.Visible = false;
            // 
            // lblAgendamentoEncontrado
            // 
            this.lblAgendamentoEncontrado.AutoSize = true;
            this.lblAgendamentoEncontrado.Enabled = false;
            this.lblAgendamentoEncontrado.Location = new System.Drawing.Point(73, 410);
            this.lblAgendamentoEncontrado.Name = "lblAgendamentoEncontrado";
            this.lblAgendamentoEncontrado.Size = new System.Drawing.Size(195, 20);
            this.lblAgendamentoEncontrado.TabIndex = 83;
            this.lblAgendamentoEncontrado.Text = "Agendamento Encontrado : ";
            this.lblAgendamentoEncontrado.Visible = false;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(73, 577);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(123, 20);
            this.lbld.TabIndex = 87;
            this.lbld.Text = "ID Agendamento";
            this.lbld.Visible = false;
            // 
            // txtIdAgendamento
            // 
            this.txtIdAgendamento.Location = new System.Drawing.Point(73, 601);
            this.txtIdAgendamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdAgendamento.Name = "txtIdAgendamento";
            this.txtIdAgendamento.Size = new System.Drawing.Size(116, 27);
            this.txtIdAgendamento.TabIndex = 88;
            this.txtIdAgendamento.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(774, 659);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 89;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCancelarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtIdAgendamento);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblAgendamentoEncontrado);
            this.Controls.Add(this.lstAgendamento);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.btnCancelarAgendamento);
            this.Controls.Add(this.btnEncontrarPaciente);
            this.Controls.Add(this.lblDescricaoAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txbCpfPaciente);
            this.Controls.Add(this.lblCancelarAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCancelarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Agendamento";
            this.Load += new System.EventHandler(this.frmCancelarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelarAgendamento;
        private Button btnEncontrarPaciente;
        private Label lblDescricaoAgendamento;
        private Label lblDataAgendamento;
        private Label lblDentista;
        private Label lblCpfPaciente;
        private TextBox txbCpfPaciente;
        private Label lblCancelarAgendamento;
        private Label lblNomePaciente;
        private TextBox txtNomePaciente;
        private TextBox txtNomeDentista;
        private TextBox txtData;
        private TextBox txtDescricao;
        private ListBox lstAgendamento;
        private Label lblAgendamentoEncontrado;
        private Label lbld;
        private TextBox txtIdAgendamento;
        private Button btnLimpar;
    }
}