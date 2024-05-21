# 100DiasDeCodigo_CSharp

Dia 1/100
Construção de API Rest com C#
Uma API de leilões onde você pode consultar os leilões que estão abertos, os itens disponíveis para esse leilão e dar um lance para cada item.
Conectei a api com o banco de dados SQLite, utilizei o entity framework, além de injeção de dependência, POO, swagger...
Os próximos passos serão a criação de mais endpoints para outras tarefas a serem realizadas, melhorar a parte de autenticação e por ultimo fazer o front-end do projeto.
Link: https://github.com/DeividsonOmedio/100DiasDeCodigo_CSharp/tree/main/Dia_1

Dia 2/100
Construção de API Rest com C# - Continuação.
Hoje fiz um CRUD completo para a parte dos leilões,
onde você pode além de visualizar os leilões, criar novos, editar ou excluir algum leilão.
Foi uma jornada bem interessante visto que na hora do desenvolvimento eu fiquei sem acesso a internet
e como formatei meu notebook semana passada, não tenho outro projeto nele, então estava impossibilitado de fazer qualquer tipo de consultas,
mas com calma finalizei essa primeira parte e tenho certeza de que estou evoluindo ainda mais.

Dia 3/100
Construção de API Rest com C# - Continuação
Hoje realizei o CRUD referente aos itens de cada leilão,
criei o controlador, defini as rotas, os parâmetros
e uma classe separada para as logica do processo, deixando os controladores somente para as chamadas a API.
também acrescentei validações para evitar erros inesperados.

Dia 4/100
Construção de API Rest com C# - Continuação
Hoje realizei foquei na parte dos usuários,
definindo os endpoints para cadastrar novo usuário, busca-los por Id ou por nome, alterar nome, e-mail ou senha separadamente e também poder deletar um usuário.
Hoje não estou muito bem fisicamente, então foi só uma horinha mesmo codando, mas amanha espero voltar a rotina normal.

Dia 5/100
Construção de API Rest com C# - Continuação
Hoje Foi dia de criar toda a lógica para gerenciar as ofertas feitas pelos usuários, fiz os "Joins" para recuperar dados ligado entre várias tabelas e fiz todos os endponts e métodos necessários
Também fiz algumas alteraçôes em classes que já estavam prontas, visando uma melhor otimização e usabilidade do sistema.

Dia 6/100
Construção de API Rest com C# - Continuação
Hoje Foi dia de estudar e praticar a implementação de interfaces, que auxilia na arquitetura do sistema e facilita a compreensão do código, uma vez que as interfaces estabelecem contratos a serem abstraídos nas classes.
Aproveitei também e me aprofundei no conhecimento sobre Task, Async e Await, quando usa-los e porque usa-los.

Dia 7/100
Construção de API Rest com C# - Continuação
Injeção de dependência, esse foi o tema de hoje.
Já tinha usado em outros projetos, porem mais como copia de algo que eu não sabia exatamente o porque, mas hoje tive a oportunidade de estudar a fundo o porque de se usar injeção de dependência no projeto, quais os tipos e quando usar cada uma. E logicamente, já coloquei em prática!

Dia 8/100
Construção de API Rest com C# - Continuação
authentication and authorization
Hoje implementei Token no projeto, estudei bastante essa questão de autorização, autenticação e como implementar um token JWT.
Ate aqui nesse ponto do projeto, foi a parte mais desafiadora para mim, visto que só havia utilizado outras poucas vezes o JWT e sempre acompanhando alguma aula.
Mas esta ai, funcionando como deveria e melhor que isso, agora tenho um maior conhecimento sobre assunto para aplica-lo posteriormente.

Dia 9/100
Construção de API Rest com C# - Continuação
Dia de corrigir bugs...
Hoje foi dia de analisar todo o projeto, já que ele esta quase completo na parte do back-end. Aproveitei pra corrigir alguns erros, entender tudo oque esta acontecendo no projeto, como a questões de rotas, injeção de dependência e também as autenticações.

Dia 10/100
Construção de API Rest com C# - Continuação
O Projeto esta funcionando...
Porém, a intenção não é só funcionar, é entender tudo oque está acontecendo e aproximar o máximo que eu puder e conseguir de um projeto mais "comercial". Seguindo essa linha, hoje me dediquei a refatorações, e a pequenos ajustes que possam melhorar o nível do projeto.

Dia 11/100
Construção de API Rest com C# - Continuação
Hoje foi dia de trabalhar melhorando a estrutura do projeto, seguindo o conselho do Huam Benvenutti dividi a aplicação em vários projetos menores, separando em camadas. Também estou padronizando o idioma usado no projeto.
É uma parte trabalhosa pois muda as referencias, tem que refazer oque já estava pronto, porém o propósito não é só fazer, mas sim entender oque estou fazendo e buscar fazer o mais próximo possível de uma aplicação "real".

Dia 12/100
Construção de API Rest com C# - Continuação
Dizem que grandes alterações dão trabalho...
E comigo não seria diferente. Diante das grandes mudanças estruturais que fiz no projeto, agora utilizando uma abordagem de design de software mais próxima do Domain-Driven Design (DDD), tive vários problemas por não ter começado o projeto já pensando nisso,
mas aos poucos estou ajeitando e principalmente entendendo o papel de cada camada, como fica a disposição dos arquivos e o porque desse disposição.
Logo logo partimos pras próximas etapas.

Dia 13/100
Construção de API Rest com C# - Continuação
Hoje continue trabalhando na reestruturação do projeto, organizei oque ficará na pasta "services", também oque fará parte dos "repositorys",
suas respectivas interfaces e implementações.

Dia 14/100
Construção de API Rest com C# - Continuação
Depois de muitos bugs, mas também muito aprendizado, a API está novamente funcionando.
Tive um erro com injeção de dependência que me custou muito tempo, porém aprendi.
Vamos adiante...

Dia 15/100
Construção de API Rest com C# - Continuação
Terminei as alterações estruturais, organizei os repositório no github, inclusive adicionando um .gitignore para evitar subir arquivos desnecessário.
Como é gostoso ver o código assim mais limpo, bem estrutura e acima de tudo entendendo oque está acontecendo.

Dia 16/100
Construção de API Rest com C# - Continuação
Hoje comecei a trabalhar os testes unitários com XUnit, os testes unitários são uma forma de testar a lógica do projeto, isolando pequenas partes de código, onde podemos verificar se os retornos são realmente oque foi previsto e ate mesmo se não tem algo de errado passando no sistema.
É sem sombra de dúvida uma parte importantíssima, pois além de identificar problemas no código, também auxiliamos numa possível refatoração, onde podemos verificar com facilidade se a lógica ainda está correta.
O testes ainda facilitam a vida do desenvolvedor, possibilitando que ele não precise testar manualmente todo o código sempre que realizar alguma mudança.

Dia 17/100
Construção de API Rest com C# - Continuação
Hoje continuei com os testes unitários, implementando testes para cada método do projeto. É um processo lento, mas importantíssimo e que vai evitar problemas futuros.

Dia 18/100
Construção de API Rest com C# - Continuação
Hoje implementei os testes para a classe de gerenciamento das ofertas.
Foquei em aprender mais sobre o framework MOQ, que cria objetos simulados para realização dos testes, Ele gera dados fictícios para preencher os objetos, possibilitando verificar o comportamento da aplicação

Dia 19/100
Construção de API Rest com C# - Continuação
Hoje finalizei as classes de testes, ainda vou dispensar mais um tempo pra digerir todo esse conteúdo, ver onde precisa melhora, mas por hora estou contente, estou avançando.

Dia 20/100
Construção de API Rest com C# - Continuação
Finalizado hoje a parte dos testes unitários, onde além de criar os métodos de testes, aprender sobre vários frameworks e pacotes de teste, eu realmente testei esses métodos, mudando parâmetros, depurando e analisando o fluxo dos testes.
Não que esteja 100%, porém tive um crescimento enorme nessa área e com certeza voltarei a estuda-la mais a frente para utilizar em novos projetos.

Dia 21/100
Construção de API Rest com C# - Continuação
Hoje iniciei o Front-end, Decidi utilizar o Blazor para seguir dentro do .Net.
O Blazor é uma ferramenta que acho super interessante e que tem um potencial enorme de crescimento, podendo ser usado tanto no lado do servidor, quando no lado do cliente e ainda em aplicações mobile em conjunto com o Maui.
Criei as interfaces, os serviços, a injeção de dependência e comecei de fato a desenvolver a interface do usuário.

Dia 22/100
Construção de API Rest com C# - Continuação
Hoje criei a interface para visualizar os leiloes criados, e um componente para visualizar os itens de algum leilão especifico.
Gostaria de frisar a importância de fazer o front-end(ou pelo menos entender um pouco de quem vai utilizar o serviço criado). Durante a construção da api eu fiz testes com o swagger, com postman e xunit com sucesso, porém ao fazer a solicitação a api utilizando o blazor tive problemas, depurei, demorei algum tempo pra entender o problema e no final precisei fazer um ajuste na api para que tudo funcionasse da melhor forma.

Dia 23/100
Construção de API Rest com C# - Continuação
Está tomando forma...
Hoje foquei na listagem dos leilões e seus itens, Trabalhei com a divisão dos componentes, também com os Data Bindig e cascading parameter buscando diminuir as chamadas a api.

Dia 24/100
Construção de API Rest com C# - Continuação
Hoje foquei em construir as demais classes de serviços para o front-end da aplicação, sempre buscando formas de deixar o código mais clean, facilitando uma futura manutenção e compreensão de quem for analisa-lo.
Ajustei também alguns retornos da api, algo que vi que poderia ser melhorado quando testei no front-end a busca pelos leilões, buscando facilitar a vida de quem vai consumir a api.

Dia 25/100
Construção de API Rest com C# - Continuação
Hoje trabalhei na parte de autenticação do usuário, criei uma classe que a partir do login, chama o endpoint da api que gera o token jwt e com esse token faz a autenticação do usuário para que ele possa fazer o uso da api de acordo com sua função.
A terceira imagem mostra algo comum no desenvolvimento, na primeira vez que tentei chamar a api numa parte que precisava de autenticação, recebi um erro de não autorizado e por isso não consegui acessar a página. Logicamente, esse erro vai ser tratado para que o usuário seja direcionado a página de login/cadastro ao invés de receber um erro.

Dia 26/100
Construção de API Rest com C# - Continuação
Criação dos componentes para listar os usuários e para criar novos leilões,
utilizei o @bind-Value para alterar os valores e defini as validações do formulário utilizando recursos da própria linguagem como o ValidationMessage.

Dia 27/100
Construção de API Rest com C# - Continuação
hoje foi dia da criação de mais componentes, utilização do EditForm, do CascadingParameter, alguns bugs, um bom tempo entendendo o porque e pra que.

Dia 28/100
Construção de API Rest com C# - Continuação
Hoje continue nos componentes para dar os lances, alguns bugs levaram tempo, mas no final entendi onde podia ser melhorado e agora esta funcionando. O usuário somente quando esta logado pode dar o lance. 
Ainda falta melhorar o design, mas por enquanto estou focado no funcionamento ideal do sistema.

Dia 29/100
Construção de API Rest com C# - Continuação
Hoje comecei a trabalhar na parte de autorização do no front-end, o intuído é de que cada nível de usuário possa acessar somente aquilo que lhe compete. Para isso no back-end ao cadastrar o usuário é necessário passar um atribuído de categoria do usuario, essas categorias já foram pré-definidas em enum com três opções. Ao acessar nosso front, o usuário que ainda não logou visualiza um mínimo de informações para que ele seja inspirado a se cadastrar ou logar e assim de acordo com seu nível dentro do sistema, seja direcionado as telas e funções que lhe competem.
Obs.: O usuário ao se cadastrar possui automaticamente o nível "stantard", podem depois chegar ao nível de vip. 

Dia 30/100
Construção de API Rest com C# - Continuação
Hoje continuei a parte de autenticação no blazor, criei uma classe que recebe o token vindo da api, salva no localStorage do navegador e recupera os parâmetros desse token para que o usuário seja autorizado na aplicação, em seguida utilizei a tag <Authorized> para controlar a renderização dos componentes de acordo com seus status de autenticação.

Dia 32/100
Construção de API Rest com C# - Continuação
Algo de interessante no dia de hoje, foi quando me deparei ao criar os componentes de login e de cadastro, o blazor tem EditForm, que é um componente nativo para trabalhar com formulários, porém dentro do EditForm não contem o InputPassword, e com isso eu não conseguia mascarar as senhas. A solução foi criar um componente que herda p InputBase e implementar o método abstrato TryParseValueFromString para mascarar nossa senha, e utilizamos o evento OnChange para atualizarmos o estado do componente.

Dia 33/100
Construção de API Rest com C# - Continuação
Hoje trabalhei com uma espécie de "rotas" dentro do front-end, não é bem a parte de roteamento do blazor, por isso as aspas, mas defini tudo oque cada usuário vai visualizar de acordo com o seu nível de permissão. Utilizei o AuthorizeView juntamente com as Roles para ocultar ou exibir componentes específicos, assim limitando ou liberando o acesso do usuário determinadas partes da aplicação.
Vemos na primeira imagem que está logado um usuário de nível standard e por isso ele não tem acesso ao botão "Criar Leilão", já na segunda imagem, é a mesmo página, porém por ser um usuário Vip, agora já se tem o botão.

Dia 34/100
Construção de API Rest com C# - Continuação
Hoje foi dia de ajustes no front-end, pequenos detalhes que fazem a diferença para uma melhor experiência do usuário. 

Dia 35/100
Construção de API Rest com C# - Continuação
Reta Final!!!
Ainda implementando alguns recursos, mas principalmente testando... Hoje corrigi um erro que gerava ao tentar cadastrar u novo usuário, como forma de otimização, a pagina de castro se tornou um componente que se comunica diretamente com a pagina de login e assim que o usuário se cadastra o login já é feito automaticamente e ele é redirecionado ao dashboard.

Dia 36/100
Construção de API Rest com C# - Continuação
Hoje criei mais alguns componentes seguindo a lógica de visualização apenas o usuário estiver logado e de acordo com o seu nível, utilizei a classe "AuthenticationStateProvider" para recuperar o id do token do usuário autenticado e assim mostrar as informações de leilões referentes a esse usuário.

Dia 37/100
Construção de API Rest com C# - Continuação
Hoje trabalhei na parte de edição dos leilões e dos itens, o interessante é que o usuário vip ou administrador pode visualizar todos os leilões e itens disponíveis, porém logicamente ele só pode editar aquilo que foi criado por ele mesmo. Mesmo eu já tendo bloqueado isso na API, eu não quis deixar co que o sistema fizesse requisições de algo que não deveria, então tive que criar algumas lógicas para verificação de token e do usuário que criou o leilão para que o botão de edição só apareça ao usuário que realmente possa editar. 

Dia 38/100
Construção de API Rest com C# - Continuação
Nem tudo são flores...
Hoje enquanto implementava mais algumas funções do sistema, me deparei com algo que já estava resolvido a alguns dias atrás, o token não esta sendo enviado para o back-end, então quando tento utilizar endpoints protegidos por autenticação eu não tenho acesso, mesmo depois de ter um token no front-end. Com calma vou identificar a raiz do problema, e aproveitar essa oportunidade para compreender ainda mais esse caminho da autenticação.

Dia 39/100
Construção de API Rest com C# - Continuação
Coisas que só acontecem com quem programa...
Hoje foquei em corrigir o erro na autenticação, o usuário recebia o token no front, porem quando acessava a API, retornava não autorizado. Depois de um bom tempo, erro descoberto, ao passar o token nos parâmetros para a solicitação da API, a palavra bearer estava com o "b" minúsculo, enquanto a API esperava o "B" maiúsculo. Corrigido o problema, sistema funcionando novamente e aproveitei para criar o componente modal para exibir uma resposta a solicitação do cliente. 

Dia 40/100
Construção de API Rest com C# - Continuação
Criação do componente para gerenciamento das ofertas, e ajustes nos componentes de dar lance e editar itens leilões, após o inicio do leilão não é permitido editar itens e só a data de encerramento do leilão pode ser alterada.

Dia 41/100
Construção de API Rest com C# - Continuação
Hoje continuei no componente para gerenciamento das ofertas, além disso, revisei o código buscando formas de refatorar o mesmo, buscando uma melhor legibilidade e melhor performance para o sistema.

Dia 42/100
Construção de API Rest com C# - Continuação
CRUD completo...
Hoje fiz a parte de exclusão de leilões, assim finalizando os 4 elementos que compõe o CRUD que são Criação, Leitura, Edição e Exclusão. Agora só vou terminar a lógica de algumas operações dentro do site e finalizar o projeto.
Lembrando que o objetivo não é um site com o melhor design, e sim integrar o back-end criado com o front e fazer funcionar da melhor forma, aprendendo cada conceito para que isso aconteça.

Dia 43/100
Construção de API Rest com C# - Continuação
Hoje fiz a parte de exclusão de itens, além de testes e ajustes no sistema.
Esta quase finalizado!

Dia 44/100
Construção de API Rest com C# - Continuação
Finalizando os últimos componentes, mas quero hoje mostrar a estrutura de pastas que utilizei em todo o projeto. Busquei estudar um pouco sobre DDD e entender um pouco sobre a divisão dos arquivos. Sei que ainda não esta 100%, mas acredito que consegui fazer uma boa divisão das pastas e facilitar uma futura manutenção ou refatoração.

Dia 45/100
Construção de API Rest com C# - Continuação
Hoje foi dia de testes e pequenos ajustes para garantir que esta tudo funcionando como deveria estar.
Foi uma jornada incrível, em alguns momentos mais difíceis outros mais fáceis, o mais importante foi o aprendizado nesse que foi um projeto único, um projeto que não segui um curso, nem um cronograma feito por outra pessoa, peguei meus conhecimentos e dicas da comunidade e busquei fazer algo que funcionasse e sempre aprendendo coisas novas e aprofundando em determinados assuntos, logo logo postarei um vídeo de toda a aplicação.

Dia 46/100
Construção de API Rest com C# - Final

Finalizado o projeto

API construida com .NET onde pude colocar em pratica conceitos de DDD, OOP, Interfaces, Injeção de Dependência, Entity framework, Token JWT e outros recursos.

Front-end criado com Blazor webassembly, onde criei componentes, consumi a API, realizei o CRUD completo, utilizei também métodos de autenticação e autorização de acordo com o perfil do usuário.

Testes Unitários com XUnity.
Foi um dos projetos que mais me deu orgulho de fazer, pela complexidade, pelo fato de não estar seguindo um passo a passo feito por outra pessoa, pelo aprendizado que foi enorme e por der dado certo.
O foco não era o design, então o front-end não ficou o mais belo, porém atingi meus objetivos e estou pronto para um próximo desafio.

Dia 47/100
Criação de CHAT com BLAZOR e .NET 8
Hoje criei um projeto de um Chat com Blazor, onde aprendi mais sobre o SignalR, que é uma tecnologia que adiciona recursos de comunicação em tempo real aos aplicativos.

Dia 48/100
Iniciando mais um projeto - Sistema para Bares.
Hoje foi dia de estruturar o projeto. Pra começar criei um quadro no trello, onde conseguirei gerenciar melhor as tarefas. E então comecei a definir os requisitos para o projeto.
Linguagem Back-end: C#;
Injeção de dependência: Singleton;
Segurança: Token JWT;
Tecnologia para testes: XUnit;
Banco de dados: Sql Server;
Tecnologia Front-End: .Net MAUI Blazor
E nesse processo aproveitei para me aprofundar um pouco mais sobre Injeção de dependência, inclusive deixarei um link com um conteúdo que achei muito útil sobre o assunto: https://lnkd.in/d-K7YjPe

Dia 49/100
Sistema para Bares - Planejamento do projeto
Planejar o projeto é essencial para definir objetivos claros, alocação eficiente de recursos e minimizar riscos, garantindo o sucesso do desenvolvimento e a entrega de um produto de qualidade.
Hoje, dediquei tempo para definir que usarei a modelagem Domain-Driven Design (DDD) e para testes utilizarei Test-Driven Development (TDD), além de adotar o padrão estrutural da Arquitetura em Camadas.
O Domain-Driven Design (DDD), é uma abordagem de design de software que se concentra na modelagem do domínio de um problema de negócio complexo. O objetivo principal do DDD é criar um modelo de domínio rico e expressivo que reflita com precisão as regras de negócio e os conceitos fundamentais envolvidos.
O Test-Driven Development (TDD), ou Desenvolvimento Orientado a Testes, é uma prática de desenvolvimento de software que se concentra na criação de testes automatizados. A abordagem básica do TDD pode ser resumida em três passos principais: escrever um teste, fazer o teste passar e refatorar o código.
Ao combinar DDD e TDD, você pode desenvolver software que não apenas reflete com precisão os requisitos de negócios, mas também é robusto, modular e fácil de manter. Essa abordagem promove uma compreensão profunda do domínio do problema e garante que o código de produção seja validado por testes automatizados, resultando em um sistema mais confiável e de alta qualidade.
Por fim, a arquitetura em camadas divide o sistema em camadas lógicas distintas, como apresentação, lógica de negócios e acesso a dados. Isso promove a separação de preocupações e facilita a manutenção e a evolução do sistema.

Dia 50/100
Sistema para Bares - Planejamento do projeto
Hoje continuei a tarefa de planejar a aplicação.
Defini as Tabelas do banco de dados e seus relacionamentos e também esbocei a estrutura das camadas que compõe o back-end do projeto, juntamente com suas classes e métodos. Isso é importante para maximizar a produtividade, evitar retrabalho e com isso focar num melhor desenvolvimento.

Dia 51/100
Sistema para Bares - Planejamento do projeto
Hoje desenhei um esboço no figma do que será o projeto no front-end. O objetivo não foi design e sim, visualizar como será as telas, oque terá nelas, qual a lógica das rotas de acordo com o tipo de funcionário logado no sistema.
"Planejamento não é tempo perdido, e sim pensar grande, pensar no futuro, é otimizar o trabalho a frente"

Dia 52/100
Sistema para Bares - Planejamento do projeto
Hoje criei o projeto .Net para o back-end, toda a estrutura de pastas e biblioteca de classes e também criei as entidades que serão mapeadas para o banco de dados.

Dia 53/100
Sistema para Bares - Planejamento do projeto
Hoje criei as interfaces
Em resumo, criar interfaces no projeto promove uma arquitetura mais flexível, testável e modular, que é fundamental para o desenvolvimento de software de alta qualidade. Elas facilitam a manutenção, a extensão e a integração do código, além de promover boas práticas de design e princípios de engenharia de software.

Dia 54/100
Sistema para Bares - Planejamento do projeto
Hoje criei a conexão e conectei o projeto banco de dados SqlServer utilizando e entity framework. Houve alguns bugs no processo, que levou um pouco mais de tempo do que o previsto, mas tudo resolvido e novas experiências adquiridas.

Dia 55/100
Sistema para Bares - Planejamento do projeto
Hoje, desenvolvi um repositório genérico utilizando C# e o LINQ (Language Integrated Query). O LINQ é uma ferramenta poderosa que oferece expressividade e legibilidade ao escrever consultas de dados, garantindo segurança de tipo e integração perfeita com a linguagem. Além disso, o LINQ permite reutilizar código de forma eficiente, integrar-se a diversas fontes de dados e oferecer desempenho otimizado. Com esse repositório, agora tenho uma solução flexível e robusta para lidar com operações de CRUD em diferentes tipos de entidades de forma simples e eficaz.

Dia 56/100
Sistema para Bares - Continuação
Hoje continuei a criação dos repositórios. Vou citar abaixo 3 razões pela qual é importante a criação de repositórios de forma separada da lógica de negócios:
1 - Abstração do acesso a dados: Os repositórios fornecem uma camada de abstração entre a lógica de negócios e o banco de dados subjacente. Isso permite que a lógica de negócios trabalhe com objetos de domínio em vez de lidar diretamente com consultas SQL ou chamadas de banco de dados.
2 - Separação de preocupações: Ao usar repositórios, você separa as preocupações relacionadas ao acesso a dados do restante da aplicação. Isso facilita a manutenção e o teste da lógica de negócios sem se preocupar com os detalhes de implementação do acesso ao banco de dados.
3 - Reutilização de código: Os repositórios podem encapsular consultas e operações comuns do banco de dados, tornando-as facilmente reutilizáveis em toda a aplicação. Isso promove a consistência e evita a duplicação de código.

Dia 57/100
Sistema para Bares - Continuação
Hoje finalizei os repositórios e iniciei a construção das classes de serviços.

Dia 58/100
Hoje, desenvolvi algumas classes de serviços essenciais para o sistema, além de métodos genéricos para validações. Esses serviços fornecem uma camada de abstração que facilita a interação com os dados do sistema, enquanto as validações garantem a integridade e consistência dos dados, contribuindo para a confiabilidade da aplicação.

Dia 59/100
Hoje finalizei as classes de serviços, essas classes ajudam a desacoplar a camada de apresentação da camada de acesso aos dados, isso significa que a camada de apresentação não precisa conhecer os detalhes de como os dados são armazenados ou recuperados, permitindo maior flexibilidade e escalabilidade.

Dia 60/100
Hoje iniciei a criação das controllers, peças-chave na arquitetura de nossa aplicação. Elas serão responsáveis por receber as requisições dos clientes, encaminhá-las para os serviços apropriados e retornar as respostas adequadas.

Dia 61/100
Finalizei as controllers, buscando sempre a otimização do código, uma boa entrega e uma codificação limpa e organizada, favorecendo possíveis manutenções futuras.

Dia 62/100
Realizei testes com o Postman para garantir a eficácia da nossa API. Através desses testes, pude verificar o correto funcionamento das requisições, garantindo uma experiência fluida para nossos usuários. E logicamente fiz os ajustes necessários para que funcione tudo da forma como planejado.

Dia 63/100
Testes Unitários
Implementei classes de testes usando Xunit, a criação de testes é fundamental para garantir a qualidade do software. Além de verificar se o código funciona conforme o esperado, os testes nos ajudam a simular diferentes cenários e validar as regras de negócio.
Na imagem, veja que criei 2 testes para o mesmo método, um com o campo nome vazio e outro completo, é importante nos nossos testes, criarmos métodos que esperem receber erros para assim verificar se as validações da aplicação estão funcionando. 

Dia 64/100
Hoje realizei mais testes com o XUnit, algumas correções e alterações, uma dessas alterações foi a criação de uma classe para padronizar e simplificar as respostas as solicitações, fazendo com que não tenha que ser escrito em cada método a mesma resposta

Dia 65/100
Refatoração... Testes... Melhorias...
Experimentando na prática diferentes tipos de retornos e suas implementações. Esta é uma técnica muito importante de aprendizagem, onde você experimenta e vê na prática o que é melhor e as diferenças de um para o outro, onde você adquiri autoridade para falar mais sobre o assunto porque você não só ouviu falar, mas você experimentou de varias formas.

Dia 66/100
🚀 Mais um dia produtivo investido em testes unitários! 🧪💻
Hoje dediquei meu tempo a aprimorar os testes unitários em nosso projeto. Como desenvolvedor, sei da importância de garantir que nosso código funcione como esperado em todas as situações, e os testes unitários desempenham um papel crucial nesse processo.
Testes unitários bem elaborados não apenas validam o comportamento do código, mas também fornecem uma rede de segurança vital durante o desenvolvimento e a manutenção do software. Eles nos permitem detectar e corrigir problemas precocemente, evitando que se tornem bugs em produção e garantindo uma base sólida para futuras iterações do código.