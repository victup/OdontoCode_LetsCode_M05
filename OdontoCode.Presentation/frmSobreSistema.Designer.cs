namespace OdontoCode.Presentation
{
    partial class frmSobreSistema
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
            this.lblIntegrantesGrupo = new System.Windows.Forms.Label();
            this.txtIntegrante1 = new System.Windows.Forms.TextBox();
            this.txtIntegrante2 = new System.Windows.Forms.TextBox();
            this.txtIntegrante3 = new System.Windows.Forms.TextBox();
            this.lblNomeIntegrante1 = new System.Windows.Forms.Label();
            this.lblNomeIntegrante2 = new System.Windows.Forms.Label();
            this.lblNomeIntegrante3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntegrantesGrupo
            // 
            this.lblIntegrantesGrupo.AutoSize = true;
            this.lblIntegrantesGrupo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntegrantesGrupo.Location = new System.Drawing.Point(114, 20);
            this.lblIntegrantesGrupo.Name = "lblIntegrantesGrupo";
            this.lblIntegrantesGrupo.Size = new System.Drawing.Size(271, 37);
            this.lblIntegrantesGrupo.TabIndex = 18;
            this.lblIntegrantesGrupo.Text = "Integrantes do Grupo";
            // 
            // txtIntegrante1
            // 
            this.txtIntegrante1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante1.Enabled = false;
            this.txtIntegrante1.Location = new System.Drawing.Point(162, 104);
            this.txtIntegrante1.Name = "txtIntegrante1";
            this.txtIntegrante1.Size = new System.Drawing.Size(203, 23);
            this.txtIntegrante1.TabIndex = 19;
            this.txtIntegrante1.Text = "Lucas Henrique Pereira";
            // 
            // txtIntegrante2
            // 
            this.txtIntegrante2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante2.Enabled = false;
            this.txtIntegrante2.Location = new System.Drawing.Point(162, 173);
            this.txtIntegrante2.Name = "txtIntegrante2";
            this.txtIntegrante2.Size = new System.Drawing.Size(203, 23);
            this.txtIntegrante2.TabIndex = 20;
            this.txtIntegrante2.Text = "Marcella Roverato Pastore";
            // 
            // txtIntegrante3
            // 
            this.txtIntegrante3.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante3.Enabled = false;
            this.txtIntegrante3.Location = new System.Drawing.Point(162, 238);
            this.txtIntegrante3.Name = "txtIntegrante3";
            this.txtIntegrante3.Size = new System.Drawing.Size(203, 23);
            this.txtIntegrante3.TabIndex = 21;
            this.txtIntegrante3.Text = "Víctor Gonçalves dos Santos";
            // 
            // lblNomeIntegrante1
            // 
            this.lblNomeIntegrante1.AutoSize = true;
            this.lblNomeIntegrante1.Location = new System.Drawing.Point(162, 86);
            this.lblNomeIntegrante1.Name = "lblNomeIntegrante1";
            this.lblNomeIntegrante1.Size = new System.Drawing.Size(46, 15);
            this.lblNomeIntegrante1.TabIndex = 22;
            this.lblNomeIntegrante1.Text = "Nome :";
            // 
            // lblNomeIntegrante2
            // 
            this.lblNomeIntegrante2.AutoSize = true;
            this.lblNomeIntegrante2.Location = new System.Drawing.Point(162, 155);
            this.lblNomeIntegrante2.Name = "lblNomeIntegrante2";
            this.lblNomeIntegrante2.Size = new System.Drawing.Size(46, 15);
            this.lblNomeIntegrante2.TabIndex = 23;
            this.lblNomeIntegrante2.Text = "Nome :";
            // 
            // lblNomeIntegrante3
            // 
            this.lblNomeIntegrante3.AutoSize = true;
            this.lblNomeIntegrante3.Location = new System.Drawing.Point(162, 220);
            this.lblNomeIntegrante3.Name = "lblNomeIntegrante3";
            this.lblNomeIntegrante3.Size = new System.Drawing.Size(46, 15);
            this.lblNomeIntegrante3.TabIndex = 24;
            this.lblNomeIntegrante3.Text = "Nome :";
            this.lblNomeIntegrante3.Click += new System.EventHandler(this.lblNomeIntegrante3_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFechar.Location = new System.Drawing.Point(220, 282);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmSobreSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(501, 338);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblNomeIntegrante3);
            this.Controls.Add(this.lblNomeIntegrante2);
            this.Controls.Add(this.lblNomeIntegrante1);
            this.Controls.Add(this.txtIntegrante3);
            this.Controls.Add(this.txtIntegrante2);
            this.Controls.Add(this.txtIntegrante1);
            this.Controls.Add(this.lblIntegrantesGrupo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmSobreSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre o Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIntegrantesGrupo;
        private TextBox txtIntegrante1;
        private TextBox txtIntegrante2;
        private TextBox txtIntegrante3;
        private Label lblNomeIntegrante1;
        private Label lblNomeIntegrante2;
        private Label lblNomeIntegrante3;
        private Button btnFechar;
    }
}