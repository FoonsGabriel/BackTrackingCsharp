namespace Trens
{
    partial class FrmCaminhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaminhos));
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.mapa = new System.Windows.Forms.PictureBox();
            this.cbxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.cbxCidadeDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCaminhos = new System.Windows.Forms.Panel();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.Caminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbCaminhoMaisCurto = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).BeginInit();
            this.pnlCaminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.SuspendLayout();
            // 
            // mapa
            // 
            resources.ApplyResources(this.mapa, "mapa");
            this.mapa.Name = "mapa";
            this.mapa.TabStop = false;
            this.mapa.Paint += new System.Windows.Forms.PaintEventHandler(this.mapa_Paint);
            // 
            // cbxCidadeOrigem
            // 
            this.cbxCidadeOrigem.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCidadeOrigem, "cbxCidadeOrigem");
            this.cbxCidadeOrigem.Name = "cbxCidadeOrigem";
            // 
            // cbxCidadeDestino
            // 
            this.cbxCidadeDestino.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCidadeDestino, "cbxCidadeDestino");
            this.cbxCidadeDestino.Name = "cbxCidadeDestino";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pnlCaminhos
            // 
            resources.ApplyResources(this.pnlCaminhos, "pnlCaminhos");
            this.pnlCaminhos.Controls.Add(this.lbDistancia);
            this.pnlCaminhos.Controls.Add(this.label5);
            this.pnlCaminhos.Controls.Add(this.dgvCaminhos);
            this.pnlCaminhos.Controls.Add(this.label4);
            this.pnlCaminhos.Controls.Add(this.lsbCaminhoMaisCurto);
            this.pnlCaminhos.Controls.Add(this.btnBuscar);
            this.pnlCaminhos.Controls.Add(this.label3);
            this.pnlCaminhos.Controls.Add(this.cbxCidadeOrigem);
            this.pnlCaminhos.Controls.Add(this.label1);
            this.pnlCaminhos.Controls.Add(this.label2);
            this.pnlCaminhos.Controls.Add(this.cbxCidadeDestino);
            this.pnlCaminhos.Name = "pnlCaminhos";
            // 
            // lbDistancia
            // 
            resources.ApplyResources(this.lbDistancia, "lbDistancia");
            this.lbDistancia.Name = "lbDistancia";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dgvCaminhos
            // 
            resources.ApplyResources(this.dgvCaminhos, "dgvCaminhos");
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caminho,
            this.DistanciaTotal,
            this.PrecoTotal});
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.ReadOnly = true;
            this.dgvCaminhos.RowHeadersVisible = false;
            this.dgvCaminhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Caminho
            // 
            resources.ApplyResources(this.Caminho, "Caminho");
            this.Caminho.Name = "Caminho";
            this.Caminho.ReadOnly = true;
            // 
            // DistanciaTotal
            // 
            resources.ApplyResources(this.DistanciaTotal, "DistanciaTotal");
            this.DistanciaTotal.Name = "DistanciaTotal";
            this.DistanciaTotal.ReadOnly = true;
            // 
            // PrecoTotal
            // 
            resources.ApplyResources(this.PrecoTotal, "PrecoTotal");
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lsbCaminhoMaisCurto
            // 
            resources.ApplyResources(this.lsbCaminhoMaisCurto, "lsbCaminhoMaisCurto");
            this.lsbCaminhoMaisCurto.FormattingEnabled = true;
            this.lsbCaminhoMaisCurto.Name = "lsbCaminhoMaisCurto";
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCaminhos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.pnlCaminhos);
            this.Name = "FrmCaminhos";
            this.Load += new System.EventHandler(this.FrmCaminhos_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).EndInit();
            this.pnlCaminhos.ResumeLayout(false);
            this.pnlCaminhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.PictureBox mapa;
        private System.Windows.Forms.ComboBox cbxCidadeOrigem;
        private System.Windows.Forms.ComboBox cbxCidadeDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCaminhos;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lsbCaminhoMaisCurto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
    }
}

