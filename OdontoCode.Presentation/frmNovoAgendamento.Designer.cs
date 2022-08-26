namespace OdontoCode.Presentation
{
    partial class frmNovoAgendamento
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
            this.lblNovoAgendamento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txbCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.lblDescricaoAgendamento = new System.Windows.Forms.Label();
            this.btnEncontrarPaciente = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCampoObrigatorio = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovoAgendamento
            // 
            this.lblNovoAgendamento.AutoSize = true;
            this.lblNovoAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoAgendamento.Location = new System.Drawing.Point(131, 40);
            this.lblNovoAgendamento.Name = "lblNovoAgendamento";
            this.lblNovoAgendamento.Size = new System.Drawing.Size(447, 46);
            this.lblNovoAgendamento.TabIndex = 20;
            this.lblNovoAgendamento.Text = "Realizar Novo Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(152, 133);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(116, 20);
            this.lblNomePaciente.TabIndex = 19;
            this.lblNomePaciente.Text = "Nome Paciente :";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(152, 159);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(254, 27);
            this.txtNomePaciente.TabIndex = 18;
            // 
            // txbCpfPaciente
            // 
            this.txbCpfPaciente.Location = new System.Drawing.Point(436, 157);
            this.txbCpfPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCpfPaciente.Name = "txbCpfPaciente";
            this.txbCpfPaciente.Size = new System.Drawing.Size(159, 27);
            this.txbCpfPaciente.TabIndex = 21;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(436, 133);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(101, 20);
            this.lblCpfPaciente.TabIndex = 22;
            this.lblCpfPaciente.Text = "CPF  paciente:";
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(152, 204);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(116, 20);
            this.lblDentista.TabIndex = 23;
            this.lblDentista.Text = "Nome Dentista :";
            this.lblDentista.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(152, 278);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(263, 20);
            this.lblDataAgendamento.TabIndex = 25;
            this.lblDataAgendamento.Text = "Data e Hora (yyyy-mm-ddThh:mm:ss) :";
            this.lblDataAgendamento.Visible = false;
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(152, 345);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(180, 20);
            this.lblDescricaoAgendamento.TabIndex = 31;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(628, 224);
            this.btnEncontrarPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(86, 31);
            this.btnEncontrarPaciente.TabIndex = 33;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            this.btnEncontrarPaciente.Click += new System.EventHandler(this.btnEncontrarPaciente_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgendar.Location = new System.Drawing.Point(212, 459);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(219, 44);
            this.btnAgendar.TabIndex = 34;
            this.btnAgendar.Text = "Confirmar Agendamento";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Visible = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(152, 228);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(254, 27);
            this.txtNomeDentista.TabIndex = 35;
            this.txtNomeDentista.Visible = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(152, 302);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(254, 27);
            this.txtData.TabIndex = 36;
            this.txtData.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(152, 369);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(254, 27);
            this.txtDescricao.TabIndex = 37;
            this.txtDescricao.Visible = false;
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(541, 323);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(94, 29);
            this.btncount.TabIndex = 38;
            this.btncount.Text = "count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Visible = false;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Busca por paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Busca por dentista";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.AutoSize = true;
            this.lblCampoObrigatorio.BackColor = System.Drawing.Color.OrangeRed;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(3, 305);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(143, 20);
            this.lblCampoObrigatorio.TabIndex = 41;
            this.lblCampoObrigatorio.Text = "Campo Obrigatório";
            this.lblCampoObrigatorio.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(530, 511);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 90;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmNovoAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 552);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnEncontrarPaciente);
            this.Controls.Add(this.lblDescricaoAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txbCpfPaciente);
            this.Controls.Add(this.lblNovoAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmNovoAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Agendamento";
            this.Load += new System.EventHandler(this.frmNovoAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNovoAgendamento;
        private Label lblNomePaciente;
        private TextBox txtNomePaciente;
        private TextBox txbCpfPaciente;
        private Label lblCpfPaciente;
        private Label lblDentista;
        private Label lblDataAgendamento;
        private Label lblDescricaoAgendamento;
        private Button btnEncontrarPaciente;
        private Button btnAgendar;
        private TextBox txtNomeDentista;
        private TextBox txtData;
        private TextBox txtDescricao;
        private Button btncount;
        private Label label1;
        private Label label2;
        private Label lblCampoObrigatorio;
        private Button btnLimpar;
    }
}