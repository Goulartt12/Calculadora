namespace Calculadora
{
    partial class Form1
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
            this.txtresultado = new System.Windows.Forms.MaskedTextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bL = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(15, 12);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(266, 20);
            this.txtresultado.TabIndex = 1;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtresultado.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Location = new System.Drawing.Point(23, 15);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 2;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(15, 48);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(49, 44);
            this.b7.TabIndex = 3;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(70, 48);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(49, 44);
            this.b8.TabIndex = 4;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button2_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(125, 48);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(49, 44);
            this.b9.TabIndex = 5;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bP
            // 
            this.bP.Location = new System.Drawing.Point(180, 48);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(49, 44);
            this.bP.TabIndex = 6;
            this.bP.Text = "+";
            this.bP.UseVisualStyleBackColor = true;
            this.bP.Click += new System.EventHandler(this.bP_Click);
            // 
            // ce
            // 
            this.ce.Location = new System.Drawing.Point(235, 48);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(49, 44);
            this.ce.TabIndex = 7;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(15, 98);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(49, 44);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(70, 98);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(49, 44);
            this.b5.TabIndex = 9;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button7_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(125, 98);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(49, 44);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bL
            // 
            this.bL.Location = new System.Drawing.Point(180, 98);
            this.bL.Name = "bL";
            this.bL.Size = new System.Drawing.Size(49, 44);
            this.bL.TabIndex = 11;
            this.bL.Text = "-";
            this.bL.UseVisualStyleBackColor = true;
            this.bL.Click += new System.EventHandler(this.bL_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(235, 98);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(49, 44);
            this.c.TabIndex = 12;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(15, 148);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(49, 44);
            this.b1.TabIndex = 13;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button11_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(70, 148);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(49, 44);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(125, 148);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(49, 44);
            this.b3.TabIndex = 15;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button13_Click);
            // 
            // bM
            // 
            this.bM.Location = new System.Drawing.Point(180, 148);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(49, 44);
            this.bM.TabIndex = 16;
            this.bM.Text = "x";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(15, 198);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(104, 44);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button16_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(125, 198);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(49, 44);
            this.dot.TabIndex = 20;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(180, 198);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(49, 44);
            this.bD.TabIndex = 21;
            this.bD.Text = "÷";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.button19_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(235, 148);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(49, 94);
            this.result.TabIndex = 22;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(305, 275);
            this.Controls.Add(this.result);
            this.Controls.Add(this.bD);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bM);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.bL);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.bP);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtresultado);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtresultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bP;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bL;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button result;
    }
}

