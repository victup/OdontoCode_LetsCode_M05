﻿namespace OdontoCode.Presentation
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
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.lblDescricaoAgendamento = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dtAgendamento = new System.Windows.Forms.DateTimePicker();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txbCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblCancelarAgendamento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(182, 320);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(192, 33);
            this.btnCancelarAgendamento.TabIndex = 63;
            this.btnCancelarAgendamento.Text = "Cancelar Agendamento";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = false;
            this.btnCancelarAgendamento.Visible = false;
            // 
            // btnEncontrarPaciente
            // 
            this.btnEncontrarPaciente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarPaciente.Location = new System.Drawing.Point(412, 113);
            this.btnEncontrarPaciente.Name = "btnEncontrarPaciente";
            this.btnEncontrarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrarPaciente.TabIndex = 62;
            this.btnEncontrarPaciente.Text = "Buscar";
            this.btnEncontrarPaciente.UseVisualStyleBackColor = false;
            // 
            // cbDescricao
            // 
            this.cbDescricao.Enabled = false;
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(64, 266);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(162, 23);
            this.cbDescricao.TabIndex = 61;
            this.cbDescricao.Visible = false;
            // 
            // lblDescricaoAgendamento
            // 
            this.lblDescricaoAgendamento.AutoSize = true;
            this.lblDescricaoAgendamento.Enabled = false;
            this.lblDescricaoAgendamento.Location = new System.Drawing.Point(64, 248);
            this.lblDescricaoAgendamento.Name = "lblDescricaoAgendamento";
            this.lblDescricaoAgendamento.Size = new System.Drawing.Size(144, 15);
            this.lblDescricaoAgendamento.TabIndex = 60;
            this.lblDescricaoAgendamento.Text = "Descrição/Procedimento: ";
            this.lblDescricaoAgendamento.Visible = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Enabled = false;
            this.lblHorario.Location = new System.Drawing.Point(325, 199);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 15);
            this.lblHorario.TabIndex = 59;
            this.lblHorario.Text = "Horario :";
            this.lblHorario.Visible = false;
            // 
            // dtAgendamento
            // 
            this.dtAgendamento.Enabled = false;
            this.dtAgendamento.Location = new System.Drawing.Point(64, 217);
            this.dtAgendamento.Name = "dtAgendamento";
            this.dtAgendamento.Size = new System.Drawing.Size(240, 23);
            this.dtAgendamento.TabIndex = 58;
            this.dtAgendamento.Visible = false;
            // 
            // cbHorario
            // 
            this.cbHorario.Enabled = false;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(325, 217);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(162, 23);
            this.cbHorario.TabIndex = 57;
            this.cbHorario.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Enabled = false;
            this.lblDataAgendamento.Location = new System.Drawing.Point(64, 199);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(37, 15);
            this.lblDataAgendamento.TabIndex = 56;
            this.lblDataAgendamento.Text = "Data :";
            this.lblDataAgendamento.Visible = false;
            // 
            // cbDentista
            // 
            this.cbDentista.Enabled = false;
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(64, 169);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(162, 23);
            this.cbDentista.TabIndex = 55;
            this.cbDentista.Visible = false;
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Enabled = false;
            this.lblDentista.Location = new System.Drawing.Point(64, 151);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(56, 15);
            this.lblDentista.TabIndex = 54;
            this.lblDentista.Text = "Dentista :";
            this.lblDentista.Visible = false;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(64, 96);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(34, 15);
            this.lblCpfPaciente.TabIndex = 53;
            this.lblCpfPaciente.Text = "CPF :";
            // 
            // txbCpfPaciente
            // 
            this.txbCpfPaciente.Location = new System.Drawing.Point(64, 114);
            this.txbCpfPaciente.Name = "txbCpfPaciente";
            this.txbCpfPaciente.Size = new System.Drawing.Size(114, 23);
            this.txbCpfPaciente.TabIndex = 52;
            // 
            // lblCancelarAgendamento
            // 
            this.lblCancelarAgendamento.AutoSize = true;
            this.lblCancelarAgendamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCancelarAgendamento.Location = new System.Drawing.Point(130, 28);
            this.lblCancelarAgendamento.Name = "lblCancelarAgendamento";
            this.lblCancelarAgendamento.Size = new System.Drawing.Size(295, 37);
            this.lblCancelarAgendamento.TabIndex = 51;
            this.lblCancelarAgendamento.Text = "Cancelar Agendamento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(203, 96);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(46, 15);
            this.lblNomePaciente.TabIndex = 50;
            this.lblNomePaciente.Text = "Nome :";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(203, 114);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(203, 23);
            this.txtNomePaciente.TabIndex = 49;
            // 
            // frmCancelarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 404);
            this.Controls.Add(this.btnCancelarAgendamento);
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
            this.Controls.Add(this.lblCancelarAgendamento);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.MaximizeBox = false;
            this.Name = "frmCancelarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelarAgendamento;
        private Button btnEncontrarPaciente;
        private ComboBox cbDescricao;
        private Label lblDescricaoAgendamento;
        private Label lblHorario;
        private DateTimePicker dtAgendamento;
        private ComboBox cbHorario;
        private Label lblDataAgendamento;
        private ComboBox cbDentista;
        private Label lblDentista;
        private Label lblCpfPaciente;
        private TextBox txbCpfPaciente;
        private Label lblCancelarAgendamento;
        private Label lblNomePaciente;
        private TextBox txtNomePaciente;
    }
}