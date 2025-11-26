# 🧑‍💻 Trabalho Prático 04: CRUD de Tarefas (ASP.Net Core Web API + MVC)

**Desenvolvido por:** Laysa e Lucas

---

## 🎯 Objetivo

Implementar uma solução de gerenciamento de **Tarefas** (CRUD) que integra uma **Web API RESTful** com um **Cliente Web (MVC)**, utilizando **Entity Framework Core** para persistência de dados.

---

## 🏗️ Estrutura da Solução

O projeto é dividido em três componentes principais:

| Projeto | Finalidade |
| :--- | :--- |
| **`WEB_API`** | Backend: API RESTful com *endpoints* CRUD (`/api/tarefas`) e acesso ao banco (EF Core). |
| **`MVC`** | Frontend: Cliente Web para consumo da API via `HttpClient` e interface de usuário. |
| **`Models`** | **Biblioteca de Classes (DLL):** Define a entidade central **`Tarefa`**, compartilhada entre a API e o Cliente MVC. |

---

## 🔑 Destaque: Integração de Modelos via DLL

O requisito de integração via DLLs é atendido pelo projeto **`Models`**.

> **A DLL `Models`** centraliza a definição da entidade **`Tarefa`** e é referenciada pela **`WEB_API`** e pelo projeto **`MVC`**. Isso garante **reuso do modelo de dados** e a **separação de responsabilidades** (Separation of Concerns).

---

## ⚙️ Configuração Essencial

* **Persistência:** EF Core com SQL Server (definido em `appsettings.json` da WEB_API).
* **Injeção de Dependência (API):** O repositório (`ITarefaRepository`) é configurado no `Program.cs`:
    ```csharp
    builder.Services.AddScoped<WEB_API.Repositories.ITarefaRepository, WEB_API.Repositories.TarefaRepository>();
    ```
* **Execução:** Os projetos **`WEB_API`** e **`MVC`** devem ser configurados para iniciar simultaneamente no Visual Studio.

---

## 🛠️ Funcionalidades Implementadas (CRUD de Tarefas)

O sistema oferece as seguintes operações através de *endpoints* da API e suas telas correspondentes no MVC:

| Operação | Endpoint API | Descrição |
| :--- | :--- | :--- |
| **Create (C)** | `POST /api/tarefas` | Adiciona uma nova tarefa. |
| **Read (R)** | `GET /api/tarefas` | Lista todas as tarefas. |
| **Update (U)** | `PUT /api/tarefas/{id}` | Edita o título/descrição de uma tarefa. |
| **Alterar Status** | `POST /api/tarefas/{id}/status` | Alterna o status `Concluida` da tarefa. |
| **Delete (D)** | `DELETE /api/tarefas/{id}` | Remove uma tarefa pelo ID. |

---

## 🎬 Demonstração

![Teste Funcioanndo](./TP04.gif)
