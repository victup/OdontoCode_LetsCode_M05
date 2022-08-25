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
            this.btnEncontrarAgendamento = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEncontrarAgendamento
            // 
            this.btnEncontrarAgendamento.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarAgendamento.Location = new System.Drawing.Point(395, 321);
            this.btnEncontrarAgendamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarAgendamento.Name = "btnEncontrarAgendamento";
            this.btnEncontrarAgendamento.Size = new System.Drawing.Size(101, 55);
            this.btnEncontrarAgendamento.TabIndex = 76;
            this.btnEncontrarAgendamento.Text = "Buscar";
            this.btnEncontrarAgendamento.UseVisualStyleBackColor = false;
            this.btnEncontrarAgendamento.Click += new System.EventHandler(this.btnEncontrarPaciente_Click);
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Enabled = false;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(62, 324);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(180, 20);
            this.lblDescricaoAgendamento.TabIndex = 74;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Enabled = false;
            this.lblDataAgendamento.Location = new System.Drawing.Point(67, 249);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(263, 20);
            this.lblDataAgendamento.TabIndex = 70;
            this.lblDataAgendamento.Text = "Data e Hora (yyyy-mm-dd  hh:mm:ss) :";
            this.lblDataAgendamento.Visible = false;
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Enabled = false;
            this.lblDentista.Location = new System.Drawing.Point(67, 179);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(138, 20);
            this.lblDentista.TabIndex = 68;
            this.lblDentista.Text = "Nome do Dentista :";
            this.lblDentista.Visible = false;
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
            this.listAgendamento.Location = new System.Drawing.Point(62, 454);
            this.listAgendamento.Name = "listAgendamento";
            this.listAgendamento.Size = new System.Drawing.Size(541, 104);
            this.listAgendamento.TabIndex = 77;
            // 
            // txtDataEHora
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(62, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Agendamento Encontrado : ";
            this.label1.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(662, 503);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 55);
            this.btnLimpar.TabIndex = 82;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // frmBuscarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 587);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.txtDataEHora);
            this.Controls.Add(this.listAgendamento);
            this.Controls.Add(this.btnEncontrarAgendamento);
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

        private Button btnEncontrarAgendamento;
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
        private Label label1;
        private Button btnLimpar;
        private DateTimePicker dateTimePicker1;
    }
}