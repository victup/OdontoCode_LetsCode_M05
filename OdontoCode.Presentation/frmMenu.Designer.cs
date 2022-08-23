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
            this.menuDetistaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentistaAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentistaBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentistaDesligar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCadastrarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPacienteNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPacienteAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPacienteBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPacienteDesligar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNovoAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAlterarAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAgendamentosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendamentoCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuAgendamento,
            this.menuSobre,
            this.menuSair});
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
            this.opcCadastrarDentista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDetistaNovo,
            this.menuDentistaAtualizar,
            this.menuDentistaBuscar,
            this.menuDentistaDesligar});
            this.opcCadastrarDentista.Name = "opcCadastrarDentista";
            this.opcCadastrarDentista.Size = new System.Drawing.Size(180, 22);
            this.opcCadastrarDentista.Text = "Dentista";
            // 
            // menuDetistaNovo
            // 
            this.menuDetistaNovo.Name = "menuDetistaNovo";
            this.menuDetistaNovo.Size = new System.Drawing.Size(180, 22);
            this.menuDetistaNovo.Text = "Novo";
            // 
            // menuDentistaAtualizar
            // 
            this.menuDentistaAtualizar.Name = "menuDentistaAtualizar";
            this.menuDentistaAtualizar.Size = new System.Drawing.Size(180, 22);
            this.menuDentistaAtualizar.Text = "Atualizar";
            // 
            // menuDentistaBuscar
            // 
            this.menuDentistaBuscar.Name = "menuDentistaBuscar";
            this.menuDentistaBuscar.Size = new System.Drawing.Size(180, 22);
            this.menuDentistaBuscar.Text = "Buscar";
            this.menuDentistaBuscar.Click += new System.EventHandler(this.menuDentistaBuscar_Click);
            // 
            // menuDentistaDesligar
            // 
            this.menuDentistaDesligar.Name = "menuDentistaDesligar";
            this.menuDentistaDesligar.Size = new System.Drawing.Size(180, 22);
            this.menuDentistaDesligar.Text = "Desligar";
            this.menuDentistaDesligar.Click += new System.EventHandler(this.menuDentistaDesligar_Click);
            // 
            // opcCadastrarPaciente
            // 
            this.opcCadastrarPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPacienteNovo,
            this.menuPacienteAtualizar,
            this.menuPacienteBuscar,
            this.menuPacienteDesligar});
            this.opcCadastrarPaciente.Name = "opcCadastrarPaciente";
            this.opcCadastrarPaciente.Size = new System.Drawing.Size(180, 22);
            this.opcCadastrarPaciente.Text = "Paciente";
            // 
            // menuPacienteNovo
            // 
            this.menuPacienteNovo.Name = "menuPacienteNovo";
            this.menuPacienteNovo.Size = new System.Drawing.Size(120, 22);
            this.menuPacienteNovo.Text = "Novo";
            // 
            // menuPacienteAtualizar
            // 
            this.menuPacienteAtualizar.Name = "menuPacienteAtualizar";
            this.menuPacienteAtualizar.Size = new System.Drawing.Size(120, 22);
            this.menuPacienteAtualizar.Text = "Atualizar";
            // 
            // menuPacienteBuscar
            // 
            this.menuPacienteBuscar.Name = "menuPacienteBuscar";
            this.menuPacienteBuscar.Size = new System.Drawing.Size(120, 22);
            this.menuPacienteBuscar.Text = "Buscar";
            // 
            // menuPacienteDesligar
            // 
            this.menuPacienteDesligar.Name = "menuPacienteDesligar";
            this.menuPacienteDesligar.Size = new System.Drawing.Size(120, 22);
            this.menuPacienteDesligar.Text = "Desligar";
            // 
            // menuAgendamento
            // 
            this.menuAgendamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNovoAgendamento,
            this.opcAlterarAgendamento,
            this.opcAgendamentosBuscar,
            this.menuAgendamentoCancelar});
            this.menuAgendamento.Name = "menuAgendamento";
            this.menuAgendamento.Size = new System.Drawing.Size(100, 20);
            this.menuAgendamento.Text = "Agendamentos";
            // 
            // opcNovoAgendamento
            // 
            this.opcNovoAgendamento.Name = "opcNovoAgendamento";
            this.opcNovoAgendamento.Size = new System.Drawing.Size(182, 22);
            this.opcNovoAgendamento.Text = "Novo Agendamento";
            // 
            // opcAlterarAgendamento
            // 
            this.opcAlterarAgendamento.Name = "opcAlterarAgendamento";
            this.opcAlterarAgendamento.Size = new System.Drawing.Size(182, 22);
            this.opcAlterarAgendamento.Text = "Alterar/Reagendar";
            // 
            // opcAgendamentosBuscar
            // 
            this.opcAgendamentosBuscar.Name = "opcAgendamentosBuscar";
            this.opcAgendamentosBuscar.Size = new System.Drawing.Size(182, 22);
            this.opcAgendamentosBuscar.Text = "Buscar";
            // 
            // menuAgendamentoCancelar
            // 
            this.menuAgendamentoCancelar.Name = "menuAgendamentoCancelar";
            this.menuAgendamentoCancelar.Size = new System.Drawing.Size(182, 22);
            this.menuAgendamentoCancelar.Text = "Cancelar";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
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
            this.MaximizeBox = false;
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
        private ToolStripMenuItem opcCadastrarDentista;
        private ToolStripMenuItem opcCadastrarPaciente;
        private ToolStripMenuItem menuAgendamento;
        private ToolStripMenuItem opcNovoAgendamento;
        private ToolStripMenuItem opcAlterarAgendamento;
        private ToolStripMenuItem opcAgendamentosBuscar;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuSobre;
        private ToolStripMenuItem menuSair;
        private ToolStripMenuItem menuDetistaNovo;
        private ToolStripMenuItem menuDentistaAtualizar;
        private ToolStripMenuItem menuDentistaBuscar;
        private ToolStripMenuItem menuDentistaDesligar;
        private ToolStripMenuItem menuPacienteNovo;
        private ToolStripMenuItem menuPacienteAtualizar;
        private ToolStripMenuItem menuPacienteBuscar;
        private ToolStripMenuItem menuPacienteDesligar;
        private ToolStripMenuItem menuAgendamentoCancelar;
    }
}