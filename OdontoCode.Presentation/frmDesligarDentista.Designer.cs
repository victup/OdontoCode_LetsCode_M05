namespace OdontoCode.Presentation
{
    partial class frmDesligarDentista
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
            this.lblDesligarDentista = new System.Windows.Forms.Label();
            this.lblNomeDesligarDentista = new System.Windows.Forms.Label();
            this.lblTelefoneDesligarDentista = new System.Windows.Forms.Label();
            this.txtNomeDesligarDentista = new System.Windows.Forms.TextBox();
            this.txtTelefoneDesligarDentista = new System.Windows.Forms.TextBox();
            this.btnEncontrarDentista = new System.Windows.Forms.Button();
            this.btnDesligarDentista = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDentistaCpfDesligar = new System.Windows.Forms.TextBox();
            this.lblCroDentista = new System.Windows.Forms.Label();
            this.txtCroDentistaDesligar = new System.Windows.Forms.TextBox();
            this.lblVerificaEntradas = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesligarDentista
            // 
            this.lblDesligarDentista.AutoSize = true;
            this.lblDesligarDentista.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesligarDentista.Location = new System.Drawing.Point(194, 41);
            this.lblDesligarDentista.Name = "lblDesligarDentista";
            this.lblDesligarDentista.Size = new System.Drawing.Size(219, 37);
            this.lblDesligarDentista.TabIndex = 101;
            this.lblDesligarDentista.Text = "Desligar Dentista";
            // 
            // lblNomeDesligarDentista
            // 
            this.lblNomeDesligarDentista.AutoSize = true;
            this.lblNomeDesligarDentista.Location = new System.Drawing.Point(96, 94);
            this.lblNomeDesligarDentista.Name = "lblNomeDesligarDentista";
            this.lblNomeDesligarDentista.Size = new System.Drawing.Size(46, 15);
            this.lblNomeDesligarDentista.TabIndex = 102;
            this.lblNomeDesligarDentista.Text = "Nome :";
            // 
            // lblTelefoneDesligarDentista
            // 
            this.lblTelefoneDesligarDentista.AutoSize = true;
            this.lblTelefoneDesligarDentista.Location = new System.Drawing.Point(350, 143);
            this.lblTelefoneDesligarDentista.Name = "lblTelefoneDesligarDentista";
            this.lblTelefoneDesligarDentista.Size = new System.Drawing.Size(57, 15);
            this.lblTelefoneDesligarDentista.TabIndex = 104;
            this.lblTelefoneDesligarDentista.Text = "Telefone :";
            this.lblTelefoneDesligarDentista.Visible = false;
            // 
            // txtNomeDesligarDentista
            // 
            this.txtNomeDesligarDentista.Location = new System.Drawing.Point(96, 112);
            this.txtNomeDesligarDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeDesligarDentista.Name = "txtNomeDesligarDentista";
            this.txtNomeDesligarDentista.Size = new System.Drawing.Size(445, 23);
            this.txtNomeDesligarDentista.TabIndex = 1;
            // 
            // txtTelefoneDesligarDentista
            // 
            this.txtTelefoneDesligarDentista.Location = new System.Drawing.Point(350, 160);
            this.txtTelefoneDesligarDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefoneDesligarDentista.Name = "txtTelefoneDesligarDentista";
            this.txtTelefoneDesligarDentista.Size = new System.Drawing.Size(191, 23);
            this.txtTelefoneDesligarDentista.TabIndex = 4;
            this.txtTelefoneDesligarDentista.Visible = false;
            // 
            // btnEncontrarDentista
            // 
            this.btnEncontrarDentista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarDentista.Location = new System.Drawing.Point(575, 112);
            this.btnEncontrarDentista.Name = "btnEncontrarDentista";
            this.btnEncontrarDentista.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrarDentista.TabIndex = 5;
            this.btnEncontrarDentista.Text = "Buscar";
            this.btnEncontrarDentista.UseVisualStyleBackColor = false;
            this.btnEncontrarDentista.Click += new System.EventHandler(this.btnEncontrarDentista_Click);
            // 
            // btnDesligarDentista
            // 
            this.btnDesligarDentista.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDesligarDentista.Location = new System.Drawing.Point(207, 236);
            this.btnDesligarDentista.Name = "btnDesligarDentista";
            this.btnDesligarDentista.Size = new System.Drawing.Size(192, 33);
            this.btnDesligarDentista.TabIndex = 6;
            this.btnDesligarDentista.Text = "Desligar Dentista";
            this.btnDesligarDentista.UseVisualStyleBackColor = false;
            this.btnDesligarDentista.Visible = false;
            this.btnDesligarDentista.Click += new System.EventHandler(this.btnDesligarDentista_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(96, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 15);
            this.lblCPF.TabIndex = 113;
            this.lblCPF.Text = "CPF :";
            // 
            // txtDentistaCpfDesligar
            // 
            this.txtDentistaCpfDesligar.Location = new System.Drawing.Point(96, 160);
            this.txtDentistaCpfDesligar.Name = "txtDentistaCpfDesligar";
            this.txtDentistaCpfDesligar.Size = new System.Drawing.Size(114, 23);
            this.txtDentistaCpfDesligar.TabIndex = 2;
            // 
            // lblCroDentista
            // 
            this.lblCroDentista.AutoSize = true;
            this.lblCroDentista.Location = new System.Drawing.Point(225, 142);
            this.lblCroDentista.Name = "lblCroDentista";
            this.lblCroDentista.Size = new System.Drawing.Size(37, 15);
            this.lblCroDentista.TabIndex = 111;
            this.lblCroDentista.Text = "CRO :";
            // 
            // txtCroDentistaDesligar
            // 
            this.txtCroDentistaDesligar.Location = new System.Drawing.Point(225, 160);
            this.txtCroDentistaDesligar.Name = "txtCroDentistaDesligar";
            this.txtCroDentistaDesligar.Size = new System.Drawing.Size(114, 23);
            this.txtCroDentistaDesligar.TabIndex = 3;
            // 
            // lblVerificaEntradas
            // 
            this.lblVerificaEntradas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVerificaEntradas.Location = new System.Drawing.Point(-2, 196);
            this.lblVerificaEntradas.Name = "lblVerificaEntradas";
            this.lblVerificaEntradas.Size = new System.Drawing.Size(687, 15);
            this.lblVerificaEntradas.TabIndex = 114;
            this.lblVerificaEntradas.Text = "label1";
            this.lblVerificaEntradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVerificaEntradas.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHomePage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 115;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHomePage
            // 
            this.menuHomePage.Name = "menuHomePage";
            this.menuHomePage.Size = new System.Drawing.Size(89, 20);
            this.menuHomePage.Text = "Página Inicial";
            this.menuHomePage.Click += new System.EventHandler(this.menuHomePage_Click);
            // 
            // frmDesligarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 338);
            this.Controls.Add(this.lblVerificaEntradas);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtDentistaCpfDesligar);
            this.Controls.Add(this.lblCroDentista);
            this.Controls.Add(this.txtCroDentistaDesligar);
            this.Controls.Add(this.btnDesligarDentista);
            this.Controls.Add(this.btnEncontrarDentista);
            this.Controls.Add(this.txtTelefoneDesligarDentista);
            this.Controls.Add(this.txtNomeDesligarDentista);
            this.Controls.Add(this.lblTelefoneDesligarDentista);
            this.Controls.Add(this.lblNomeDesligarDentista);
            this.Controls.Add(this.lblDesligarDentista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDesligarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desligar Dentista";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDesligarDentista;
        private Label lblNomeDesligarDentista;
        private Label lblTelefoneDesligarDentista;
        private TextBox txtNomeDesligarDentista;
        private TextBox txtTelefoneDesligarDentista;
        private Button btnEncontrarDentista;
        private Button btnDesligarDentista;
        private Label lblCPF;
        private TextBox txtDentistaCpfDesligar;
        private Label lblCroDentista;
        private TextBox txtCroDentistaDesligar;
        private Label lblVerificaEntradas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHomePage;
    }
}