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
            this.lblCroBuscarDentista = new System.Windows.Forms.Label();
            this.lblTelefoneBuscarDentista = new System.Windows.Forms.Label();
            this.txtNomeBuscarDentista = new System.Windows.Forms.TextBox();
            this.txtCroBuscarDentista = new System.Windows.Forms.TextBox();
            this.txtTelefoneBuscarDentista = new System.Windows.Forms.TextBox();
            this.btnEncontrarDentista = new System.Windows.Forms.Button();
            this.lblBuscarDentista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeBuscarDentista
            // 
            this.lblNomeBuscarDentista.AutoSize = true;
            this.lblNomeBuscarDentista.Location = new System.Drawing.Point(127, 103);
            this.lblNomeBuscarDentista.Name = "lblNomeBuscarDentista";
            this.lblNomeBuscarDentista.Size = new System.Drawing.Size(57, 20);
            this.lblNomeBuscarDentista.TabIndex = 0;
            this.lblNomeBuscarDentista.Text = "Nome :";
            // 
            // lblCroBuscarDentista
            // 
            this.lblCroBuscarDentista.AutoSize = true;
            this.lblCroBuscarDentista.Location = new System.Drawing.Point(127, 177);
            this.lblCroBuscarDentista.Name = "lblCroBuscarDentista";
            this.lblCroBuscarDentista.Size = new System.Drawing.Size(45, 20);
            this.lblCroBuscarDentista.TabIndex = 1;
            this.lblCroBuscarDentista.Text = "CRO :";
            // 
            // lblTelefoneBuscarDentista
            // 
            this.lblTelefoneBuscarDentista.AutoSize = true;
            this.lblTelefoneBuscarDentista.Location = new System.Drawing.Point(415, 176);
            this.lblTelefoneBuscarDentista.Name = "lblTelefoneBuscarDentista";
            this.lblTelefoneBuscarDentista.Size = new System.Drawing.Size(73, 20);
            this.lblTelefoneBuscarDentista.TabIndex = 2;
            this.lblTelefoneBuscarDentista.Text = "Telefone :";
            // 
            // txtNomeBuscarDentista
            // 
            this.txtNomeBuscarDentista.Location = new System.Drawing.Point(127, 126);
            this.txtNomeBuscarDentista.Name = "txtNomeBuscarDentista";
            this.txtNomeBuscarDentista.Size = new System.Drawing.Size(508, 27);
            this.txtNomeBuscarDentista.TabIndex = 3;
            // 
            // txtCroBuscarDentista
            // 
            this.txtCroBuscarDentista.Location = new System.Drawing.Point(127, 200);
            this.txtCroBuscarDentista.Name = "txtCroBuscarDentista";
            this.txtCroBuscarDentista.Size = new System.Drawing.Size(196, 27);
            this.txtCroBuscarDentista.TabIndex = 4;
            // 
            // txtTelefoneBuscarDentista
            // 
            this.txtTelefoneBuscarDentista.Location = new System.Drawing.Point(417, 199);
            this.txtTelefoneBuscarDentista.Name = "txtTelefoneBuscarDentista";
            this.txtTelefoneBuscarDentista.Size = new System.Drawing.Size(218, 27);
            this.txtTelefoneBuscarDentista.TabIndex = 6;
            // 
            // btnEncontrarDentista
            // 
            this.btnEncontrarDentista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEncontrarDentista.Location = new System.Drawing.Point(674, 124);
            this.btnEncontrarDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncontrarDentista.Name = "btnEncontrarDentista";
            this.btnEncontrarDentista.Size = new System.Drawing.Size(86, 31);
            this.btnEncontrarDentista.TabIndex = 99;
            this.btnEncontrarDentista.Text = "Buscar";
            this.btnEncontrarDentista.UseVisualStyleBackColor = false;
            // 
            // lblBuscarDentista
            // 
            this.lblBuscarDentista.AutoSize = true;
            this.lblBuscarDentista.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarDentista.Location = new System.Drawing.Point(244, 28);
            this.lblBuscarDentista.Name = "lblBuscarDentista";
            this.lblBuscarDentista.Size = new System.Drawing.Size(244, 45);
            this.lblBuscarDentista.TabIndex = 100;
            this.lblBuscarDentista.Text = "Buscar Dentista";
            // 
            // frmBuscarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscarDentista);
            this.Controls.Add(this.btnEncontrarDentista);
            this.Controls.Add(this.txtTelefoneBuscarDentista);
            this.Controls.Add(this.txtCroBuscarDentista);
            this.Controls.Add(this.txtNomeBuscarDentista);
            this.Controls.Add(this.lblTelefoneBuscarDentista);
            this.Controls.Add(this.lblCroBuscarDentista);
            this.Controls.Add(this.lblNomeBuscarDentista);
            this.Name = "frmBuscarDentista";
            this.Text = "frmBuscarDentista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeBuscarDentista;
        private Label lblCroBuscarDentista;
        private Label lblTelefoneBuscarDentista;
        private TextBox txtNomeBuscarDentista;
        private TextBox txtCroBuscarDentista;
        private TextBox txtTelefoneBuscarDentista;
        private Button btnEncontrarDentista;
        private Label lblBuscarDentista;
    }
}