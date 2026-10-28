# ExoApi - CRUD de Projetos

Web API em ASP.NET Core (.NET 6) com Entity Framework e SQL Server.
Atividade de Desenvolvimento de APIs (SENAI) - Atividade 04.

## Endpoints

| Método | Rota | Descrição | Resposta |
|---|---|---|---|
| GET | /api/projetos | Lista os projetos | 200 |
| POST | /api/projetos | Cadastra um projeto | 201 |
| GET | /api/projetos/{id} | Busca por Id | 200 / 404 |
| PUT | /api/projetos/{id} | Atualiza um projeto | 204 |
| DELETE | /api/projetos/{id} | Remove um projeto | 204 |

## Como executar

1. Execute o script `cria-db.sql` no SSMS.
2. Ajuste a connection string em `Contexts/ExoContext.cs`.
3. `dotnet restore`, `dotnet build`, `dotnet run`
4. Teste em `https://localhost:7154/api/projetos` (Insomnia ou Postman).
