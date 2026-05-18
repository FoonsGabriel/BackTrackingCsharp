using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBackTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GrafoBacktracking oGrafo;

        private void btnBuscarCaminho_Click(object sender, EventArgs e)
        {
            int origem = int.Parse(txtBoxOrigem.Text);
            int destino = int.Parse(txtBoxDestino.Text);
            var pilhaCaminho = oGrafo.BuscarCaminho(origem, destino, lsbMovimentos, dgvGrafo,
                                                    dgvPilha);
            if (pilhaCaminho.EstaVazia)
                MessageBox.Show("Não achou caminho");
            else
            {
                MessageBox.Show("Achou caminho");
                pilhaCaminho.Exibir(dgvPilha);
                lsbMovimentos.Items.Add("");
                lsbMovimentos.Items.Add("Caminho encontrado");
                while (!pilhaCaminho.EstaVazia)
                {
                    var mov = pilhaCaminho.Desempilhar();
                    lsbMovimentos.Items.Add($"De {mov.Origem} para {mov.Destino}");
                }
            }
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
          
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                oGrafo = new GrafoBacktracking(dlgAbrir.FileName);
                oGrafo.Exibir(dgvGrafo);
            }
        
        }
    }
}
