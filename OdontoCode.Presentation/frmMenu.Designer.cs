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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuAgendamento,
            this.menuSobre,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(689, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcCadastrarDentista,
            this.opcCadastrarPaciente});
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(82, 24);
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
            this.opcCadastrarDentista.Size = new System.Drawing.Size(147, 26);
            this.opcCadastrarDentista.Text = "Dentista";
            // 
            // menuDetistaNovo
            // 
            this.menuDetistaNovo.Name = "menuDetistaNovo";
            this.menuDetistaNovo.Size = new System.Drawing.Size(151, 26);
            this.menuDetistaNovo.Text = "Novo";
            this.menuDetistaNovo.Click += new System.EventHandler(this.menuDetistaNovo_Click);
            // 
            // menuDentistaAtualizar
            // 
            this.menuDentistaAtualizar.Name = "menuDentistaAtualizar";
            this.menuDentistaAtualizar.Size = new System.Drawing.Size(151, 26);
            this.menuDentistaAtualizar.Text = "Atualizar";
            this.menuDentistaAtualizar.Click += new System.EventHandler(this.menuDentistaAtualizar_Click);
            // 
            // menuDentistaBuscar
            // 
            this.menuDentistaBuscar.Name = "menuDentistaBuscar";
            this.menuDentistaBuscar.Size = new System.Drawing.Size(151, 26);
            this.menuDentistaBuscar.Text = "Buscar";
            this.menuDentistaBuscar.Click += new System.EventHandler(this.menuDentistaBuscar_Click);
            // 
            // menuDentistaDesligar
            // 
            this.menuDentistaDesligar.Name = "menuDentistaDesligar";
            this.menuDentistaDesligar.Size = new System.Drawing.Size(151, 26);
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
            this.opcCadastrarPaciente.Size = new System.Drawing.Size(147, 26);
            this.opcCadastrarPaciente.Text = "Paciente";
            // 
            // menuPacienteNovo
            // 
            this.menuPacienteNovo.Name = "menuPacienteNovo";
            this.menuPacienteNovo.Size = new System.Drawing.Size(151, 26);
            this.menuPacienteNovo.Text = "Novo";
            // 
            // menuPacienteAtualizar
            // 
            this.menuPacienteAtualizar.Name = "menuPacienteAtualizar";
            this.menuPacienteAtualizar.Size = new System.Drawing.Size(151, 26);
            this.menuPacienteAtualizar.Text = "Atualizar";
            // 
            // menuPacienteBuscar
            // 
            this.menuPacienteBuscar.Name = "menuPacienteBuscar";
            this.menuPacienteBuscar.Size = new System.Drawing.Size(151, 26);
            this.menuPacienteBuscar.Text = "Buscar";
            // 
            // menuPacienteDesligar
            // 
            this.menuPacienteDesligar.Name = "menuPacienteDesligar";
            this.menuPacienteDesligar.Size = new System.Drawing.Size(151, 26);
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
            this.menuAgendamento.Size = new System.Drawing.Size(124, 24);
            this.menuAgendamento.Text = "Agendamentos";
            // 
            // opcNovoAgendamento
            // 
            this.opcNovoAgendamento.Name = "opcNovoAgendamento";
            this.opcNovoAgendamento.Size = new System.Drawing.Size(227, 26);
            this.opcNovoAgendamento.Text = "Novo Agendamento";
            this.opcNovoAgendamento.Click += new System.EventHandler(this.opcNovoAgendamento_Click);
            // 
            // opcAlterarAgendamento
            // 
            this.opcAlterarAgendamento.Name = "opcAlterarAgendamento";
            this.opcAlterarAgendamento.Size = new System.Drawing.Size(227, 26);
            this.opcAlterarAgendamento.Text = "Alterar/Reagendar";
            this.opcAlterarAgendamento.Click += new System.EventHandler(this.opcAlterarAgendamento_Click);
            // 
            // opcAgendamentosBuscar
            // 
            this.opcAgendamentosBuscar.Name = "opcAgendamentosBuscar";
            this.opcAgendamentosBuscar.Size = new System.Drawing.Size(227, 26);
            this.opcAgendamentosBuscar.Text = "Buscar";
            this.opcAgendamentosBuscar.Click += new System.EventHandler(this.opcAgendamentosBuscar_Click);
            // 
            // menuAgendamentoCancelar
            // 
            this.menuAgendamentoCancelar.Name = "menuAgendamentoCancelar";
            this.menuAgendamentoCancelar.Size = new System.Drawing.Size(227, 26);
            this.menuAgendamentoCancelar.Text = "Cancelar";
            this.menuAgendamentoCancelar.Click += new System.EventHandler(this.menuAgendamentoCancelar_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(62, 24);
            this.menuSobre.Text = "Sobre";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(48, 24);
            this.menuSair.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoCode.Presentation.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(144, 191);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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