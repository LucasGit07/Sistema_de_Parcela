namespace MeuSistema
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtParc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textParc2 = new System.Windows.Forms.TextBox();
            this.Btnresultado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtParc1
            // 
            this.txtParc1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtParc1.Location = new System.Drawing.Point(180, 121);
            this.txtParc1.Name = "txtParc1";
            this.txtParc1.Size = new System.Drawing.Size(212, 22);
            this.txtParc1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero de Parcelas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor:";
            // 
            // textParc2
            // 
            this.textParc2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textParc2.Location = new System.Drawing.Point(180, 149);
            this.textParc2.Name = "textParc2";
            this.textParc2.Size = new System.Drawing.Size(212, 22);
            this.textParc2.TabIndex = 15;
            // 
            // Btnresultado
            // 
            this.Btnresultado.Location = new System.Drawing.Point(180, 252);
            this.Btnresultado.Name = "Btnresultado";
            this.Btnresultado.Size = new System.Drawing.Size(79, 32);
            this.Btnresultado.TabIndex = 17;
            this.Btnresultado.Text = "Calcular";
            this.Btnresultado.UseVisualStyleBackColor = true;
            this.Btnresultado.Click += new System.EventHandler(this.Btnresultado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total";
            // 
            // txtRes
            // 
            this.txtRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRes.Location = new System.Drawing.Point(180, 198);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(173, 22);
            this.txtRes.TabIndex = 18;
            this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(437, 411);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(79, 32);
            this.BtnSair.TabIndex = 20;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 455);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.Btnresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textParc2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParc1);
            this.Name = "form1";
            this.Text = "Sistema de Parcela";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtParc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textParc2;
        private System.Windows.Forms.Button Btnresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button BtnSair;
    }
}

