
namespace exercicio3
{
    partial class Form1
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
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.lblMenorValorFat = new System.Windows.Forms.Label();
            this.lblMostraMenorValor = new System.Windows.Forms.Label();
            this.lblMaiorValorFat = new System.Windows.Forms.Label();
            this.lblMostraMaiorValorFat = new System.Windows.Forms.Label();
            this.lblQtdeDiasFatur = new System.Windows.Forms.Label();
            this.lblMostraQtdeDias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(47, 29);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalisar.TabIndex = 0;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // lblMenorValorFat
            // 
            this.lblMenorValorFat.AutoSize = true;
            this.lblMenorValorFat.Location = new System.Drawing.Point(17, 69);
            this.lblMenorValorFat.Name = "lblMenorValorFat";
            this.lblMenorValorFat.Size = new System.Drawing.Size(108, 13);
            this.lblMenorValorFat.TabIndex = 2;
            this.lblMenorValorFat.Text = "Menor valor faturado:";
            // 
            // lblMostraMenorValor
            // 
            this.lblMostraMenorValor.AutoSize = true;
            this.lblMostraMenorValor.Location = new System.Drawing.Point(146, 69);
            this.lblMostraMenorValor.Name = "lblMostraMenorValor";
            this.lblMostraMenorValor.Size = new System.Drawing.Size(35, 13);
            this.lblMostraMenorValor.TabIndex = 3;
            this.lblMostraMenorValor.Text = "label3";
            this.lblMostraMenorValor.Visible = false;
            // 
            // lblMaiorValorFat
            // 
            this.lblMaiorValorFat.AutoSize = true;
            this.lblMaiorValorFat.Location = new System.Drawing.Point(17, 99);
            this.lblMaiorValorFat.Name = "lblMaiorValorFat";
            this.lblMaiorValorFat.Size = new System.Drawing.Size(105, 13);
            this.lblMaiorValorFat.TabIndex = 4;
            this.lblMaiorValorFat.Text = "Maior Valor faturado:";
            // 
            // lblMostraMaiorValorFat
            // 
            this.lblMostraMaiorValorFat.AutoSize = true;
            this.lblMostraMaiorValorFat.Location = new System.Drawing.Point(146, 99);
            this.lblMostraMaiorValorFat.Name = "lblMostraMaiorValorFat";
            this.lblMostraMaiorValorFat.Size = new System.Drawing.Size(35, 13);
            this.lblMostraMaiorValorFat.TabIndex = 5;
            this.lblMostraMaiorValorFat.Text = "label5";
            this.lblMostraMaiorValorFat.Visible = false;
            // 
            // lblQtdeDiasFatur
            // 
            this.lblQtdeDiasFatur.AutoSize = true;
            this.lblQtdeDiasFatur.Location = new System.Drawing.Point(17, 128);
            this.lblQtdeDiasFatur.Name = "lblQtdeDiasFatur";
            this.lblQtdeDiasFatur.Size = new System.Drawing.Size(294, 13);
            this.lblQtdeDiasFatur.TabIndex = 6;
            this.lblQtdeDiasFatur.Text = "Quantidade de dias que o faturamento foi maior que a média;";
            // 
            // lblMostraQtdeDias
            // 
            this.lblMostraQtdeDias.AutoSize = true;
            this.lblMostraQtdeDias.Location = new System.Drawing.Point(317, 128);
            this.lblMostraQtdeDias.Name = "lblMostraQtdeDias";
            this.lblMostraQtdeDias.Size = new System.Drawing.Size(35, 13);
            this.lblMostraQtdeDias.TabIndex = 7;
            this.lblMostraQtdeDias.Text = "label7";
            this.lblMostraQtdeDias.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMenorValorFat);
            this.groupBox1.Controls.Add(this.btnAnalisar);
            this.groupBox1.Controls.Add(this.lblMostraQtdeDias);
            this.groupBox1.Controls.Add(this.lblQtdeDiasFatur);
            this.groupBox1.Controls.Add(this.lblMostraMenorValor);
            this.groupBox1.Controls.Add(this.lblMostraMaiorValorFat);
            this.groupBox1.Controls.Add(this.lblMaiorValorFat);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analise de Faturamento Mensal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 252);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label lblMenorValorFat;
        private System.Windows.Forms.Label lblMostraMenorValor;
        private System.Windows.Forms.Label lblMaiorValorFat;
        private System.Windows.Forms.Label lblMostraMaiorValorFat;
        private System.Windows.Forms.Label lblQtdeDiasFatur;
        private System.Windows.Forms.Label lblMostraQtdeDias;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

