using Trens.Model;

public class VetorCidades
{
    private Cidade[] vetor;
    private int quantidade;

    //onde vai guardar as cidades
    public VetorCidades()
    {
        vetor = new Cidade[500];
        //quantas cidades tem
        quantidade = 0;
    }

    public int Quantidade
    {
        get { return quantidade; }
    }

    //descobrir posição correta
    //deslocar elementos para direita
    //inserir
    //aumentar quantidade
    public void Inserir(Cidade cidade)
    {
        int posicao = 0;

        //enquanto ainda há cidades para verificar e a cidade atual vem antes da nova cidade
        while (posicao < quantidade && vetor[posicao].Nome.CompareTo(cidade.Nome) < 0)
        {
            posicao++;
        }

        //deslocar elementos para direita
        //vou comecar do fim e ir deslocando ate chegar na posicao correta
        for (int i = quantidade; i > posicao; i--)
        {
            vetor[i] = vetor[i - 1];
        }
        //depois de deslocar, insere a cidade na posicao correta
        vetor[posicao] = cidade;
        quantidade++;
    }

    public void Remover(string nome)
    {
        //usa o buscar pra pegar a posicao
        var posicao = Buscar(nome);

        //se o buscar retornar -1, significa que a cidade nao foi encontrada
        if (posicao == -1) {
            return;
        }

        //se encontrou entra no for
        //esse for vai deslocar os elementos para a esquerda, a partir da posicao onde a cidade foi encontrada
        //quantidade -1 porque n precisa mover o ultimo elemento, ja que ele vai ser "removido" depois do for
        for (int i = posicao; i < quantidade - 1; i++)
        {
            vetor[i] = vetor[i + 1];
        }
        //diminui a quantidade de cidades
        //coloca null no ultimo elemento so pra limpar a lista(o ultima deixa uma referencia da cidade removida, ent botei ele como null)
        quantidade--;
        vetor[quantidade] = null;
    }

    //busca binaria biel, mt melhor nesse caso
    public int Buscar(string nome)
    {
        // Percorre o vetor do primeiro (0) até o último elemento válido
        for (int i = 0; i < quantidade; i++)
        {
            // Compara o nome atual com o nome procurado
            if (vetor[i].Nome.CompareTo(nome) == 0)
            {
                return i; // Retorna o índice onde o nome foi encontrado
            }
        }

        // Se o loop terminar e não encontrar nada, retorna -1
        return -1;
    }

    public Cidade GetCidade(int indice)
    {
        if (indice < 0 || indice >= quantidade )
        {
            return null;
        }
        return vetor[indice];
    }

    public Cidade[] Listar()
    {
        var lista = new Cidade[quantidade];
        for(int i = 0; i<quantidade;i++)
        {
           lista[i] = GetCidade(i);
        }
        return lista;
    }
}