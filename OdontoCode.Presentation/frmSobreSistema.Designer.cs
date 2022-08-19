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
            this.lblIntegrantesGrupo.Location = new System.Drawing.Point(130, 26);
            this.lblIntegrantesGrupo.Name = "lblIntegrantesGrupo";
            this.lblIntegrantesGrupo.Size = new System.Drawing.Size(342, 46);
            this.lblIntegrantesGrupo.TabIndex = 18;
            this.lblIntegrantesGrupo.Text = "Integrantes do Grupo";
            // 
            // txtIntegrante1
            // 
            this.txtIntegrante1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante1.Location = new System.Drawing.Point(185, 138);
            this.txtIntegrante1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntegrante1.Name = "txtIntegrante1";
            this.txtIntegrante1.Size = new System.Drawing.Size(231, 27);
            this.txtIntegrante1.TabIndex = 19;
            this.txtIntegrante1.Text = "Lucas Henrique Pereira";
            // 
            // txtIntegrante2
            // 
            this.txtIntegrante2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante2.Location = new System.Drawing.Point(185, 231);
            this.txtIntegrante2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntegrante2.Name = "txtIntegrante2";
            this.txtIntegrante2.Size = new System.Drawing.Size(231, 27);
            this.txtIntegrante2.TabIndex = 20;
            this.txtIntegrante2.Text = "Marcella Roverato Pastore";
            // 
            // txtIntegrante3
            // 
            this.txtIntegrante3.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntegrante3.Location = new System.Drawing.Point(185, 318);
            this.txtIntegrante3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntegrante3.Name = "txtIntegrante3";
            this.txtIntegrante3.Size = new System.Drawing.Size(231, 27);
            this.txtIntegrante3.TabIndex = 21;
            this.txtIntegrante3.Text = "Víctor Gonçalves dos Santos";
            // 
            // lblNomeIntegrante1
            // 
            this.lblNomeIntegrante1.AutoSize = true;
            this.lblNomeIntegrante1.Location = new System.Drawing.Point(185, 114);
            this.lblNomeIntegrante1.Name = "lblNomeIntegrante1";
            this.lblNomeIntegrante1.Size = new System.Drawing.Size(57, 20);
            this.lblNomeIntegrante1.TabIndex = 22;
            this.lblNomeIntegrante1.Text = "Nome :";
            // 
            // lblNomeIntegrante2
            // 
            this.lblNomeIntegrante2.AutoSize = true;
            this.lblNomeIntegrante2.Location = new System.Drawing.Point(185, 207);
            this.lblNomeIntegrante2.Name = "lblNomeIntegrante2";
            this.lblNomeIntegrante2.Size = new System.Drawing.Size(57, 20);
            this.lblNomeIntegrante2.TabIndex = 23;
            this.lblNomeIntegrante2.Text = "Nome :";
            // 
            // lblNomeIntegrante3
            // 
            this.lblNomeIntegrante3.AutoSize = true;
            this.lblNomeIntegrante3.Location = new System.Drawing.Point(185, 294);
            this.lblNomeIntegrante3.Name = "lblNomeIntegrante3";
            this.lblNomeIntegrante3.Size = new System.Drawing.Size(57, 20);
            this.lblNomeIntegrante3.TabIndex = 24;
            this.lblNomeIntegrante3.Text = "Nome :";
            this.lblNomeIntegrante3.Click += new System.EventHandler(this.lblNomeIntegrante3_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnFechar.Location = new System.Drawing.Point(248, 392);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 31);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // frmSobreSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblNomeIntegrante3);
            this.Controls.Add(this.lblNomeIntegrante2);
            this.Controls.Add(this.lblNomeIntegrante1);
            this.Controls.Add(this.txtIntegrante3);
            this.Controls.Add(this.txtIntegrante2);
            this.Controls.Add(this.txtIntegrante1);
            this.Controls.Add(this.lblIntegrantesGrupo);
            this.Name = "frmSobreSistema";
            this.Text = "frmSobreSistema";
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