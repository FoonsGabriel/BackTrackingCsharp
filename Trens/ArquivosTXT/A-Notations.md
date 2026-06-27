Entidades - Model

	Cidade:
			Representa uma cidade, exemplo: Madrid, X=35, Y=42
		Classe: 
			Nome - X - Y - CompareTo() - ToString()
		Status: quase pronto

	Ligacao: 
			Representa uma aresta, exemplo: Madrid - Lisboa, 600km, 40€
		Classe: 
			Distancia - Preco
		Status: quase pronto

	Movimento:
			Guarda passo no percurso, exemplo: Madrid - Lisboa, 600km, 40€. Será empilhado durante o backtracking
		Status: quase pronto

	Caminho:
			Guarda o resultado encontrado, exemplo: Madrid - Lisboa - Porto, 950km, 65€. Não faz busca, não empilha, só armazena
		Campos:
			List<Cidade> - DistanciaTotal - PrecoTotal



Lógica Bruta - Estruturas

	VetorCidades:
			guarda cidades ordenada alfabeticamente, exemplo: Barcelona - Lisboa - Madrid - Porto
		Métodos: Inserir - Remover - Buscar (binária) - GetCidade - Listar
		Fluxo: Inserir "Coimbra", Achar Posicao, Move Elementos, Insere
		Status: Incompleta(Nenhum método)

	GrafoBackTracking:
			Coração da parada, guarda: Vetor Cidades, Matriz de Adjacência, Lista de Caminhos Encontados;
			E durante a busca: Pilha, Visitados, Distancia Atual, Preco Atual
		Fluxo: Ler linhas - Criar cidade - Inserir no VetorCidades




