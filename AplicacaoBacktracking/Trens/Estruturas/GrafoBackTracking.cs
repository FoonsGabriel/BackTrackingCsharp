using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Trens.Estruturas;
using Trens.Model;
using Trens.Models;

namespace Trens.Estruturas
{
    public class GrafoBacktracking
    {
        private PilhaVetor<Movimento> pilha;

        private bool[] visitados;

        private double distanciaAtual;

        private double precoAtual;
        public VetorCidades Cidades { get; set; }

        public Ligacao[,] Adjacencia { get; set; }

        public List<Caminho> CaminhosEncontrados { get; set; }

        public GrafoBacktracking()
        {
            CaminhosEncontrados = new List<Caminho>();
        }


        public int BuscarIndiceCidade(string nome)
        {
            return Cidades.Buscar(nome);
        }

        public bool ExisteLigacao(int origem, int destino)
        {
            return Adjacencia[origem, destino] != null;
        }

        public void BuscarTodosCaminhos(Cidade origem, Cidade destino)
        {
            CaminhosEncontrados.Clear();

            pilha = new PilhaVetor<Movimento>();

            visitados = new bool[Cidades.Quantidade];

            distanciaAtual = 0.0;

            precoAtual = 0.0;

            int indiceOrigem =
                BuscarIndiceCidade(origem.Nome);

            int indiceDestino =
                BuscarIndiceCidade(destino.Nome);

            Backtracking(
                indiceOrigem,
                indiceDestino);
        }

        private void Backtracking(
            int cidadeAtual,
            int destino)
        {
            if (cidadeAtual == destino)
            {
                SalvarCaminho();

                return;
            }

            visitados[cidadeAtual] = true;

            for (int vizinho = 0;
                 vizinho < Cidades.Quantidade;
                 vizinho++)
            {
                if (!ExisteLigacao(cidadeAtual, vizinho))
                    continue;

                if (visitados[vizinho])
                    continue;

                var ligacao =
                    Adjacencia[cidadeAtual, vizinho];

                var movimento =
                    new Movimento(
                        cidadeAtual,
                        vizinho,
                        ligacao.Distancia,
                        ligacao.Preco);

                pilha.Empilhar(movimento);

                distanciaAtual += ligacao.Distancia;

                precoAtual += ligacao.Preco;

                Backtracking(vizinho, destino);

                pilha.Desempilhar();

                distanciaAtual -= ligacao.Distancia;

                precoAtual -= ligacao.Preco;
            }

            visitados[cidadeAtual] = false;
        }

        private void SalvarCaminho()
        {
            Caminho caminho =
                new Caminho();

            caminho.DistanciaTotal =
                distanciaAtual;

            caminho.PrecoTotal =
                precoAtual;

            List<Movimento> movimentos =
                pilha.Conteudo();

            if (movimentos.Count > 0)
            {
                caminho.Cidades.Add(
                    Cidades.GetCidade(
                        movimentos[0].Origem));

                foreach (var mov in movimentos)
                {
                    caminho.Cidades.Add(
                        Cidades.GetCidade(
                            mov.Destino));
                }
            }

            CaminhosEncontrados.Add(caminho);
        }

        public Caminho EncontrarMenorCaminho()
        {
            if (CaminhosEncontrados.Count == 0)
                return null;

            Caminho menor =
                CaminhosEncontrados[0];

            foreach (var caminho in CaminhosEncontrados)
            {
                if (caminho.DistanciaTotal <
                    menor.DistanciaTotal)
                {
                    menor = caminho;
                }
            }

            return menor;
        }

        //pega indice da origem e destino, cria ligacao e atribui as adjacencias
        public void AdicionarLigacao(
            Cidade origem,
            Cidade destino,
            double distancia,
            double preco)
        {
            int i = BuscarIndiceCidade(origem.Nome);
            int j = BuscarIndiceCidade(destino.Nome);

            Ligacao ligacao = new Ligacao(distancia, preco);

            Adjacencia[i, j] = ligacao;
            Adjacencia[j, i] = ligacao;
        }

        //busca indices e coloca null na duas posicoes
        public void RemoverLigacao (
            Cidade origem,
            Cidade destino)
        {
            int i = BuscarIndiceCidade(origem.Nome);
            int j = BuscarIndiceCidade(destino.Nome);

            Adjacencia[i, j] = null;
            Adjacencia[j, i] = null;
        }

        public void AdicionarCidade(Cidade novaCidade)
        {
            //quantas cidades existiam antes
            int tamanhoAntigo = Cidades.Quantidade;

            //guarda a matriz antiga
            Ligacao[,] matrizAntiga = Adjacencia;

            //insere ordenado
            Cidades.Inserir(novaCidade);

            //cria matriz maior
            Ligacao[,] novaMatriz = new Ligacao[Cidades.Quantidade, Cidades.Quantidade];

            //descobre onde a nova cidade entrou
            int indiceNovo = BuscarIndiceCidade(novaCidade.Nome);

            //indice da linha da matriz antiga
            int antigaLinha = 0;

            //percorre as linhas da matriz nova
            for (int linhaNova = 0; linhaNova < Cidades.Quantidade; linhaNova++)
            {
                //se chegou na linha da cidade nova
                //pula ela
                if (linhaNova == indiceNovo)
                    continue;

                //indice da coluna da matriz antiga
                int antigaColuna = 0;

                //percorre as colunas da matriz nova
                for (int colunaNova = 0; colunaNova < Cidades.Quantidade; colunaNova++)
                {
                    //se chegou na coluna da cidade nova
                    //pula ela
                    if (colunaNova == indiceNovo)
                        continue;

                    //copia os dados da matriz antiga
                    novaMatriz[linhaNova, colunaNova] = matrizAntiga[antigaLinha, antigaColuna];

                    antigaColuna++;
                }

                antigaLinha++;
            }

            //atualiza o ponteiro da matriz
            Adjacencia = novaMatriz;
        }

        public void RemoverCidade(string nomeCidade)
        {
            //pega indice daonde cidade está
            int indiceRemovido = BuscarIndiceCidade(nomeCidade);

            //se n encontrar, sai do método
            if (indiceRemovido == -1)
                return;

            //guarda matriz antiga
            Ligacao[,] matrizAntiga = Adjacencia;

            //cria nova matriz
            Ligacao[,] novaMatriz = new Ligacao[Cidades.Quantidade - 1, Cidades.Quantidade - 1];
            
            //indice da matriz antiga
            int antigaLinha = 0;

            //percorre a matriz antiga(linha)
            for (int linhaAntiga = 0; linhaAntiga < Cidades.Quantidade; linhaAntiga++)
            {
                //se chegou na linha da cidade removida, pula ela
                if (linhaAntiga == indiceRemovido)
                    continue;

                //tb indice da matriz antiga
                int antigaColuna = 0;

                //agr percorre a coluna
                for (int colunaAntiga = 0; colunaAntiga < Cidades.Quantidade; colunaAntiga++)
                {
                    //se chegar na coluna da cidade removida, tb pula
                    if (colunaAntiga == indiceRemovido)
                        continue;

                    //copia os dados pra nova matriz
                    novaMatriz[antigaLinha, antigaColuna] = matrizAntiga[linhaAntiga, colunaAntiga];

                    antigaColuna++;
                }
                antigaLinha++;
            }

            //remove a cidade do vetor só dps q copiou td
            Cidades.Remover(nomeCidade);

            //muda o ponteiro pra nova matriz
            Adjacencia = novaMatriz;

        }
    }

}

