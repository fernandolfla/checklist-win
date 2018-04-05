namespace CheckVTR.Interface
{
    partial class Configuracoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.panelFundo = new System.Windows.Forms.Panel();
            this.dataGridPlantao = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tatico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlantao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.dataGridPlantao);
            this.panelFundo.Controls.Add(this.textBox1);
            this.panelFundo.Location = new System.Drawing.Point(12, 16);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(560, 334);
            this.panelFundo.TabIndex = 13;
            // 
            // dataGridPlantao
            // 
            this.dataGridPlantao.AllowUserToAddRows = false;
            this.dataGridPlantao.AllowUserToDeleteRows = false;
            this.dataGridPlantao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlantao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Tatico,
            this.Area,
            this.DataInicio,
            this.VTR});
            this.dataGridPlantao.Location = new System.Drawing.Point(3, 123);
            this.dataGridPlantao.Name = "dataGridPlantao";
            this.dataGridPlantao.ReadOnly = true;
            this.dataGridPlantao.RowHeadersWidth = 35;
            this.dataGridPlantao.Size = new System.Drawing.Size(550, 204);
            this.dataGridPlantao.TabIndex = 1;
            this.dataGridPlantao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlantao_CellContentClick);
            this.dataGridPlantao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlantao_CellDoubleClick);
            // 
            // Cod
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 50;
            // 
            // Tatico
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tatico.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tatico.HeaderText = "Tático";
            this.Tatico.Name = "Tatico";
            this.Tatico.ReadOnly = true;
            this.Tatico.Width = 160;
            // 
            // Area
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.DefaultCellStyle = dataGridViewCellStyle3;
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 30;
            // 
            // DataInicio
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataInicio.HeaderText = "Data Inicio";
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            this.DataInicio.Width = 160;
            // 
            // VTR
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTR.DefaultCellStyle = dataGridViewCellStyle5;
            this.VTR.HeaderText = "VTR";
            this.VTR.Name = "VTR";
            this.VTR.ReadOnly = true;
            this.VTR.Width = 110;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 114);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Encerrar Plantão Ativo! Será enviado um e-mail para o Supervisor em clodoaldo@jur" +
    "iseg.com.br devido ao não encerramento do Plantão!  Para encerrar clique 2 vezes" +
    " sobre uma linha.";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracoes";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlantao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridPlantao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tatico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
    }
}