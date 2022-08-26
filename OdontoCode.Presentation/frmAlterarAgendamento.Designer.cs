namespace OdontoCode.Presentation
{
    partial class frmAlterarAgendamento
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
            this.txbCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblAlterarAgendamento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.btnAlterarAgendamento = new System.Windows.Forms.Button();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lstAgendamento = new System.Windows.Forms.ListBox();
            this.lblAgendamentoEncontrado = new System.Windows.Forms.Label();
            this.txtIdAgendamento = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(504, 155);
            this.btnEncontrarPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(86, 31);
            this.btnEncontrarPaciente.TabIndex = 47;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            this.btnEncontrarPaciente.Click += new System.EventHandler(this.btnEncontrarPaciente_Click);
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(73, 333);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(180, 20);
            this.lblDescricaoAgendamento.TabIndex = 45;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(73, 268);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(267, 20);
            this.lblDataAgendamento.TabIndex = 41;
            this.lblDataAgendamento.Text = "Data e Hora (yyyy-mm-ddThh:mm:ss)  :";
            this.lblDataAgendamento.Visible = false;
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(73, 204);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(116, 20);
            this.lblDentista.TabIndex = 39;
            this.lblDentista.Text = "Nome Dentista :";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(355, 133);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(99, 20);
            this.lblCpfPaciente.TabIndex = 38;
            this.lblCpfPaciente.Text = "CPF Paciente :";
            // 
            // txbCpfPaciente
            // 
            this.txbCpfPaciente.Location = new System.Drawing.Point(355, 157);
            this.txbCpfPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCpfPaciente.Name = "txbCpfPaciente";
            this.txbCpfPaciente.Size = new System.Drawing.Size(130, 27);
            this.txbCpfPaciente.TabIndex = 37;
            // 
            // lblAlterarAgendamento
            // 
            this.lblAlterarAgendamento.AutoSize = true;
            this.lblAlterarAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlterarAgendamento.Location = new System.Drawing.Point(149, 40);
            this.lblAlterarAgendamento.Name = "lblAlterarAgendamento";
            this.lblAlterarAgendamento.Size = new System.Drawing.Size(344, 46);
            this.lblAlterarAgendamento.TabIndex = 36;
            this.lblAlterarAgendamento.Text = "Alterar Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(73, 133);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(116, 20);
            this.lblNomePaciente.TabIndex = 35;
            this.lblNomePaciente.Text = "Nome Paciente :";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(73, 157);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(267, 27);
            this.txtNomePaciente.TabIndex = 34;
            // 
            // btnAlterarAgendamento
            // 
            this.btnAlterarAgendamento.BackColor = System.Drawing.Color.Orange;
            this.btnAlterarAgendamento.Location = new System.Drawing.Point(404, 580);
            this.btnAlterarAgendamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarAgendamento.Name = "btnAlterarAgendamento";
            this.btnAlterarAgendamento.Size = new System.Drawing.Size(219, 44);
            this.btnAlterarAgendamento.TabIndex = 48;
            this.btnAlterarAgendamento.Text = "Alterar Agendamento";
            this.btnAlterarAgendamento.UseVisualStyleBackColor = false;
            this.btnAlterarAgendamento.Visible = false;
            this.btnAlterarAgendamento.Click += new System.EventHandler(this.btnAlterarAgendamento_Click);
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(73, 228);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(272, 27);
            this.txtNomeDentista.TabIndex = 49;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(73, 292);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(272, 27);
            this.txtData.TabIndex = 50;
            this.txtData.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 357);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 27);
            this.txtDescricao.TabIndex = 51;
            this.txtDescricao.Visible = false;
            // 
            // lstAgendamento
            // 
            this.lstAgendamento.FormattingEnabled = true;
            this.lstAgendamento.ItemHeight = 20;
            this.lstAgendamento.Location = new System.Drawing.Point(73, 436);
            this.lstAgendamento.Name = "lstAgendamento";
            this.lstAgendamento.Size = new System.Drawing.Size(795, 104);
            this.lstAgendamento.TabIndex = 52;
            this.lstAgendamento.Visible = false;
            // 
            // lblAgendamentoEncontrado
            // 
            this.lblAgendamentoEncontrado.AutoSize = true;
            this.lblAgendamentoEncontrado.Enabled = false;
            this.lblAgendamentoEncontrado.Location = new System.Drawing.Point(73, 413);
            this.lblAgendamentoEncontrado.Name = "lblAgendamentoEncontrado";
            this.lblAgendamentoEncontrado.Size = new System.Drawing.Size(195, 20);
            this.lblAgendamentoEncontrado.TabIndex = 82;
            this.lblAgendamentoEncontrado.Text = "Agendamento Encontrado : ";
            this.lblAgendamentoEncontrado.Visible = false;
            // 
            // txtIdAgendamento
            // 
            this.txtIdAgendamento.Location = new System.Drawing.Point(73, 597);
            this.txtIdAgendamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdAgendamento.Name = "txtIdAgendamento";
            this.txtIdAgendamento.Size = new System.Drawing.Size(123, 27);
            this.txtIdAgendamento.TabIndex = 85;
            this.txtIdAgendamento.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 573);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(123, 20);
            this.lblId.TabIndex = 86;
            this.lblId.Text = "ID Agendamento";
            this.lblId.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(774, 595);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 90;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmAlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 654);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdAgendamento);
            this.Controls.Add(this.lblAgendamentoEncontrado);
            this.Controls.Add(this.lstAgendamento);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.btnAlterarAgendamento);
            this.Controls.Add(this.btnEncontrarPaciente);
            this.Controls.Add(this.lblDescricaoAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txbCpfPaciente);
            this.Controls.Add(this.lblAlterarAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAlterarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Agendamento";
            this.Load += new System.EventHandler(this.frmAlterarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEncontrarPaciente;
        private Label lblDescricaoAgendamento;
        private Label lblDataAgendamento;
        private Label lblDentista;
        private Label lblCpfPaciente;
        private TextBox txbCpfPaciente;
        private Label lblAlterarAgendamento;
        private Label lblNomePaciente;
        private TextBox txtNomePaciente;
        private Button btnAlterarAgendamento;
        private TextBox txtNomeDentista;
        private TextBox txtData;
        private TextBox txtDescricao;
        private ListBox lstAgendamento;
        private Label lblAgendamentoEncontrado;
        private TextBox txtIdAgendamento;
        private Label lblId;
        private Button btnLimpar;
    }
}