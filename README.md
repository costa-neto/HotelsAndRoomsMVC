# HotelsAndRoomsMVC




> Este projeto foi desenvolvido com o objetivo de avaliar a capacidade técnica, crítica e raciocínio lógico do candidato
ao construir uma funcionalidade de um produto. No caso, um sistema de gerenciamento de Hotéis e Quartos.

### Ajustes e melhorias

O projeto ainda está em desenvolvimento e as próximas atualizações serão voltadas nas seguintes tarefas:

- [x] Home-Page
- [x] Criação de Database e Migrations
- [x] CRUD de Hoteís
- [x] Crud de Quartos
- [ ] Manipular imagens


## 💻 Tecnologias

* [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [Bootstrap](https://getbootstrap.com)
* [JQuery](https://jquery.com)
* [SQL Server 2019](https://www.microsoft.com/pt-br/sql-server/sql-server-2019)
* [Docker](https://www.docker.com/)
* [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
* Você instalou a versão mais recente de `.Net`
* Você instalou a versão mais recente de `Docker`


## 🚀 Instalando <nome_do_projeto>

Para instalar o <nome_do_projeto>, siga estas etapas:

Clone o repositório e execute os comandos:
```
#se ainda não tiver o ef instalado.
dotnet tool install --global dotnet-ef
#subir um container docker para o banco de dados
docker run -e "ACCEPT_EULA=Y" -e "HotelsPass!" -p 1433:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/mssql/server:2019-latest                                                                                                                            
dotnet restore  
dotnet build
#para rodar as migrations no banco de dados
dotnet ef database update
```


## ☕ Usando <nome_do_projeto>

Para usar <nome_do_projeto>, siga estas etapas:

```
dotnet run
#ou
dotnet watch
#ou

```

<!-- MARKDOWN>
[product-screenshot]: repo-image/home.png