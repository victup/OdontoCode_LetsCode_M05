namespace OdontoCode.Presentation
{
    partial class frmAtualizarDentista
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
            this.lblNomeDentista = new System.Windows.Forms.Label();
            this.lblAtualizarDentista = new System.Windows.Forms.Label();
            this.lblTelefoneDentista = new System.Windows.Forms.Label();
            this.txtNomeDentistaAtualizar = new System.Windows.Forms.TextBox();
            this.txtTelefoneDentistaAtualizar = new System.Windows.Forms.TextBox();
            this.btnAtualizarDentista = new System.Windows.Forms.Button();
            this.btnEncontrarDentista = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDentistaCpfAtualizar = new System.Windows.Forms.TextBox();
            this.lblCroDentista = new System.Windows.Forms.Label();
            this.txtCroDentistaAtualizar = new System.Windows.Forms.TextBox();
            this.lblValidaEntradas = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPaginaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeDentista
            // 
            this.lblNomeDentista.AutoSize = true;
            this.lblNomeDentista.Location = new System.Drawing.Point(121, 123);
            this.lblNomeDentista.Name = "lblNomeDentista";
            this.lblNomeDentista.Size = new System.Drawing.Size(49, 15);
            this.lblNomeDentista.TabIndex = 0;
            this.lblNomeDentista.Text = "Nome : ";
            // 
            // lblAtualizarDentista
            // 
            this.lblAtualizarDentista.AutoSize = true;
            this.lblAtualizarDentista.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtualizarDentista.Location = new System.Drawing.Point(176, 45);
            this.lblAtualizarDentista.Name = "lblAtualizarDentista";
            this.lblAtualizarDentista.Size = new System.Drawing.Size(339, 37);
            this.lblAtualizarDentista.TabIndex = 1;
            this.lblAtualizarDentista.Text = "Atualizar Cadastro Dentista";
            // 
            // lblTelefoneDentista
            // 
            this.lblTelefoneDentista.AutoSize = true;
            this.lblTelefoneDentista.Location = new System.Drawing.Point(423, 183);
            this.lblTelefoneDentista.Name = "lblTelefoneDentista";
            this.lblTelefoneDentista.Size = new System.Drawing.Size(60, 15);
            this.lblTelefoneDentista.TabIndex = 3;
            this.lblTelefoneDentista.Text = "Telefone : ";
            this.lblTelefoneDentista.Visible = false;
            // 
            // txtNomeDentistaAtualizar
            // 
            this.txtNomeDentistaAtualizar.Location = new System.Drawing.Point(121, 140);
            this.txtNomeDentistaAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeDentistaAtualizar.Name = "txtNomeDentistaAtualizar";
            this.txtNomeDentistaAtualizar.Size = new System.Drawing.Size(505, 23);
            this.txtNomeDentistaAtualizar.TabIndex = 1;
            // 
            // txtTelefoneDentistaAtualizar
            // 
            this.txtTelefoneDentistaAtualizar.Location = new System.Drawing.Point(423, 201);
            this.txtTelefoneDentistaAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefoneDentistaAtualizar.Name = "txtTelefoneDentistaAtualizar";
            this.txtTelefoneDentistaAtualizar.Size = new System.Drawing.Size(204, 23);
            this.txtTelefoneDentistaAtualizar.TabIndex = 4;
            this.txtTelefoneDentistaAtualizar.Visible = false;
            // 
            // btnAtualizarDentista
            // 
            this.btnAtualizarDentista.BackColor = System.Drawing.Color.Gold;
            this.btnAtualizarDentista.Location = new System.Drawing.Point(304, 305);
            this.btnAtualizarDentista.Name = "btnAtualizarDentista";
            this.btnAtualizarDentista.Size = new System.Drawing.Size(192, 33);
            this.btnAtualizarDentista.TabIndex = 6;
            this.btnAtualizarDentista.Text = "Atualizar Cadastro do Dentista";
            this.btnAtualizarDentista.UseVisualStyleBackColor = false;
            this.btnAtualizarDentista.Visible = false;
            this.btnAtualizarDentista.Click += new System.EventHandler(this.btnAtualizarDentista_Click);
            // 
            // btnEncontrarDentista
            // 
            this.btnEncontrarDentista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarDentista.Location = new System.Drawing.Point(661, 140);
            this.btnEncontrarDentista.Name = "btnEncontrarDentista";
            this.btnEncontrarDentista.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrarDentista.TabIndex = 5;
            this.btnEncontrarDentista.Text = "Buscar";
            this.btnEncontrarDentista.UseVisualStyleBackColor = false;
            this.btnEncontrarDentista.Click += new System.EventHandler(this.btnEncontrarDentista_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(121, 183);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 15);
            this.lblCPF.TabIndex = 61;
            this.lblCPF.Text = "CPF :";
            // 
            // txtDentistaCpfAtualizar
            // 
            this.txtDentistaCpfAtualizar.Location = new System.Drawing.Point(121, 201);
            this.txtDentistaCpfAtualizar.Name = "txtDentistaCpfAtualizar";
            this.txtDentistaCpfAtualizar.Size = new System.Drawing.Size(114, 23);
            this.txtDentistaCpfAtualizar.TabIndex = 2;
            // 
            // lblCroDentista
            // 
            this.lblCroDentista.AutoSize = true;
            this.lblCroDentista.Location = new System.Drawing.Point(250, 183);
            this.lblCroDentista.Name = "lblCroDentista";
            this.lblCroDentista.Size = new System.Drawing.Size(37, 15);
            this.lblCroDentista.TabIndex = 59;
            this.lblCroDentista.Text = "CRO :";
            // 
            // txtCroDentistaAtualizar
            // 
            this.txtCroDentistaAtualizar.Location = new System.Drawing.Point(250, 201);
            this.txtCroDentistaAtualizar.Name = "txtCroDentistaAtualizar";
            this.txtCroDentistaAtualizar.Size = new System.Drawing.Size(114, 23);
            this.txtCroDentistaAtualizar.TabIndex = 3;
            // 
            // lblValidaEntradas
            // 
            this.lblValidaEntradas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValidaEntradas.Location = new System.Drawing.Point(12, 248);
            this.lblValidaEntradas.Name = "lblValidaEntradas";
            this.lblValidaEntradas.Size = new System.Drawing.Size(763, 18);
            this.lblValidaEntradas.TabIndex = 63;
            this.lblValidaEntradas.Text = "label1";
            this.lblValidaEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValidaEntradas.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaginaInicial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPaginaInicial
            // 
            this.menuPaginaInicial.Name = "menuPaginaInicial";
            this.menuPaginaInicial.Size = new System.Drawing.Size(89, 20);
            this.menuPaginaInicial.Text = "Página Inicial";
            this.menuPaginaInicial.Click += new System.EventHandler(this.menuPaginaInicial_Click);
            // 
            // frmAtualizarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidaEntradas);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtDentistaCpfAtualizar);
            this.Controls.Add(this.lblCroDentista);
            this.Controls.Add(this.txtCroDentistaAtualizar);
            this.Controls.Add(this.btnEncontrarDentista);
            this.Controls.Add(this.btnAtualizarDentista);
            this.Controls.Add(this.txtTelefoneDentistaAtualizar);
            this.Controls.Add(this.txtNomeDentistaAtualizar);
            this.Controls.Add(this.lblTelefoneDentista);
            this.Controls.Add(this.lblAtualizarDentista);
            this.Controls.Add(this.lblNomeDentista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmAtualizarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Dentista";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeDentista;
        private Label lblAtualizarDentista;
        private Label lblTelefoneDentista;
        private TextBox txtNomeDentistaAtualizar;
        private TextBox txtTelefoneDentistaAtualizar;
        private Button btnAtualizarDentista;
        private Button btnEncontrarDentista;
        private Label lblCPF;
        private TextBox txtDentistaCpfAtualizar;
        private Label lblCroDentista;
        private TextBox txtCroDentistaAtualizar;
        private Label lblValidaEntradas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPaginaInicial;
    }
}