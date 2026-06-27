using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trens.Estruturas;
using Trens.Services;
using Trens.Model;

namespace Trens
{
    public partial class FrmCaminhos : Form
    {


    public FrmCaminhos()
    {
      InitializeComponent();
      //inicializa o grafo logo que cria o form
      grafo = new GrafoBacktracking();
    }
        GrafoBacktracking grafo;

        private Caminho menorCaminhoAtual;


        #region Métodos de cidades
        private void carregarCidades(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;

            //cria um arquivo services para ler o arquivo de cidades
            ArquivosServices arquivosServices = new ArquivosServices();

            //chama o metodo de ler as cidades e salva o resultado em um vetor de cidades
            VetorCidades cidades = arquivosServices.LerCidades(dlgOpen.FileName);

            //adiciona as cidades ao grafo
            grafo.Cidades = cidades;

            //limpa os combobox
            cbxCidadeOrigem.Items.Clear();
            cbxCidadeDestino.Items.Clear();

            //coloca as cidades nos combobox
            foreach (Cidade cidade in cidades.Listar())
            {
                cbxCidadeDestino.Items.Add(cidade.Nome);
                cbxCidadeOrigem.Items.Add(cidade.Nome);
            }
        }

        private void salvarCidades(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                ArquivosServices arquivos = new ArquivosServices();

                arquivos.SalvarCidades(dlgSave.FileName, grafo.Cidades);
            }
        }


        #endregion

        #region Métodos de caminhos
        private void carregarCaminhos(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;

            if (grafo.Cidades == null)
            {
                MessageBox.Show("Carregue as cidades primeiro.");
                return;
            }

            string caminho = dlgOpen.FileName;

            if (string.IsNullOrWhiteSpace(caminho))
                return;

            ArquivosServices arquivosServices =
                new ArquivosServices();

            grafo.Adjacencia =
                arquivosServices.LerLigacoes(caminho, grafo.Cidades);
        }

        private void salvarCaminhos(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                ArquivosServices arquivos = new ArquivosServices();

                arquivos.SalvarLigacoes(dlgSave.FileName, grafo.Cidades, grafo.Adjacencia);
            }
        }

        #endregion

        #region Métodos graficos
        private void Form1_Resize(object sender, EventArgs e)
        {
            

            mapa.Invalidate();
        }

        private void FrmCaminhos_Load(object sender, EventArgs e)
        {
            MessageBox.Show("SELECIONE O TXT DE CIDADES");
            carregarCidades(sender, e);
            MessageBox.Show("SELECIONE O TXT DE CAMINHOS");
            carregarCaminhos(sender, e);
        }

        private void mapa_Paint(object sender, PaintEventArgs e)
        {
            if (menorCaminhoAtual == null)
                return;

            //pega o objeto responsavel pelo pincel
            Graphics g = e.Graphics;

            //lista cidades
            Cidade[] cidades = grafo.Cidades.Listar();

            foreach(Cidade cidade in cidades)
            {
                //pega posicao de cada cidade
                float x = (float)(cidade.X * mapa.Width);
                float y = (float)(cidade.Y * mapa.Height);

                //desenha bolinha em cima da cidade
                g.FillEllipse(Brushes.Blue, x - 4, y - 4, 8, 8);

                /*escreve nome em cima da cidade
                g.DrawString(cidade.Nome, this.Font, Brushes.Black, x + 5, y + 5);
                */
            }

            //agora desenhamos menor caminho
            for (int i = 0; i < menorCaminhoAtual.Cidades.Count - 1; i++)
            {
                //origem
                Cidade origem = menorCaminhoAtual.Cidades[i];

                //destino, prox ponto(i+1)
                Cidade destino = menorCaminhoAtual.Cidades[i + 1];

                float x1 = (float) (origem.X * mapa.Width);
                float y1 = (float)(origem.Y * mapa.Height);

                float x2 = (float)(destino.X * mapa.Width);
                float y2 = (float)(destino.Y * mapa.Height);


                //pincel desenha linha usando as coordenadas
                Pen caneta = new Pen ( Color.Red, 3 );
                g.DrawLine(caneta, x1, y1, x2, y2);
            } 
        }


        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //debug
            int conexoesEncontradas = 0;
            for (int i = 0; i < grafo.Cidades.Quantidade; i++)
            {
                for (int j = 0; j < grafo.Cidades.Quantidade; j++)
                {
                    if (grafo.Adjacencia[i, j] != null) conexoesEncontradas++;
                }
            }
            MessageBox.Show($"O grafo possui {grafo.Cidades.Quantidade} cidades e {conexoesEncontradas} conexões carregadas na matriz.");


            //limpa a tabela anterior
            dgvCaminhos.Rows.Clear();

            // 2. Valida se os campos não estão vazios
            if (string.IsNullOrEmpty(cbxCidadeOrigem.Text) || string.IsNullOrEmpty(cbxCidadeDestino.Text))
            {
                MessageBox.Show("Por favor, selecione as cidades de origem e destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //busca indice
            int indiceOrigem = grafo.Cidades.Buscar(cbxCidadeOrigem.Text);
            int indiceDestino = grafo.Cidades.Buscar(cbxCidadeDestino.Text);

            //se nao encontrar no vetor, avisa o usuario
            if (indiceOrigem == -1 || indiceDestino == -1)
            {
                MessageBox.Show("Cidade de origem ou destino não encontrada no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // pega os objetos
            Cidade origem = grafo.Cidades.GetCidade(indiceOrigem);
            Cidade destino = grafo.Cidades.GetCidade(indiceDestino);

            //executa o algoritmo do grafo
            grafo.BuscarTodosCaminhos(origem, destino);

            // se nao encontrar nenhum caminho entre elas
            if (grafo.CaminhosEncontrados == null || grafo.CaminhosEncontrados.Count == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum caminho de trem entre essas cidades.", "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // popula a tabela se houver caminhos
            foreach (Caminho caminho in grafo.CaminhosEncontrados)
            {
                dgvCaminhos.Rows.Add(caminho.ToString(), caminho.DistanciaTotal, caminho.PrecoTotal);
            }

            menorCaminhoAtual = grafo.EncontrarMenorCaminho();

            // forca o mapa a se redesenhar chamando o mapa_Paint
            mapa.Invalidate();

            //limpa
            lsbCaminhoMaisCurto.Items.Clear();

            //se houver menorCaminhoAtual, add
            lsbCaminhoMaisCurto.Items.Clear();

            if (menorCaminhoAtual != null)
            {
                //fizemos por toString antes, mas agora vamos mostrar cada cidade em uma linha separada
                foreach (Cidade cidade in menorCaminhoAtual.Cidades)
                {
                    //adiciona cidade na lista
                    lsbCaminhoMaisCurto.Items.Add(cidade.Nome);
                    //verifica se nao eh a ultima cidade, entao adiciona uma seta para baixo
                    if (cidade != menorCaminhoAtual.Cidades.Last())
                    {
                        lsbCaminhoMaisCurto.Items.Add("↓");
                    }
                }
            }
            else
            {
                lsbCaminhoMaisCurto.Items.Add("Nenhum caminho disponível.");
            }

        }
    }
}
