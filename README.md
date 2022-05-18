# MinhasNoticias
Portal de minhas notícias.
*******************************************************************************************************************************
Solução: Minhas Noticias
Como é divida a solução:
Solution Items
    **Bat que será utlizada para apagar pastas de compilação (limpar o build)
Source
	**Core 
	  Application (projeto de biblioteca de classes do net.core 6)
	  Domain (projeto de biblioteca de classes do net.core 6)
	**Infrastructure 
	  Infrastructure (projeto de biblioteca de classes do net.core 6)
	  Infrastructure.Shared (projeto de biblioteca de classes do net.core 6)
	**Shared
	  Shared (projeto de biblioteca de classes do net.core 6)	
	**Web
	  **Client
		Cliente (projeto em asp.net core 6 com blazor) (Toda interface UI e interação com o cliente está neste projeto)
		Client.Infrastructure (projeto de biblioteca de classes do net.core 6
	  **Server
		Server (projeto em asp.net core 6 com blazor) (server) (aqui fica responsável pela comunicação com a API interna;
*******************************************************************************************************************************


Abaixo descrevo como utilizar todo o projeto para customizar de acordo com o projeto a ser elaborado.

1 - Criar Entidade
    Core
	----Domain
	    ------Entities
		      *Criar as entidades aqui
			  
2 - Criar a Interface par ao Repositorio:
    Core
	----Application
	    ------Interfaces
		      ----------Repositories
			            *Criar aqui a interface para o repositório
						
3 - Criar o repositorio 
    Core
	----Infrastructure
	    ------Repositories
		      *Criar aqui o repositorio 
			  
4 - Criar filtros para obter resultados
    Core
	----Application
	    ------Specifications
		      ----------Subpasta se houver
			            *Criar Filtro para obter dados especificos

5 - Criar Requisão para persistencia
    Core
	----Application
        ----------Features
	              -----(Entidade) nomear uma pasta com o nome da entidade que vai utilizar;
						     ------Commands
							       --------AddEdit
										   *Classe: AddEdit(Entidade)Command.cs (classe para persistencia de dados (Adicionar/Editar))
										   ex.: AddEditProdutoCommand.cs 
								   --------Delete
											*Classe: Delete(Entidade)Command.cs (classe para persistencia de dados (Exclusão))
								   --------Import (opcional)
						     ------Queries
							       --------GetAllPaged (aqui deveremos criar uma classe com as propriedades do que precisa ser retornado e uma classe com as buscas para retornar o resultado);
							               *Classe 1: GetAllPaged(Entidade)Response.cs (essa classe conterá as propriedades a serem retornadas na consulta);
										   *Classe 2: GetAll(Entidade)Query.cs (essa classe fará a consulta ao banco de dados e retornara os dados conforme informados na Classe 1);

5 - Criar o automapper da entidade
    Core
	----Application
        ----------Mappings
		          *Criar o mapeamento para o automapper
				  (Entidade)Profile.cs - Classe responsavel pelo automapper;

6 - Criar request para transição entre em client/server/infra para obter busca paginada
	----Application
        ----------Requests
				  ----subpastas se houver 
				      GetAllPaged(Endidade)Request.cs 
					  Conteúdo do construtor:
					  public class GetAllPagedENTIDADERequest : PagedRequest
					{
						public string SearchString { get; set; }
					}
					obs: Trocar ENTIDADE pelo nome da entidade que será persistida;

7 - Criar Requeste para efetuar a validação dos dados (fluent validation)
    Core
	----Application
	    ------Validators
		      ----------Features
			            -----PastaEntidade
						     ------Commands
							       --------AddEdit
								           *Colocar as validações aqui para fluentvalidation (utilizar localization para traduções se for necessário) essas validações se refletirá 
										    no formulario de persistencia no cliente;




8 - Criar a infraestrutura do cliente para acesso e persistencia de dados 
    1 - Criar a INTERFACE de comunicação com o projeto "application"
	    Web
		---Cliente 
		   Client.Infrastructure (projeto de biblioteca de classes em net core 6
		   ---Managers
		      ---Pastas/organização das funções
			     **Criar INTERFACE 
	2 - Criar rota para API interna (ENDPOINTs)
	    Web
		---Cliente 
		   Client.Infrastructure (projeto de biblioteca de classes em net core 6
		   ---Routes
		      Criar classe para persistencia via API (endpoint)
	3 - Criar rota para API interna 
	    Web
		---Cliente 
		   Client.Infrastructure (projeto de biblioteca de classes em net core 6
		   ---Managers
		      ---Pastas/organização das funções
			     Criar classe para acesso ao endpoint e pertistencia dos dados;
				 
9 - Criar as CLAINS para persistencia 
    Shared 
         shared (projeto biblioteca de classes do dotnet core 6
		 ---Constants
		    ----Permission
			    Inserir na classe permissions.cs as permissões necessária ao objetivo;
	    
10 - Criar o acesso a API (controllers) para o endpoints disponiveis;
	    Web
		---Server 
		   ---Controllers
				---v1
					---Pasta/organização das controllers 
					   criar a controller especifica para entidade;
				 
11 - Por fim criar a interface para interação UI/SERVER
	    Web
		---Cliente 
		   ---Pages
		      inserir pasta para organizar de acordo com a ideia do projeto e suas paginas razor contendo a interação entre o usuario e a aplicação
			  lembrando de selecionar sempre a template Componente Razor por se tratar de uma aplicação Blazor;
			  Lembre-se de colocar a diretiva @page "caminhoaparanovapaginarazor" exemplo: @page "/home"
       			  
Inserir no menu o acesso para a pagina a ser criada, o  menu fica dentro de  	WEB\CLIENT\CLIENT\Shared\NavMenu.razor; 
