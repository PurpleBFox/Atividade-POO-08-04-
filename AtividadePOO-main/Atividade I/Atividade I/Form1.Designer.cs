namespace Atividade_I
{
    partial class frmsalarios
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorDeVendas = new System.Windows.Forms.TextBox();
            this.txtCarrosVendidos = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalarioPorc = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(12, 9);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(225, 33);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "Infome seus dados";
            this.lblText1.Click += new System.EventHandler(this.lblText1_Click);
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(187, 67);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(314, 20);
            this.txtSalarioFixo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Infome seu salário:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(233, 369);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 57);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(42, 369);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 57);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor total de suas vendas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informe sua comissão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Infome quantidade de carros vendidos:";
            // 
            // txtValorDeVendas
            // 
            this.txtValorDeVendas.Location = new System.Drawing.Point(251, 103);
            this.txtValorDeVendas.Name = "txtValorDeVendas";
            this.txtValorDeVendas.Size = new System.Drawing.Size(250, 20);
            this.txtValorDeVendas.TabIndex = 11;
            // 
            // txtCarrosVendidos
            // 
            this.txtCarrosVendidos.Location = new System.Drawing.Point(349, 141);
            this.txtCarrosVendidos.Name = "txtCarrosVendidos";
            this.txtCarrosVendidos.Size = new System.Drawing.Size(154, 20);
            this.txtCarrosVendidos.TabIndex = 12;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(220, 180);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(283, 20);
            this.txtComissao.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seu salário final :  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(700, 66);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.ReadOnly = true;
            this.txtSalarioFinal.Size = new System.Drawing.Size(187, 20);
            this.txtSalarioFinal.TabIndex = 17;
            this.txtSalarioFinal.TextChanged += new System.EventHandler(this.txtSalarioFinal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "5% do total de carros vendidos:";
            // 
            // txtSalarioPorc
            // 
            this.txtSalarioPorc.Location = new System.Drawing.Point(291, 224);
            this.txtSalarioPorc.Name = "txtSalarioPorc";
            this.txtSalarioPorc.Size = new System.Drawing.Size(210, 20);
            this.txtSalarioPorc.TabIndex = 19;
            this.txtSalarioPorc.TextChanged += new System.EventHandler(this.txtSalarioPorc_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(736, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(139, 57);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtSalarioPorc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.txtCarrosVendidos);
            this.Controls.Add(this.txtValorDeVendas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.lblText1);
            this.Name = "frmsalarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Salarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorDeVendas;
        private System.Windows.Forms.TextBox txtCarrosVendidos;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalarioPorc;
        private System.Windows.Forms.Button btnVoltar;
    }
}

