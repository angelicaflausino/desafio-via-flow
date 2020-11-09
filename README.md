# desafio-via-flow
Repositório de testes da via-flow


## Prova Senior

Questão 1:

[Questão 1](https://github.com/angelicaflausino/desafio-via-flow/blob/main/src/DesafioApp/DesafioApp/Questao1.cs)

**Questão 2**
**Resposta:** 
	*Reflection* é utilizado mais comumente para acessar as propriedades e atributos de um determinado objeto. É muito útil quando é necessário instanciar uma classe em tempo de execução (*runtime*) do programa. Também é possível via *reflection* obter as informações de *assembly* da classe, o que pode ser muito útil quando estamos trabalhando com injeção de depedência. 
	Para utilizar *Reflection* é necessário referenciar a biblioteca System.
	
[Exemplo da Questão 2](https://github.com/angelicaflausino/desafio-via-flow/blob/main/src/DesafioApp/DesafioApp/Questao2.cs)

**Questão 3**
**Resposta:** 
	Os tipos de classes genéricos, são bastante utilizados para definir padrões de classes sem ser necessário especificação do tipo da classe previamente. O caso mais comum da utilização da biblioteca *generics* é na implementação de coleções como List<T> e Dictionary<Tkey, TValue>. 
	O maior benefício de se trabalhar com *generics* é a reusabilidade do código. Você escreve menos código e os tipos genéricos já estão pronto para uso.

[Exemplo da Questão 3](https://github.com/angelicaflausino/desafio-via-flow/blob/main/src/DesafioApp/DesafioApp/Questao3.cs)

**Questão 4**
**Resposta:** 
A função deverá utilizar *Reflection* para criar em *runtime* o tipo do objeto genérico especificado.

[Exemplo da questão 4](https://github.com/angelicaflausino/desafio-via-flow/blob/main/src/DesafioApp/DesafioApp/Questao4.cs)

**Questão 5**
**Resposta:** 

    SELECT 
    f.Id,
    f.Nome,
    f.Salario,
    f.DeptID
    d.Id,
    d.Nome
    FROM Funcionarios f
    INNER JOIN Departamento d
    ON (f.DeptID = d.Id)
    WHERE Salario IN (SELECT MAX(Salario) FROM Funcionarios GROUP BY DeptID)

**Questão 6**
**Resposta:** 
O método .each() da biblioteca jquery é utilizada para iterar sobre cada item de um objeto, por exemplo uma lista, para cada item da lista o método irá percorrer um bloco de código, por exemplo: Para cada item da lista eu desejo adicionar uma classe dinamicamente por uma ação do usuário, então:

        $('li').each(function() {
    	//Adicionar uma classe para cada item
    	$(this).addClass('btn btn-primary disabled');
    	
    	//Ou adiciona uma propriedade no elemento
    	$(this).prop('readonly', true);
    	
    	//Se o item não faz parte de uma determinada condição posso sair do bloco de código
    	
    	if($(this).hasClass('disabled'))
    		return false;
    });

**Questão 7**
**Resposta:** 

    //Seleciona o elemento com a tag div
    $("div")
    
    //Adiciona 300 pixels de largura no estilo do elemento 'div'
    .css( "width", "300px" )
    
    //adiciona dentro do elemento 'div' outro elemento de paragrafo 'p'
    .add("p")
    
    //define a cor de fundo do elemento 'p' com a cor blue (azul)
    .css("background-color", "blue"); 


**Questão 8**
**Resposta:** 

MVC é um padrão de arquitetura de software, onde é dividido a responsabilidades em três camadas:
 View: Camada de interação com o usuário.
 Model: Camada de representação das regras e modelos de negócio do sistema.
 Controller: Camada que controla a comunicação entre View e Model.
 Um exemplo prático é um formulário de registro, a camada View (exibição) exibe um formulário em html, o usuário preenche as informações conforme o modelo exigido, por exemplo Usuário e Senha, esses campos são definidos pela camada Model (modelo), então o usuário preenche o formulário e clica em Cadastrar, nesse momento a View envia as informações preenchidas para o Controller que irá repassar a informação para a camada Model registrar a informação. Ao salvar as informações a camada de modelo devolver uma resposta para o Controller que repassa a informação para a camada de exibição.

**Questão 9**
**Resposta:** 

PartialView é uma exibição parcial de um fragmento html, é possível ter uma parte do código que extende um formulário, bem como um elemento que posso reutilizar em outras partes do código. É ideal para reduzir marcações html muito grandes, reaproveitar marcações, evitando assim a duplicação de código.

**Questão 10**
**Resposta:** 
Para restringir, é necessário decorar o método com o atributo no Http Verb desejado, para GET, utiliza-se [HttpGet], para Post utiliza-se [HttpPost], exemplo:

	[HttpPost]
    public void AlterarUsuario(Usuario usuario) 
    { 
	    UsuarioRepository.AddUsuario(usuario); 
    }

**Questão 11**
**Resposta:** 

OData é a abreviação de *Open Data Protocol*, define um conjunto de práticas recomendadas para o consumo e a criação de aplicações RESTful. Basicamente define um padrão em que os dados são acessados e manipulados na rede e possui diversas vantagens como evitar expor a fonte real de dados, como um banco de dados.
Vantagens de utilização:
- Oferece suporte a operações CRUD (*Create, Read, Update and Delete*) em diveros verbos HTTP.
- É leve e a interação do cliente com o servidor é rápida
- Permite criar e expor métodos e classes personalizadas

