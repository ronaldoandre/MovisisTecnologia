# ProvaMovisisTecnologia

O desafio abaixo consiste em executar algumas tarefas básicas de programação com ASP.NET C#.

--------------------------
TAREFA 1: Banco de Dados
Para este desafio, foi criado um banco de dados SQL SERVER vazio, que está online e é exclusivo para sua utilização.
A string de conexão é: "*******";

Crie as tabelas abaixo, que serão utilizadas na tarefa seguinte:
Tabela CLIENTE
- ID (incremento automático)
- NOME
- TELEFONE
- ID_CIDADE
- APELIDO
- DATA_NASCIMENTO

Tabela CIDADE
- ID
- NOME
- UF

A criação pode ser feita através de um SGBD ou via comandos no projeto C#.

--------------------------
TAREFA 2: Criar um servidor ASP.NET C# em branco.

Implementar as seguintes API's REST JSON:
- Inclusão de Cidade;
- Alteração de Cidade: colunas NOME;
- Exclusão de Cidade: pelo ID;
- Busca de Cidade: NOME.

- Inclusão de Cliente;
- Alteração de Cliente: colunas NOME e/ou TELEFONE;
- Exclusão de Cliente: pelo ID;
- Busca de Cliente: NOME

Os parâmetros de entrada podem ser via Query Parameters, ou via JSON request.
O retorno dos serviços devem seguir o seguinte modelo:
{"Sucesso":1,"Mensagem":"Mensagem genérica para o usuário","Data":[]}

Quando se tratar do serviço de busca de cidade ou cliente, listar os dados no array Data.
