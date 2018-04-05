namespace CheckVTR.Interface
{
    partial class CadItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadItens));
            this.panelRodape = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkNormal = new System.Windows.Forms.CheckBox();
            this.checkPorcentagem = new System.Windows.Forms.CheckBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panelRodape.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRodape
            // 
            this.panelRodape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRodape.Controls.Add(this.btnApagar);
            this.panelRodape.Controls.Add(this.btnSalvar);
            this.panelRodape.Controls.Add(this.btnProximo);
            this.panelRodape.Controls.Add(this.label27);
            this.panelRodape.Controls.Add(this.btnAnterior);
            this.panelRodape.Controls.Add(this.btnLimpar);
            this.panelRodape.Location = new System.Drawing.Point(12, 295);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(560, 50);
            this.panelRodape.TabIndex = 3;
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
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProximo.BackgroundImage")));
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProximo.Location = new System.Drawing.Point(492, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(50, 35);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(370, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "Buscar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.Location = new System.Drawing.Point(425, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 35);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(122, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 25);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(141, 93);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 29);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(141, 27);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 29);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // checkNormal
            // 
            this.checkNormal.AutoSize = true;
            this.checkNormal.Checked = true;
            this.checkNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNormal.Location = new System.Drawing.Point(12, 178);
            this.checkNormal.Name = "checkNormal";
            this.checkNormal.Size = new System.Drawing.Size(84, 24);
            this.checkNormal.TabIndex = 11;
            this.checkNormal.Text = "Normal";
            this.checkNormal.UseVisualStyleBackColor = true;
            this.checkNormal.CheckedChanged += new System.EventHandler(this.Normal_changed);
            // 
            // checkPorcentagem
            // 
            this.checkPorcentagem.AutoSize = true;
            this.checkPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPorcentagem.Location = new System.Drawing.Point(161, 178);
            this.checkPorcentagem.Name = "checkPorcentagem";
            this.checkPorcentagem.Size = new System.Drawing.Size(134, 24);
            this.checkPorcentagem.TabIndex = 12;
            this.checkPorcentagem.Text = "Porcentagem";
            this.checkPorcentagem.UseVisualStyleBackColor = true;
            this.checkPorcentagem.CheckedChanged += new System.EventHandler(this.Porcentagem_Changed);
            // 
            // panelFundo
            // 
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.checkPorcentagem);
            this.panelFundo.Controls.Add(this.checkNormal);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.txtCodigo);
            this.panelFundo.Controls.Add(this.label2);
            this.panelFundo.Controls.Add(this.txtNome);
            this.panelFundo.Location = new System.Drawing.Point(12, 15);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(560, 275);
            this.panelFundo.TabIndex = 2;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(238, 11);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(80, 25);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // CadItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CadItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens do Checklist";
            this.panelRodape.ResumeLayout(false);
            this.panelRodape.PerformLayout();
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkNormal;
        private System.Windows.Forms.CheckBox checkPorcentagem;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button btnApagar;
    }
}