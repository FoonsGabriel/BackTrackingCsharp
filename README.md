# BackTrackingCsharp
Estudo sobre backtracking em C#

Uma pilha que armezena linha e coluna de um trajeto se baseando na rosa dos ventos(O norte é 0, nordeste é 1, leste é 2 e assim por diante), ate chegar em um determinado destino, se a pilha esvaziar signfica que esgotou todas as rotas ou seja não existe uma saída ou um fim do trajeto (muito utilizado em jogos), grafos são definidos com arestas e vertices e podem calcular um custo de ir de um lugar para outro, como pro exemplo gasolina, dinheiro, etc. 

Inicialmente vamos criar uma tabela para representar a rosa dos ventos que represente as somas e subtrações das colunas e linhas, onde ela recebe o d(direção de 0 a 7) e cada direção retorna a conta necessária para acessar essa direção, portanto, o d altera o (i, j) que são respectivamente linha e coluna:

    Inovo = I + deltaLin[d] 
    Jnovo = J + deltaCol[d] 

## Tabela de direção
DIREÇÃO       LIN       COL<br>
 0           -1         0 <br>
 1           -1         1 <br>
 2            0         1 <br>
 3            1         1 <br>
 4            1         0 <br>
 5            1        -1 <br>
 6            0        -1 <br>
 7           -1        -1 <br>

A cada posição que você vai, o programa deve marcar aonde você estava para que n volte antes de verificar todas as direções


Em um mapa se utiliza uma matriz adjacente que representa um grafo essa representação vai ser usada para definir a rota amrazenando em um pilha, por exemplo por quais cidades você passa ate chegar na cidade d que é o destino, para achar o melhor caminho é necessário achar todos
