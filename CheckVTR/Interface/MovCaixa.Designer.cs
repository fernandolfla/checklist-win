namespace CheckVTR.Interface
{
    partial class MovCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovCaixa));
            this.btnSaidas = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechaCaixa = new System.Windows.Forms.Button();
            this.txtValorCaixa = new System.Windows.Forms.TextBox();
            this.txtValorAbertura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.txtValorNotas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaidas
            // 
            this.btnSaidas.Enabled = false;
            this.btnSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidas.Location = new System.Drawing.Point(41, 26);
            this.btnSaidas.Name = "btnSaidas";
            this.btnSaidas.Size = new System.Drawing.Size(130, 80);
            this.btnSaidas.TabIndex = 0;
            this.btnSaidas.Text = "SAÍDAS";
            this.btnSaidas.UseVisualStyleBackColor = true;
            this.btnSaidas.Click += new System.EventHandler(this.btnSaidas_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Enabled = false;
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Location = new System.Drawing.Point(240, 26);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(130, 80);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "ENTRADAS";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtValorNotas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSangria);
            this.panel1.Controls.Add(this.btnAbrirCaixa);
            this.panel1.Controls.Add(this.txtSituacao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFechaCaixa);
            this.panel1.Controls.Add(this.txtValorCaixa);
            this.panel1.Controls.Add(this.txtValorAbertura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEntradas);
            this.panel1.Controls.Add(this.btnSaidas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 351);
            this.panel1.TabIndex = 2;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Enabled = false;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.Location = new System.Drawing.Point(460, 183);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(100, 60);
            this.btnAbrirCaixa.TabIndex = 9;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacao.Location = new System.Drawing.Point(196, 137);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(208, 29);
            this.txtSituacao.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Situação Caixa :";
            // 
            // btnFechaCaixa
            // 
            this.btnFechaCaixa.Enabled = false;
            this.btnFechaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaCaixa.Location = new System.Drawing.Point(460, 273);
            this.btnFechaCaixa.Name = "btnFechaCaixa";
            this.btnFechaCaixa.Size = new System.Drawing.Size(100, 60);
            this.btnFechaCaixa.TabIndex = 6;
            this.btnFechaCaixa.Text = "Fechar Caixa";
            this.btnFechaCaixa.UseVisualStyleBackColor = true;
            this.btnFechaCaixa.Click += new System.EventHandler(this.btnFechaCaixa_Click);
            // 
            // txtValorCaixa
            // 
            this.txtValorCaixa.Enabled = false;
            this.txtValorCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCaixa.ForeColor = System.Drawing.Color.Red;
            this.txtValorCaixa.Location = new System.Drawing.Point(196, 252);
            this.txtValorCaixa.Name = "txtValorCaixa";
            this.txtValorCaixa.Size = new System.Drawing.Size(208, 29);
            this.txtValorCaixa.TabIndex = 5;
            // 
            // txtValorAbertura
            // 
            this.txtValorAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAbertura.ForeColor = System.Drawing.Color.Red;
            this.txtValorAbertura.Location = new System.Drawing.Point(196, 194);
            this.txtValorAbertura.MaxLength = 12;
            this.txtValorAbertura.Name = "txtValorAbertura";
            this.txtValorAbertura.Size = new System.Drawing.Size(208, 29);
            this.txtValorAbertura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor em Caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Abertura";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(33, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAÍR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Enabled = false;
            this.btnSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSangria.Location = new System.Drawing.Point(430, 26);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(130, 80);
            this.btnSangria.TabIndex = 10;
            this.btnSangria.Text = "SANGRIA DE NOTAS";
            this.btnSangria.UseVisualStyleBackColor = true;
            // 
            // txtValorNotas
            // 
            this.txtValorNotas.Enabled = false;
            this.txtValorNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorNotas.ForeColor = System.Drawing.Color.Red;
            this.txtValorNotas.Location = new System.Drawing.Point(196, 306);
            this.txtValorNotas.Name = "txtValorNotas";
            this.txtValorNotas.Size = new System.Drawing.Size(208, 29);
            this.txtValorNotas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor em Notas";
            // 
            // MovCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MovCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTO DE CAIXA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaidas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCaixa;
        private System.Windows.Forms.TextBox txtValorAbertura;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFechaCaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.TextBox txtValorNotas;
        private System.Windows.Forms.Label label4;
    }
}