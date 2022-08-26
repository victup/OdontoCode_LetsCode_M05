namespace OdontoCode.Presentation
{
    partial class frmBuscarAgendamento
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
            this.btnEncontrarPaciente = new System.Windows.Forms.Button();
            this.lblDescricaoAgendamento = new System.Windows.Forms.Label();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblBuscarAgendamento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.listAgendamento = new System.Windows.Forms.ListBox();
            this.txtDataEHora = new System.Windows.Forms.TextBox();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblAgendamentoEncontrado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(395, 321);
            this.btnEncontrarPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(101, 55);
            this.btnEncontrarPaciente.TabIndex = 76;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            this.btnEncontrarPaciente.Click += new System.EventHandler(this.btnEncontrarPaciente_Click);
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(62, 324);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(180, 20);
            this.lblDescricaoAgendamento.TabIndex = 74;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(67, 249);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(263, 20);
            this.lblDataAgendamento.TabIndex = 70;
            this.lblDataAgendamento.Text = "Data e Hora (yyyy-mm-ddThh:mm:ss) :";
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(67, 179);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(138, 20);
            this.lblDentista.TabIndex = 68;
            this.lblDentista.Text = "Nome do Dentista :";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(366, 102);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(121, 20);
            this.lblCpfPaciente.TabIndex = 67;
            this.lblCpfPaciente.Text = "CPF do Paciente :";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Location = new System.Drawing.Point(366, 126);
            this.txtCpfPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(130, 27);
            this.txtCpfPaciente.TabIndex = 66;
            // 
            // lblBuscarAgendamento
            // 
            this.lblBuscarAgendamento.AutoSize = true;
            this.lblBuscarAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarAgendamento.Location = new System.Drawing.Point(147, 19);
            this.lblBuscarAgendamento.Name = "lblBuscarAgendamento";
            this.lblBuscarAgendamento.Size = new System.Drawing.Size(340, 46);
            this.lblBuscarAgendamento.TabIndex = 65;
            this.lblBuscarAgendamento.Text = "Buscar Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(67, 102);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(138, 20);
            this.lblNomePaciente.TabIndex = 64;
            this.lblNomePaciente.Text = "Nome  do Paciente:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(67, 126);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(263, 27);
            this.txtNomePaciente.TabIndex = 63;
            // 
            // listAgendamento
            // 
            this.listAgendamento.FormattingEnabled = true;
            this.listAgendamento.ItemHeight = 20;
            this.listAgendamento.Location = new System.Drawing.Point(62, 432);
            this.listAgendamento.Name = "listAgendamento";
            this.listAgendamento.Size = new System.Drawing.Size(927, 104);
            this.listAgendamento.TabIndex = 77;
            this.listAgendamento.Visible = false;
            // 
            // txtDataEHora
            // 
            this.txtDataEHora.Enabled = false;
            this.txtDataEHora.Location = new System.Drawing.Point(67, 273);
            this.txtDataEHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataEHora.Name = "txtDataEHora";
            this.txtDataEHora.Size = new System.Drawing.Size(263, 27);
            this.txtDataEHora.TabIndex = 78;
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(67, 203);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(263, 27);
            this.txtNomeDentista.TabIndex = 79;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(62, 349);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(268, 27);
            this.txtDescricao.TabIndex = 80;
            // 
            // lblAgendamentoEncontrado
            // 
            this.lblAgendamentoEncontrado.AutoSize = true;
            this.lblAgendamentoEncontrado.Enabled = false;
            this.lblAgendamentoEncontrado.Location = new System.Drawing.Point(62, 409);
            this.lblAgendamentoEncontrado.Name = "lblAgendamentoEncontrado";
            this.lblAgendamentoEncontrado.Size = new System.Drawing.Size(195, 20);
            this.lblAgendamentoEncontrado.TabIndex = 81;
            this.lblAgendamentoEncontrado.Text = "Agendamento Encontrado : ";
            this.lblAgendamentoEncontrado.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(375, 570);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 55);
            this.btnLimpar.TabIndex = 82;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // frmBuscarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 675);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblAgendamentoEncontrado);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.txtDataEHora);
            this.Controls.Add(this.listAgendamento);
            this.Controls.Add(this.btnEncontrarPaciente);
            this.Controls.Add(this.lblDescricaoAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.lblBuscarAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmBuscarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Agendamento";
            this.Load += new System.EventHandler(this.frmBuscarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEncontrarPaciente;
        private Label lblDescricaoAgendamento;
        private Label lblDataAgendamento;
        private Label lblDentista;
        private Label lblCpfPaciente;
        private TextBox txtCpfPaciente;
        private Label lblBuscarAgendamento;
        private Label lblNomePaciente;
        private TextBox txtNomePaciente;
        private ListBox listAgendamento;
        private TextBox txtDataEHora;
        private TextBox txtNomeDentista;
        private TextBox txtDescricao;
        private Label lblAgendamentoEncontrado;
        private Button btnLimpar;
    }
}