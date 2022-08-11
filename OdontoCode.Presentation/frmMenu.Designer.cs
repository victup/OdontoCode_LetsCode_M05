namespace OdontoCode.Presentation
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCadastrarDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCadastrarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcPesquisarDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.opcPesquisarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAtualizarDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAtualizarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDesligar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcDesligarDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNovoAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.opcReagendar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAgendamentosDoDia = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuPesquisar,
            this.menuAtualizar,
            this.menuDesligar,
            this.menuAgendamento});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcCadastrarDentista,
            this.opcCadastrarPaciente});
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(66, 20);
            this.menuCadastrar.Text = "Cadastro";
            // 
            // opcCadastrarDentista
            // 
            this.opcCadastrarDentista.Name = "opcCadastrarDentista";
            this.opcCadastrarDentista.Size = new System.Drawing.Size(119, 22);
            this.opcCadastrarDentista.Text = "Dentista";
            // 
            // opcCadastrarPaciente
            // 
            this.opcCadastrarPaciente.Name = "opcCadastrarPaciente";
            this.opcCadastrarPaciente.Size = new System.Drawing.Size(119, 22);
            this.opcCadastrarPaciente.Text = "Paciente";
            // 
            // menuPesquisar
            // 
            this.menuPesquisar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcPesquisarDentista,
            this.opcPesquisarPaciente});
            this.menuPesquisar.Name = "menuPesquisar";
            this.menuPesquisar.Size = new System.Drawing.Size(69, 20);
            this.menuPesquisar.Text = "Pesquisar";
            // 
            // opcPesquisarDentista
            // 
            this.opcPesquisarDentista.Name = "opcPesquisarDentista";
            this.opcPesquisarDentista.Size = new System.Drawing.Size(119, 22);
            this.opcPesquisarDentista.Text = "Dentista";
            // 
            // opcPesquisarPaciente
            // 
            this.opcPesquisarPaciente.Name = "opcPesquisarPaciente";
            this.opcPesquisarPaciente.Size = new System.Drawing.Size(119, 22);
            this.opcPesquisarPaciente.Text = "Paciente";
            // 
            // menuAtualizar
            // 
            this.menuAtualizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcAtualizarDentista,
            this.opcAtualizarPaciente});
            this.menuAtualizar.Name = "menuAtualizar";
            this.menuAtualizar.Size = new System.Drawing.Size(65, 20);
            this.menuAtualizar.Text = "Atualizar";
            // 
            // opcAtualizarDentista
            // 
            this.opcAtualizarDentista.Name = "opcAtualizarDentista";
            this.opcAtualizarDentista.Size = new System.Drawing.Size(119, 22);
            this.opcAtualizarDentista.Text = "Dentista";
            // 
            // opcAtualizarPaciente
            // 
            this.opcAtualizarPaciente.Name = "opcAtualizarPaciente";
            this.opcAtualizarPaciente.Size = new System.Drawing.Size(119, 22);
            this.opcAtualizarPaciente.Text = "Paciente";
            // 
            // menuDesligar
            // 
            this.menuDesligar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcDesligarDentista});
            this.menuDesligar.Name = "menuDesligar";
            this.menuDesligar.Size = new System.Drawing.Size(61, 20);
            this.menuDesligar.Text = "Desligar";
            this.menuDesligar.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // opcDesligarDentista
            // 
            this.opcDesligarDentista.Name = "opcDesligarDentista";
            this.opcDesligarDentista.Size = new System.Drawing.Size(117, 22);
            this.opcDesligarDentista.Text = "Dentista";
            // 
            // menuAgendamento
            // 
            this.menuAgendamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNovoAgendamento,
            this.opcReagendar,
            this.opcAgendamentosDoDia});
            this.menuAgendamento.Name = "menuAgendamento";
            this.menuAgendamento.Size = new System.Drawing.Size(100, 20);
            this.menuAgendamento.Text = "Agendamentos";
            // 
            // opcNovoAgendamento
            // 
            this.opcNovoAgendamento.Name = "opcNovoAgendamento";
            this.opcNovoAgendamento.Size = new System.Drawing.Size(197, 22);
            this.opcNovoAgendamento.Text = "Novo Agendamento";
            // 
            // opcReagendar
            // 
            this.opcReagendar.Name = "opcReagendar";
            this.opcReagendar.Size = new System.Drawing.Size(197, 22);
            this.opcReagendar.Text = "Reagendar";
            // 
            // opcAgendamentosDoDia
            // 
            this.opcAgendamentosDoDia.Name = "opcAgendamentosDoDia";
            this.opcAgendamentosDoDia.Size = new System.Drawing.Size(197, 22);
            this.opcAgendamentosDoDia.Text = "Agendamentos de hoje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoCode.Presentation.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(126, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odonto Code";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastrar;
        private ToolStripMenuItem menuPesquisar;
        private ToolStripMenuItem menuAtualizar;
        private ToolStripMenuItem menuDesligar;
        private ToolStripMenuItem opcCadastrarDentista;
        private ToolStripMenuItem opcCadastrarPaciente;
        private ToolStripMenuItem opcPesquisarDentista;
        private ToolStripMenuItem opcPesquisarPaciente;
        private ToolStripMenuItem opcAtualizarDentista;
        private ToolStripMenuItem opcAtualizarPaciente;
        private ToolStripMenuItem opcDesligarDentista;
        private ToolStripMenuItem menuAgendamento;
        private ToolStripMenuItem opcNovoAgendamento;
        private ToolStripMenuItem opcReagendar;
        private ToolStripMenuItem opcAgendamentosDoDia;
        private PictureBox pictureBox1;
    }
}