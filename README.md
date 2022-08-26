# MediatRSample
O projeto de uma API simples com um CRUD de pessoas, utilizando:
- Visual Studio Code
- .NET6
- SQL Server
- MediatR
- CQRS(Command Query Responsibility Segregation)
- Swagger 
- ASP.NET Core

Onde dentro da pasta Application, temos as pastas:
 - Commands: Onde serão definidos os objetos DTOs que representam uma ação a ser executada;
 - EventHandlers: Onde serão definidos objetos responsáveis por receber uma notificação gerada pelos Handlers;
 - Handlers: Onde serão definidos objetos responsáveis por receber as ações definidas pelos Commands;
 - Models: Onde serão definidas as entidades utilizadas pela aplicação;
 - Notifications: Onde serão definidos os objetos DTOs que representam notificações.
## Referência

 - [Introdução ao Swashbuckle e ao ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=netcore-cli)
 - [Implementar a camada de aplicativos de microsserviço usando a API Web](https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-application-layer-implementation-web-api)
 - [Implementando leituras/consultas em um microsserviço CQRS](https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/cqrs-microservice-reads)


## Rodando localmente

Clone o projeto

```bash
  git clone https://github.com/thiiagofernando/MediatRSample.git
```

Entre no diretório do projeto

```bash
  cd MediatRSample
```

Instale as dependências

```bash
  dotnet restore && dotnet build
```

Inicie a API

```bash
  dotnet run
```

