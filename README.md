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
