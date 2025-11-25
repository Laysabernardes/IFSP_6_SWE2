# 🧑‍💻 CBTSWE2-ADS 671: Trabalho Prático 04
## Desenvolvimento de Web API com ASP.Net Core e CRUD em Página Web

**Desenvolvido por:** Laysa e Lucas

---

## 📋 Sumário

1.  [Objetivo](#1-objetivo)
2.  [Estrutura da Solução](#2-estrutura-da-solução)
3.  [Configuração de Ambiente](#3-configuração-de-ambiente)
4.  [Demonstração da Aplicação](#4-demonstração-da-aplicação)
5.  [Funcionalidades Implementadas (CRUD)](#5-funcionalidades-implementadas-crud)

---

## 1. Objetivo

Este projeto implementa uma solução completa que integra uma **Web API RESTful em ASP.Net Core** com um **Cliente Web (MVC)**. O foco é demonstrar a capacidade de desenvolver *endpoints* CRUD e consumir esses serviços através de uma interface web, utilizando Entity Framework Core para a persistência de dados.

---

## 2. Estrutura da Solução

A solução é composta por três projetos principais:

| Projeto | Tecnologia | Finalidade |
| :--- | :--- | :--- |
| **`WEB_API`** | ASP.Net Core | Servidor API. Contém *Controllers* (`/api/produtos`), `AppDbContext`, e Repositórios para acesso ao banco. |
| **`MVC`** | ASP.Net Core MVC | Cliente Web. Interface de usuário (Views) e lógica de consumo da API via `HttpClient`. |
| **`Models`** | .NET Class Library | Contém a entidade `Produto` e modelos de dados compartilhados. |

---

## 3. Configuração de Ambiente

### A. Conexão com o Banco de Dados

A persistência de dados utiliza Entity Framework Core (EF Core) com SQL Server.

**`appsettings.json` (WEB_API)**:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=ACER;Initial Catalog=CBTSWE2_TP04;Integrated Security=True;TrustServerCertificate=True"
}
````

### B. Injeção de Dependência

A injeção de dependência do repositório (`IProdutoRepository`) foi configurada no `Program.cs` da API para garantir que o `ProdutosController` possa ser inicializado corretamente.

```csharp
// Program.cs (WEB_API)
builder.Services.AddScoped<WEB_API.Repositories.IProdutoRepository, WEB_API.Repositories.ProdutoRepository>();
```

### C. Captura da Página Inicial

![Captura de Tela da Página Inicial da Aplicação MVC](link_da_imagem_da_tela_inicial)

---

### D. Dependências Principais (Pacotes NuGet)

Os seguintes pacotes NuGet são essenciais:

* **`Microsoft.EntityFrameworkCore.SqlServer`**: Provedor do EF Core para interação com o SQL Server.
* **`Microsoft.EntityFrameworkCore.Tools`**: Para o gerenciamento de Migrations.
* **`Microsoft.Extensions.Http`**: Utilizado no projeto MVC para a injeção de `HttpClient`.

### E. Integração de Funcionalidades via DLLs (Biblioteca de Classes) 🎯

O requisito de **Integração com DLLs** é atendido pela Biblioteca de Classes **`Models`**. Esta DLL centraliza a definição da entidade **`Produto`** e é referenciada pela `WEB_API` e pelo projeto `MVC`, garantindo o reuso e a separação de responsabilidades dos modelos de dados.

## 4. Demonstração da Aplicação 🚀

O projeto deve ser executado com os projetos **`WEB_API`** e **`MVC`** configurados para iniciar simultaneamente no Visual Studio (configuração de Múltiplos Projetos de Inicialização).

**Vídeo de Demonstração (CRUD)**

[Link para o Vídeo de Demonstração](Link_do_video_aqui) 

---

## 5. Funcionalidades Implementadas (CRUD) 🛠️

O sistema gerencia a entidade `Produto`, expondo os seguintes *endpoints* na API e suas respectivas telas no cliente MVC:

### C - Create (Criação de Produto)
* **Endpoint:** `POST /api/produtos`
* **Descrição:** Adiciona um novo produto. O `PrecoVendaFinal` é calculado pela API (`PrecoCusto` + 15% de *markup*).

### R - Read (Listagem e Busca)
* **Endpoints:** `GET /api/produtos` e `GET /api/produtos/search?nome={valor}`
* **Descrição:** Exibe todos os produtos na página principal e permite filtrar a lista por nome utilizando o parâmetro de busca.

### U - Update (Atualização de Produto)
* **Endpoint:** `PUT /api/produtos/{id}`
* **Descrição:** Permite editar os dados de um produto existente. O cálculo do preço de venda final é refeito no servidor.

### D - Delete (Remoção de Produto)
* **Endpoint:** `DELETE /api/produtos/{id}`
* **Descrição:** Remove um produto do banco de dados a partir do seu identificador.
