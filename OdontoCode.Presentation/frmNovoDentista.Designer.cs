﻿namespace OdontoCode.Presentation
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
            this.btnCadastrarDentista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(119, 176);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(482, 27);
            this.txtNomeDentista.TabIndex = 0;
            // 
            // txtCroDentista
            // 
            this.txtCroDentista.Location = new System.Drawing.Point(119, 260);
            this.txtCroDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCroDentista.Name = "txtCroDentista";
            this.txtCroDentista.Size = new System.Drawing.Size(217, 27);
            this.txtCroDentista.TabIndex = 1;
            // 
            // txtTelDentista
            // 
            this.txtTelDentista.Location = new System.Drawing.Point(415, 264);
            this.txtTelDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelDentista.Name = "txtTelDentista";
            this.txtTelDentista.Size = new System.Drawing.Size(186, 27);
            this.txtTelDentista.TabIndex = 2;
            // 
            // lblNomeDentista
            // 
            this.lblNomeDentista.AutoSize = true;
            this.lblNomeDentista.Location = new System.Drawing.Point(119, 152);
            this.lblNomeDentista.Name = "lblNomeDentista";
            this.lblNomeDentista.Size = new System.Drawing.Size(57, 20);
            this.lblNomeDentista.TabIndex = 3;
            this.lblNomeDentista.Text = "Nome :";
            // 
            // lblCroDentista
            // 
            this.lblCroDentista.AutoSize = true;
            this.lblCroDentista.Location = new System.Drawing.Point(119, 236);
            this.lblCroDentista.Name = "lblCroDentista";
            this.lblCroDentista.Size = new System.Drawing.Size(45, 20);
            this.lblCroDentista.TabIndex = 4;
            this.lblCroDentista.Text = "CRO :";
            // 
            // lblTelDentista
            // 
            this.lblTelDentista.AutoSize = true;
            this.lblTelDentista.Location = new System.Drawing.Point(415, 240);
            this.lblTelDentista.Name = "lblTelDentista";
            this.lblTelDentista.Size = new System.Drawing.Size(73, 20);
            this.lblTelDentista.TabIndex = 5;
            this.lblTelDentista.Text = "Telefone :";
            // 
            // lblNovoDentista
            // 
            this.lblNovoDentista.AutoSize = true;
            this.lblNovoDentista.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoDentista.Location = new System.Drawing.Point(130, 51);
            this.lblNovoDentista.Name = "lblNovoDentista";
            this.lblNovoDentista.Size = new System.Drawing.Size(376, 46);
            this.lblNovoDentista.TabIndex = 6;
            this.lblNovoDentista.Text = "Cadastro Novo Dentista";
            // 
            // btnCadastrarDentista
            // 
            this.btnCadastrarDentista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrarDentista.Location = new System.Drawing.Point(225, 368);
            this.btnCadastrarDentista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarDentista.Name = "btnCadastrarDentista";
            this.btnCadastrarDentista.Size = new System.Drawing.Size(219, 44);
            this.btnCadastrarDentista.TabIndex = 35;
            this.btnCadastrarDentista.Text = "Cadastrar Dentista";
            this.btnCadastrarDentista.UseVisualStyleBackColor = false;
            this.btnCadastrarDentista.Visible = false;
            // 
            // frmNovoDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 508);
            this.Controls.Add(this.btnCadastrarDentista);
            this.Controls.Add(this.lblNovoDentista);
            this.Controls.Add(this.lblTelDentista);
            this.Controls.Add(this.lblCroDentista);
            this.Controls.Add(this.lblNomeDentista);
            this.Controls.Add(this.txtTelDentista);
            this.Controls.Add(this.txtCroDentista);
            this.Controls.Add(this.txtNomeDentista);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmNovoDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Dentista";
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
        private Button btnCadastrarDentista;
    }
}