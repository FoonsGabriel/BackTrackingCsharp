using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class PilhaVetor<T> : IStack<T> where T : IComparable<T>
{
    const int TAMANHO_PADRAO = 500;
    int topo;
    T[] p;
    int tamanhoFisico;

    public PilhaVetor() : this(TAMANHO_PADRAO) { }
    public PilhaVetor(int tamanhoFisico)
    {
        topo = -1;
        p = new T[tamanhoFisico];
        this.tamanhoFisico = tamanhoFisico;   // para sabermos quantas posições o vetor tem
    }

    public int Tamanho => topo + 1;

    public bool EstaVazia => topo < 0;

    public List<T> Conteudo()
    {
        List<T> resultado = new List<T>();

        for (int i = 0; i <= topo; i++)
            resultado.Add(p[i]);

        return resultado;
    }

    public void Exibir(DataGridView dgv)
    {
        dgv.RowCount = dgv.ColumnCount = Tamanho + 1;
        for (int coluna = 0; coluna < Tamanho; coluna++)
        {
            dgv.Columns[coluna].HeaderText = coluna.ToString();
            dgv.Rows[coluna].HeaderCell.Value = coluna.ToString();
            dgv.Columns[coluna].Width = 50;
        }
        var dadosDaPilha = this.Conteudo();
        for (int coluna = 0; coluna < Tamanho; coluna++)
            dgv[coluna, 0].Value = dadosDaPilha[coluna];
    }
    public T Desempilhar()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou (underflow)!");

        T itemQueEstavaNoTopo = p[topo--];  // recupera item do topo e diminui a pilha
        return itemQueEstavaNoTopo;
    }

    public void Empilhar(T item)
    {
        if (topo >= tamanhoFisico)
            throw new Exception("Pilha transbordou (overflow)!");

        p[++topo] = item; // a pilha aumenta e se armazena item em seu topo
    }

    public T OTopo()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou (underflow)!");

        return p[topo];   // retorna o dado do topo da pilha e não muda o topo
    }
}