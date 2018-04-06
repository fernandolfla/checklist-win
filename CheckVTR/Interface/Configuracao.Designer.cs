namespace CheckVTR.Interface
{
    partial class Configuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracao));
            this.panelRodape = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRaz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtdVeiculos = new System.Windows.Forms.MaskedTextBox();
            this.txtQtdAreas = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.panelRodape.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRodape
            // 
            this.panelRodape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRodape.Controls.Add(this.btnSalvar);
            this.panelRodape.Location = new System.Drawing.Point(12, 295);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(560, 50);
            this.panelRodape.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.txtResponsavel);
            this.panelFundo.Controls.Add(this.txtEndereco);
            this.panelFundo.Controls.Add(this.txtFantasia);
            this.panelFundo.Controls.Add(this.txtRazao);
            this.panelFundo.Controls.Add(this.txtQtdAreas);
            this.panelFundo.Controls.Add(this.txtQtdVeiculos);
            this.panelFundo.Controls.Add(this.label8);
            this.panelFundo.Controls.Add(this.label7);
            this.panelFundo.Controls.Add(this.txtTelefone);
            this.panelFundo.Controls.Add(this.txtNumero);
            this.panelFundo.Controls.Add(this.txtCNPJ);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.label6);
            this.panelFundo.Controls.Add(this.label5);
            this.panelFundo.Controls.Add(this.label4);
            this.panelFundo.Controls.Add(this.label3);
            this.panelFundo.Controls.Add(this.label2);
            this.panelFundo.Controls.Add(this.labelRaz);
            this.panelFundo.Location = new System.Drawing.Point(12, 15);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(560, 275);
            this.panelFundo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fantasia";
            // 
            // labelRaz
            // 
            this.labelRaz.AutoSize = true;
            this.labelRaz.Location = new System.Drawing.Point(26, 13);
            this.labelRaz.Name = "labelRaz";
            this.labelRaz.Size = new System.Drawing.Size(38, 13);
            this.labelRaz.TabIndex = 0;
            this.labelRaz.Text = "Razão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Responsável";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.LightCyan;
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(98, 78);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(153, 22);
            this.txtCNPJ.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.LightCyan;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(98, 154);
            this.txtNumero.Mask = "000000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.LightCyan;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(340, 154);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 22);
            this.txtTelefone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantidade de Veículos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade de Áreas";
            // 
            // txtQtdVeiculos
            // 
            this.txtQtdVeiculos.BackColor = System.Drawing.Color.LightCyan;
            this.txtQtdVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdVeiculos.Location = new System.Drawing.Point(154, 238);
            this.txtQtdVeiculos.Mask = "00";
            this.txtQtdVeiculos.Name = "txtQtdVeiculos";
            this.txtQtdVeiculos.Size = new System.Drawing.Size(97, 22);
            this.txtQtdVeiculos.TabIndex = 7;
            // 
            // txtQtdAreas
            // 
            this.txtQtdAreas.BackColor = System.Drawing.Color.LightCyan;
            this.txtQtdAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdAreas.Location = new System.Drawing.Point(398, 238);
            this.txtQtdAreas.Mask = "00";
            this.txtQtdAreas.Name = "txtQtdAreas";
            this.txtQtdAreas.Size = new System.Drawing.Size(97, 22);
            this.txtQtdAreas.TabIndex = 8;
            // 
            // txtRazao
            // 
            this.txtRazao.BackColor = System.Drawing.Color.LightCyan;
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao.Location = new System.Drawing.Point(98, 8);
            this.txtRazao.MaxLength = 50;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(439, 22);
            this.txtRazao.TabIndex = 0;
            // 
            // txtFantasia
            // 
            this.txtFantasia.BackColor = System.Drawing.Color.LightCyan;
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(98, 45);
            this.txtFantasia.MaxLength = 50;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(439, 22);
            this.txtFantasia.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.LightCyan;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(98, 113);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(439, 22);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.BackColor = System.Drawing.Color.LightCyan;
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(98, 192);
            this.txtResponsavel.MaxLength = 50;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(245, 22);
            this.txtResponsavel.TabIndex = 6;
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Configuracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.panelRodape.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.MaskedTextBox txtQtdAreas;
        private System.Windows.Forms.MaskedTextBox txtQtdVeiculos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtRazao;
    }
}