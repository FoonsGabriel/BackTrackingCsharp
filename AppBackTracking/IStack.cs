using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IStack<T> where T : IComparable<T>
{
  void Empilhar(T item);
  T Desempilhar();  // desempilha e retornar objeto do topo após removê-lo da pilha

  T OTopo();        // retorna o objeto do topo da pilha sem removê-lo

  int Tamanho { get; }    // propriedade que retorna o tamanho da pílha
                          
  bool EstaVazia { get; } // informa se a pilha esvaziou

  List<T> Conteudo();     // retorna um vetor com os dados empilhados

    void Exibir(DataGridView dgv);

}

