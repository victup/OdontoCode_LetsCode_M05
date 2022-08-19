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
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.dtAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDescricaoAgendamento = new System.Windows.Forms.Label();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.btnEncontrarPaciente = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovoAgendamento
            // 
            this.lblNovoAgendamento.AutoSize = true;
            this.lblNovoAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoAgendamento.Location = new System.Drawing.Point(115, 30);
            this.lblNovoAgendamento.Name = "lblNovoAgendamento";
            this.lblNovoAgendamento.Size = new System.Drawing.Size(357, 37);
            this.lblNovoAgendamento.TabIndex = 20;
            this.lblNovoAgendamento.Text = "Realizar Novo Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(221, 98);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(46, 15);
            this.lblNomePaciente.TabIndex = 19;
            this.lblNomePaciente.Text = "Nome :";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(221, 116);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(203, 23);
            this.txtNomePaciente.TabIndex = 18;
            // 
            // txbCpfPaciente
            // 
            this.txbCpfPaciente.Location = new System.Drawing.Point(82, 116);
            this.txbCpfPaciente.Name = "txbCpfPaciente";
            this.txbCpfPaciente.Size = new System.Drawing.Size(114, 23);
            this.txbCpfPaciente.TabIndex = 21;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(82, 98);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(34, 15);
            this.lblCpfPaciente.TabIndex = 22;
            this.lblCpfPaciente.Text = "CPF :";
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(82, 153);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(56, 15);
            this.lblDentista.TabIndex = 23;
            this.lblDentista.Text = "Dentista :";
            this.lblDentista.Visible = false;
            // 
            // cbDentista
            // 
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(82, 171);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(162, 23);
            this.cbDentista.TabIndex = 24;
            this.cbDentista.Visible = false;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(343, 219);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(162, 23);
            this.cbHorario.TabIndex = 26;
            this.cbHorario.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(82, 201);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(37, 15);
            this.lblDataAgendamento.TabIndex = 25;
            this.lblDataAgendamento.Text = "Data :";
            this.lblDataAgendamento.Visible = false;
            // 
            // dtAgendamento
            // 
            this.dtAgendamento.Location = new System.Drawing.Point(82, 219);
            this.dtAgendamento.Name = "dtAgendamento";
            this.dtAgendamento.Size = new System.Drawing.Size(240, 23);
            this.dtAgendamento.TabIndex = 28;
            this.dtAgendamento.Visible = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(343, 201);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 15);
            this.lblHorario.TabIndex = 29;
            this.lblHorario.Text = "Horario :";
            this.lblHorario.Visible = false;
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(82, 250);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(144, 15);
            this.lblDescricaoAgendamento.TabIndex = 31;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(82, 268);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(162, 23);
            this.cbDescricao.TabIndex = 32;
            this.cbDescricao.Visible = false;
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(430, 115);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrarPaciente.TabIndex = 33;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgendar.Location = new System.Drawing.Point(204, 318);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(192, 33);
            this.btnAgendar.TabIndex = 34;
            this.btnAgendar.Text = "Confirmar Agendamento";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Visible = false;
            // 
            // frmNovoAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnEncontrarPaciente);
            this.Controls.Add(this.cbDescricao);
            this.Controls.Add(this.lblDescricaoAgendamento);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dtAgendamento);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txbCpfPaciente);
            this.Controls.Add(this.lblNovoAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.MaximizeBox = false;
            this.Name = "frmNovoAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Agendamento";
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
        private ComboBox cbDentista;
        private ComboBox cbHorario;
        private Label lblDataAgendamento;
        private DateTimePicker dtAgendamento;
        private Label lblHorario;
        private Label lblDescricaoAgendamento;
        private ComboBox cbDescricao;
        private Button btnEncontrarPaciente;
        private Button btnAgendar;
    }
}