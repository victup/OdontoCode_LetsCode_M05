namespace OdontoCode.Presentation
{
    partial class frmSairSistema
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
            this.lblSairSistema = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSairSistema
            // 
            this.lblSairSistema.AutoSize = true;
            this.lblSairSistema.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSairSistema.Location = new System.Drawing.Point(73, 30);
            this.lblSairSistema.Name = "lblSairSistema";
            this.lblSairSistema.Size = new System.Drawing.Size(350, 30);
            this.lblSairSistema.TabIndex = 0;
            this.lblSairSistema.Text = "Você deseja mesmo sair do sistema?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.Location = new System.Drawing.Point(128, 121);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 50);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Sim";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.Location = new System.Drawing.Point(268, 121);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 50);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Não";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // frmSairSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(497, 263);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblSairSistema);
            this.MaximizeBox = false;
            this.Name = "frmSairSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSairSistema;
        private Button btnYes;
        private Button btnNo;
    }
}