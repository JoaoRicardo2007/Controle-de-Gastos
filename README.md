💰 API de Controle de Gastos (Personal Finance API)

API RESTful desenvolvida em C# com ASP.NET Core para gerenciamento de finanças e controle de gastos pessoais. O projeto foi construído aplicando boas práticas de desenvolvimento backend, separação de responsabilidades (Controller-Service) e documentação automatizada via Swagger.

🚀 Tecnologias Utilizadas

C# / .NET 10

ASP.NET Core Web API

Injeção de Dependências (Dependency Injection)

Swagger / OpenAPI (para documentação e testes interativos)

Git & GitHub (para controle de versão)

📂 Estrutura do Projeto

O projeto segue uma arquitetura limpa e organizada em camadas:

Controllers: Responsáveis por receber as requisições HTTP, validar o fluxo de entrada/saída e retornar as respostas adequadas (201 Created, 200 OK, 204 NoContent).

Services: Contém a regra de negócio da aplicação (ICarteiraService / CarteiraService), isolando a lógica de manipulação dos dados.

Models / DTOs: Estruturas de dados que representam os lançamentos financeiros.

⚙️ Como Executar o Projeto Localmente

Siga os passos abaixo para rodar a API na sua máquina:

Pré-requisitos: Certifique-se de ter o .NET SDK instalado.

Clone o repositório:

git clone https://github.com/seu-usuario/seu-repositorio.git
cd ControleDeGastos


Restaure as dependências e execute:

dotnet restore
dotnet run


Acesse a documentação (Swagger):
Com a aplicação rodando, abra o seu navegador e acesse:
http://localhost:<porta>/swagger

🛠️ Endpoints Disponíveis

GET /api/carteira - Lista todos os registros financeiros.

POST /api/carteira - Cria um novo lançamento de gasto/receita.

PUT /api/carteira/{id} - Atualiza um registro existente.

DELETE /api/carteira/{id} - Remove um lançamento pelo ID.
