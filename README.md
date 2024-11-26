## Visão Geral
O projeto será desenvolvido com ASP.NET Core (versão compatível com .NET 8), utilizando Entity Framework Core para manipulação de dados, e implementará WebSockets para notificações em tempo real. O design será orientado a objetos, seguindo os princípios SOLID, para garantir manutenibilidade e escalabilidade.

## Requisitos Funcionais
### Autenticação
  * Registrar usuario
  * Fazer login
    
### CRUD de Postagens:
  * Listar todas as postagens.
  * Criar novas postagens.
  * Editar postagens existentes.
  * Excluir postagens.
    
### Notificações em Tempo Real:
  Quando uma nova postagem for criada, os usuários conectados recebem uma notificação via WebSockets.

### Persistência de Dados:
  Utilizar Entity Framework Core e um banco de dados PostgreSQL.
