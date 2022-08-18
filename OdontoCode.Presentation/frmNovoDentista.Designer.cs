namespace OdontoCode.Presentation
{
    partial class frmNovoDentista
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
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtCroDentista = new System.Windows.Forms.TextBox();
            this.txtTelDentista = new System.Windows.Forms.TextBox();
            this.lblNomeDentista = new System.Windows.Forms.Label();
            this.lblCroDentista = new System.Windows.Forms.Label();
            this.lblTelDentista = new System.Windows.Forms.Label();
            this.lblNovoDentista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(196, 155);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(422, 23);
            this.txtNomeDentista.TabIndex = 0;
            this.txtNomeDentista.TextChanged += new System.EventHandler(this.txtNomeDentista_TextChanged);
            // 
            // txtCroDentista
            // 
            this.txtCroDentista.Location = new System.Drawing.Point(196, 218);
            this.txtCroDentista.Name = "txtCroDentista";
            this.txtCroDentista.Size = new System.Drawing.Size(422, 23);
            this.txtCroDentista.TabIndex = 1;
            this.txtCroDentista.TextChanged += new System.EventHandler(this.txtCroDentista_TextChanged);
            // 
            // txtTelDentista
            // 
            this.txtTelDentista.Location = new System.Drawing.Point(196, 276);
            this.txtTelDentista.Name = "txtTelDentista";
            this.txtTelDentista.Size = new System.Drawing.Size(422, 23);
            this.txtTelDentista.TabIndex = 2;
            this.txtTelDentista.TextChanged += new System.EventHandler(this.txtTelDentista_TextChanged);
            // 
            // lblNomeDentista
            // 
            this.lblNomeDentista.AutoSize = true;
            this.lblNomeDentista.Location = new System.Drawing.Point(133, 158);
            this.lblNomeDentista.Name = "lblNomeDentista";
            this.lblNomeDentista.Size = new System.Drawing.Size(46, 15);
            this.lblNomeDentista.TabIndex = 3;
            this.lblNomeDentista.Text = "Nome :";
            // 
            // lblCroDentista
            // 
            this.lblCroDentista.AutoSize = true;
            this.lblCroDentista.Location = new System.Drawing.Point(133, 221);
            this.lblCroDentista.Name = "lblCroDentista";
            this.lblCroDentista.Size = new System.Drawing.Size(37, 15);
            this.lblCroDentista.TabIndex = 4;
            this.lblCroDentista.Text = "CRO :";
            // 
            // lblTelDentista
            // 
            this.lblTelDentista.AutoSize = true;
            this.lblTelDentista.Location = new System.Drawing.Point(133, 279);
            this.lblTelDentista.Name = "lblTelDentista";
            this.lblTelDentista.Size = new System.Drawing.Size(57, 15);
            this.lblTelDentista.TabIndex = 5;
            this.lblTelDentista.Text = "Telefone :";
            // 
            // lblNovoDentista
            // 
            this.lblNovoDentista.AutoSize = true;
            this.lblNovoDentista.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoDentista.Location = new System.Drawing.Point(239, 48);
            this.lblNovoDentista.Name = "lblNovoDentista";
            this.lblNovoDentista.Size = new System.Drawing.Size(300, 37);
            this.lblNovoDentista.TabIndex = 6;
            this.lblNovoDentista.Text = "Cadastro Novo Dentista";
            // 
            // frmNovoDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNovoDentista);
            this.Controls.Add(this.lblTelDentista);
            this.Controls.Add(this.lblCroDentista);
            this.Controls.Add(this.lblNomeDentista);
            this.Controls.Add(this.txtTelDentista);
            this.Controls.Add(this.txtCroDentista);
            this.Controls.Add(this.txtNomeDentista);
            this.Name = "frmNovoDentista";
            this.Text = "frmNovoDentista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomeDentista;
        private TextBox txtCroDentista;
        private TextBox txtTelDentista;
        private Label lblNomeDentista;
        private Label lblCroDentista;
        private Label lblTelDentista;
        private Label lblNovoDentista;
    }
}