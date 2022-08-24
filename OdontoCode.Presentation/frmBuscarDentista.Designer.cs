namespace OdontoCode.Presentation
{
    partial class frmBuscarDentista
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
            this.lblNomeBuscarDentista = new System.Windows.Forms.Label();
            this.lblTelefoneBuscarDentista = new System.Windows.Forms.Label();
            this.txtNomeBuscarDentista = new System.Windows.Forms.TextBox();
            this.txtTelefoneBuscarDentista = new System.Windows.Forms.TextBox();
            this.btnEncontrarDentista = new System.Windows.Forms.Button();
            this.lblBuscarDentista = new System.Windows.Forms.Label();
            this.btnLimparDentista = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDentistaCpfBuscar = new System.Windows.Forms.TextBox();
            this.lblCroDentista = new System.Windows.Forms.Label();
            this.txtCroDentistaBuscar = new System.Windows.Forms.TextBox();
            this.lblVerificaEntradas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeBuscarDentista
            // 
            this.lblNomeBuscarDentista.AutoSize = true;
            this.lblNomeBuscarDentista.Location = new System.Drawing.Point(111, 77);
            this.lblNomeBuscarDentista.Name = "lblNomeBuscarDentista";
            this.lblNomeBuscarDentista.Size = new System.Drawing.Size(46, 15);
            this.lblNomeBuscarDentista.TabIndex = 0;
            this.lblNomeBuscarDentista.Text = "Nome :";
            // 
            // lblTelefoneBuscarDentista
            // 
            this.lblTelefoneBuscarDentista.AutoSize = true;
            this.lblTelefoneBuscarDentista.Location = new System.Drawing.Point(363, 132);
            this.lblTelefoneBuscarDentista.Name = "lblTelefoneBuscarDentista";
            this.lblTelefoneBuscarDentista.Size = new System.Drawing.Size(57, 15);
            this.lblTelefoneBuscarDentista.TabIndex = 2;
            this.lblTelefoneBuscarDentista.Text = "Telefone :";
            this.lblTelefoneBuscarDentista.Visible = false;
            // 
            // txtNomeBuscarDentista
            // 
            this.txtNomeBuscarDentista.Location = new System.Drawing.Point(111, 94);
            this.txtNomeBuscarDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeBuscarDentista.Name = "txtNomeBuscarDentista";
            this.txtNomeBuscarDentista.Size = new System.Drawing.Size(445, 23);
            this.txtNomeBuscarDentista.TabIndex = 1;
            // 
            // txtTelefoneBuscarDentista
            // 
            this.txtTelefoneBuscarDentista.Location = new System.Drawing.Point(365, 149);
            this.txtTelefoneBuscarDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefoneBuscarDentista.Name = "txtTelefoneBuscarDentista";
            this.txtTelefoneBuscarDentista.Size = new System.Drawing.Size(191, 23);
            this.txtTelefoneBuscarDentista.TabIndex = 4;
            this.txtTelefoneBuscarDentista.Visible = false;
            // 
            // btnEncontrarDentista
            // 
            this.btnEncontrarDentista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarDentista.Location = new System.Drawing.Point(590, 93);
            this.btnEncontrarDentista.Name = "btnEncontrarDentista";
            this.btnEncontrarDentista.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrarDentista.TabIndex = 99;
            this.btnEncontrarDentista.Text = "Buscar";
            this.btnEncontrarDentista.UseVisualStyleBackColor = false;
            this.btnEncontrarDentista.Click += new System.EventHandler(this.btnEncontrarDentista_Click);
            // 
            // lblBuscarDentista
            // 
            this.lblBuscarDentista.AutoSize = true;
            this.lblBuscarDentista.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarDentista.Location = new System.Drawing.Point(214, 21);
            this.lblBuscarDentista.Name = "lblBuscarDentista";
            this.lblBuscarDentista.Size = new System.Drawing.Size(198, 37);
            this.lblBuscarDentista.TabIndex = 100;
            this.lblBuscarDentista.Text = "Buscar Dentista";
            // 
            // btnLimparDentista
            // 
            this.btnLimparDentista.BackColor = System.Drawing.Color.Gold;
            this.btnLimparDentista.Location = new System.Drawing.Point(590, 94);
            this.btnLimparDentista.Name = "btnLimparDentista";
            this.btnLimparDentista.Size = new System.Drawing.Size(75, 23);
            this.btnLimparDentista.TabIndex = 5;
            this.btnLimparDentista.Text = "Limpar";
            this.btnLimparDentista.UseVisualStyleBackColor = false;
            this.btnLimparDentista.Visible = false;
            this.btnLimparDentista.Click += new System.EventHandler(this.btnLimparDentista_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(111, 131);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 15);
            this.lblCPF.TabIndex = 105;
            this.lblCPF.Text = "CPF :";
            // 
            // txtDentistaCpfBuscar
            // 
            this.txtDentistaCpfBuscar.Location = new System.Drawing.Point(111, 149);
            this.txtDentistaCpfBuscar.Name = "txtDentistaCpfBuscar";
            this.txtDentistaCpfBuscar.Size = new System.Drawing.Size(114, 23);
            this.txtDentistaCpfBuscar.TabIndex = 2;
            // 
            // lblCroDentista
            // 
            this.lblCroDentista.AutoSize = true;
            this.lblCroDentista.Location = new System.Drawing.Point(240, 131);
            this.lblCroDentista.Name = "lblCroDentista";
            this.lblCroDentista.Size = new System.Drawing.Size(37, 15);
            this.lblCroDentista.TabIndex = 103;
            this.lblCroDentista.Text = "CRO :";
            // 
            // txtCroDentistaBuscar
            // 
            this.txtCroDentistaBuscar.Location = new System.Drawing.Point(240, 149);
            this.txtCroDentistaBuscar.Name = "txtCroDentistaBuscar";
            this.txtCroDentistaBuscar.Size = new System.Drawing.Size(114, 23);
            this.txtCroDentistaBuscar.TabIndex = 3;
            // 
            // lblVerificaEntradas
            // 
            this.lblVerificaEntradas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVerificaEntradas.Location = new System.Drawing.Point(1, 193);
            this.lblVerificaEntradas.Name = "lblVerificaEntradas";
            this.lblVerificaEntradas.Size = new System.Drawing.Size(687, 15);
            this.lblVerificaEntradas.TabIndex = 106;
            this.lblVerificaEntradas.Text = "label1";
            this.lblVerificaEntradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVerificaEntradas.Visible = false;
            // 
            // frmBuscarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lblVerificaEntradas);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtDentistaCpfBuscar);
            this.Controls.Add(this.lblCroDentista);
            this.Controls.Add(this.txtCroDentistaBuscar);
            this.Controls.Add(this.btnLimparDentista);
            this.Controls.Add(this.lblBuscarDentista);
            this.Controls.Add(this.btnEncontrarDentista);
            this.Controls.Add(this.txtTelefoneBuscarDentista);
            this.Controls.Add(this.txtNomeBuscarDentista);
            this.Controls.Add(this.lblTelefoneBuscarDentista);
            this.Controls.Add(this.lblNomeBuscarDentista);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBuscarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Dentista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeBuscarDentista;
        private Label lblTelefoneBuscarDentista;
        private TextBox txtNomeBuscarDentista;
        private TextBox txtTelefoneBuscarDentista;
        private Button btnEncontrarDentista;
        private Label lblBuscarDentista;
        private Button btnLimparDentista;
        private Label lblCPF;
        private TextBox txtDentistaCpfBuscar;
        private Label lblCroDentista;
        private TextBox txtCroDentistaBuscar;
        private Label lblVerificaEntradas;
    }
}