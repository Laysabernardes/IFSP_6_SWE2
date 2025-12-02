# 📚 CBTSWE2 -  PROVA II

## 💻 Desenvolvimento de Aplicação Integrada

Este projeto consiste no desenvolvimento de uma aplicação integrada, que utiliza **API (Backend)**, **Aplicação Web (Frontend)** e **Aplicação Desktop** para gerenciar dados de Usuário e Produto.

---

## 🎬 Demonstração

![Teste Funcioanndo](./PO2.gif)


---
## 🎯 Requisitos da Aplicação

O projeto deve ser composto pelos seguintes módulos e funcionalidades, totalizando **10,0 pontos**:

### 1. 💾 Banco de Dados e Modelo de Entidade (1,0)

O sistema deve possuir um banco de dados capaz de armazenar informações de duas entidades principais: **Usuário** e **Produto**.

#### 🧑‍💻 Entidade Usuário

| Atributo | Tipo | Descrição |
| :--- | :--- | :--- |
| `Id` | `int` | Identificador único do usuário. |
| `Nome` | `string` | Nome completo do usuário. |
| `Senha` | `string` | Senha de acesso. |
| `Status` | `boolean` | Indica se o usuário está `ativo` ou `inativo`. |

#### 📦 Entidade Produto

| Atributo | Tipo | Descrição |
| :--- | :--- | :--- |
| `Id` | `int` | Identificador único do produto. |
| `Nome` | `string` | Nome/descrição do produto. |
| `Preço` | `float` | Preço de venda do produto. |
| `Status` | `boolean` | Indica se o produto está `ativo` ou `inativo`. |
| `IdUsuarioCadastro` | `int` | **[Observação]** ID do Usuário que cadastrou o produto. |
| `IdUsuarioUpdate` | `int` | **[Observação]** ID do Usuário que realizou a última alteração (ex: mudar status). |

### 2. ⚙️ API com Métodos CRUD (4,0)

Uma **API** deve ser desenvolvida para fornecer acesso e manipulação dos dados.

* Deve conter **todos** os métodos **CRUD (Create, Read, Update, Delete/Inativar)** para a entidade **Usuário**.
* Deve conter **todos** os métodos **CRUD (Create, Read, Update, Delete/Inativar)** para a entidade **Produto**.

### 3. 🖥️ Aplicação Desktop para Gestão de Usuários (2,5)

A **gestão completa** da entidade **Usuário** (incluindo cadastro, listagem, edição e alteração de status/inativação) deve ser realizada **exclusivamente** através de uma **Aplicação Desktop**.

### 4. 🌐 Aplicação Web para Operações de Produto (2,5)

Todas as operações (CRUD) na entidade **Produto** devem ser executadas **exclusivamente** através de uma **Aplicação Web**.

* O acesso e as operações no Produto devem ser restritos a um **Usuário que possua acesso** à aplicação (autenticado).

---

## 🔑 Autores

**Aluna:** Laysa Bernardes Campos da Rocha - CB3024873  
**Aluno:** Lucas Lopes Cruz - CB3025284
