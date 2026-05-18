namespace AppBackTracking
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
            this.lblOrigem = new System.Windows.Forms.Label();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.txtBoxOrigem = new System.Windows.Forms.TextBox();
            this.txtBoxDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnBuscarCaminho = new System.Windows.Forms.Button();
            this.dgvPilha = new System.Windows.Forms.DataGridView();
            this.lblPilha = new System.Windows.Forms.Label();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.lblMovimentos = new System.Windows.Forms.Label();
            this.lsbMovimentos = new System.Windows.Forms.ListBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(93, 17);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(43, 13);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Origem:";
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "Abrir Arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // txtBoxOrigem
            // 
            this.txtBoxOrigem.Location = new System.Drawing.Point(134, 15);
            this.txtBoxOrigem.Name = "txtBoxOrigem";
            this.txtBoxOrigem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrigem.TabIndex = 2;
            // 
            // txtBoxDestino
            // 
            this.txtBoxDestino.Location = new System.Drawing.Point(280, 17);
            this.txtBoxDestino.Name = "txtBoxDestino";
            this.txtBoxDestino.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestino.TabIndex = 4;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(239, 19);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino";
            // 
            // btnBuscarCaminho
            // 
            this.btnBuscarCaminho.Location = new System.Drawing.Point(386, 15);
            this.btnBuscarCaminho.Name = "btnBuscarCaminho";
            this.btnBuscarCaminho.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarCaminho.TabIndex = 5;
            this.btnBuscarCaminho.Text = "Buscar caminho";
            this.btnBuscarCaminho.UseVisualStyleBackColor = true;
            this.btnBuscarCaminho.Click += new System.EventHandler(this.btnBuscarCaminho_Click);
            // 
            // dgvPilha
            // 
            this.dgvPilha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPilha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilha.Location = new System.Drawing.Point(25, 70);
            this.dgvPilha.Name = "dgvPilha";
            this.dgvPilha.Size = new System.Drawing.Size(467, 76);
            this.dgvPilha.TabIndex = 6;
            // 
            // lblPilha
            // 
            this.lblPilha.AutoSize = true;
            this.lblPilha.Location = new System.Drawing.Point(22, 54);
            this.lblPilha.Name = "lblPilha";
            this.lblPilha.Size = new System.Drawing.Size(33, 13);
            this.lblPilha.TabIndex = 7;
            this.lblPilha.Text = "Pilha:";
            // 
            // lblGrafo
            // 
            this.lblGrafo.AutoSize = true;
            this.lblGrafo.Location = new System.Drawing.Point(22, 177);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(36, 13);
            this.lblGrafo.TabIndex = 9;
            this.lblGrafo.Text = "Grafo:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(25, 193);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(467, 325);
            this.dgvGrafo.TabIndex = 8;
            // 
            // lblMovimentos
            // 
            this.lblMovimentos.AutoSize = true;
            this.lblMovimentos.Location = new System.Drawing.Point(22, 540);
            this.lblMovimentos.Name = "lblMovimentos";
            this.lblMovimentos.Size = new System.Drawing.Size(67, 13);
            this.lblMovimentos.TabIndex = 10;
            this.lblMovimentos.Text = "Movimentos:";
            // 
            // lsbMovimentos
            // 
            this.lsbMovimentos.FormattingEnabled = true;
            this.lsbMovimentos.Location = new System.Drawing.Point(25, 556);
            this.lsbMovimentos.Name = "lsbMovimentos";
            this.lsbMovimentos.Size = new System.Drawing.Size(467, 147);
            this.lsbMovimentos.TabIndex = 11;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "dlgAbrir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 725);
            this.Controls.Add(this.lsbMovimentos);
            this.Controls.Add(this.lblMovimentos);
            this.Controls.Add(this.lblGrafo);
            this.Controls.Add(this.dgvGrafo);
            this.Controls.Add(this.lblPilha);
            this.Controls.Add(this.dgvPilha);
            this.Controls.Add(this.btnBuscarCaminho);
            this.Controls.Add(this.txtBoxDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtBoxOrigem);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.lblOrigem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.TextBox txtBoxOrigem;
        private System.Windows.Forms.TextBox txtBoxDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnBuscarCaminho;
        private System.Windows.Forms.DataGridView dgvPilha;
        private System.Windows.Forms.Label lblPilha;
        private System.Windows.Forms.Label lblGrafo;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Label lblMovimentos;
        private System.Windows.Forms.ListBox lsbMovimentos;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

