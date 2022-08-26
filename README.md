# MediatRSample
O projeto de uma API simples com um CRUD de pessoas, utilizando.
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
