using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trens.Model;

namespace Trens.Services
{

    //le e salva txt
    public class ArquivosServices
    {
        //recebe o nome do arquivo 
        //retorna vetor / lista
        public VetorCidades LerCidades(string nomeArquivo)
        {
            //cria o vetor
            VetorCidades cidades = new VetorCidades();

            //vai ler o arquivo
            using(StreamReader leitor = new StreamReader(nomeArquivo))
            {
                //agr quero que leia enquanto n chegar ao fim do arquivo
                while (!leitor.EndOfStream) {

                    //aqui vai ler a linha do arquivo
                    string linha = leitor.ReadLine();
                    //separa os dados da linha e salva em um vetor de string
                    string[] dados = linha.Split(';');

                    //cria uma cidade usando os dados do vetor
                    Cidade cidade = new Cidade(dados[0], double.Parse(dados[1]), double.Parse(dados[2]));

                    //insere a cidade no vetor de cidades
                    cidades.Inserir(cidade);
                }
            }

            return cidades;
        }

        //recebe o nome do arquivo e o vetor de cidades(para poder usar os indices das cidades)
        //retorna dados do arquivo
        public Ligacao[,] LerLigacoes(string nomeArquivo, VetorCidades cidades)
        {
            //cria a matriz de adjacencia com a quantidade de cidades do vetor
            Ligacao[,] adjacencia = new Ligacao[cidades.Quantidade, cidades.Quantidade];

            //vai ler o arquivo
            using (StreamReader leitor = new StreamReader(nomeArquivo))
            {
                //agr quero que leia enquanto n chegar ao fim do arquivo
                while (!leitor.EndOfStream)
                {

                    //aqui vai ler a linha do arquivo
                    string linha = leitor.ReadLine();

                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    //separa os dados da linha e salva em um vetor de string
                    string[] dados = linha.Split(';');

                    if (dados.Length < 4)
                        continue;

                    //vou fazer esses coigos ate o proximo comentario para padronizar o nome Santiago C. para n ter erros de diferenca de nome
                    //como não sei se pode alterar o txt do professor decidi me adpatar a ele
                    string nomeOrigem = dados[0];
                    string nomeDestino = dados[1];

                    if(nomeOrigem == "Santiago de C.")
                        nomeOrigem = "Santiago de Compostela";

                    if(nomeDestino == "Santiago de C.")
                        nomeDestino = "Santiago de Compostela";

                    //pega os indices das cidades usando o nome das cidades
                    int origem = cidades.Buscar(nomeOrigem);
                    int destino = cidades.Buscar(nomeDestino);

                    // validar obrigatoriamente (evita -1)
                    if (origem == -1 || destino == -1)
                        continue;

                    //agora crio ligacoes separadas, evita referencia compartilhada
                    double distancia = double.Parse(dados[2], new CultureInfo("pt-BR"));

                    double preco = double.Parse(dados[3], new CultureInfo("pt-BR"));

                    //insere a ligacao na matriz de adjacencia (ida e volta)
                    adjacencia[origem, destino] = new Ligacao(distancia, preco);
                    adjacencia[destino, origem] = new Ligacao(distancia, preco);
                }
            }
            return adjacencia;
        }

        public void SalvarCidades(string nomeArquivo, VetorCidades cidades)
        {

            using (StreamWriter escritor = new StreamWriter(nomeArquivo)) 
            {
                Cidade[] lista = cidades.Listar();

                foreach (Cidade cidade in lista)
                {
                    escritor.WriteLine(cidade.Nome + ";" + cidade.X + ";" + cidade.Y);
                }
            }    
        }

        public void SalvarLigacoes(string nomeArquivo, VetorCidades cidades, Ligacao[,] adjacencia)
        {
            
            using (StreamWriter escritor = new StreamWriter(nomeArquivo))
            {
                for (int i = 0; i < cidades.Quantidade; i++)
                {
                    for (int j = 0; j < cidades.Quantidade; j++)
                    {
                        if (adjacencia[i, j] != null)
                        {
                            Cidade origem = cidades.GetCidade(i);

                            Cidade destino = cidades.GetCidade(j);

                            Ligacao ligacao = adjacencia[i, j];

                            escritor.WriteLine(origem.Nome + ";" +
                                destino.Nome + ";" + ligacao.Distancia + ";" + ligacao.Preco);
                        }
                    }
                }
            }

        }
    }
}
