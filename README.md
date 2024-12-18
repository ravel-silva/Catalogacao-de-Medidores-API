# Catalogação de Medidores API

Este projeto é uma API desenvolvida em **ASP.NET Core** para gerenciar a catalogação de medidores. A aplicação permite realizar operações CRUD (Create, Read, Update, Delete) em dois tipos de medidores: **Tria** e **Veri**. O objetivo é facilitar o armazenamento, consulta e manipulação dos dados de medidores de forma centralizada, utilizando **MySQL** como banco de dados.

---

## Funcionalidades

### Cadastro de Medidores
- **Endpoint:** `POST /CatalogarMedidor`
- Permite cadastrar novos medidores do tipo **Tria** e **Veri**.

### Visualização de Medidores
- **Endpoint:** `GET /CatalogarMedidor`  
  Retorna uma lista completa com todos os medidores cadastrados.
- **Endpoint:** `GET /CatalogarMedidor/tria`  
  Retorna apenas os medidores do tipo **Tria**.
- **Endpoint:** `GET /CatalogarMedidor/veri`  
  Retorna apenas os medidores do tipo **Veri**.

### Atualização de Medidores
- **Endpoint:** `PUT /CatalogarMedidor/tria/{id}`  
  Atualiza os dados de um medidor do tipo **Tria**.
- **Endpoint:** `PUT /CatalogarMedidor/veri/{id}`  
  Atualiza os dados de um medidor do tipo **Veri**.

### Exclusão de Medidores
- **Endpoint:** `DELETE /CatalogarMedidor/tria/{id}`  
  Remove um medidor do tipo **Tria** com base no seu identificador.
- **Endpoint:** `DELETE /CatalogarMedidor/veri/{id}`  
  Remove um medidor do tipo **Veri** com base no seu identificador.

---

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** ASP.NET Core
- **Banco de Dados:** MySQL
- **ORM:** Entity Framework Core com `Pomelo.EntityFrameworkCore.MySql`
- **Outras Dependências:**
  - Contexto de banco de dados: `MedidoresContext`
  - Modelos: `MedidoresTria` e `MedidoresVeri`

---

## Estrutura do Projeto

- **Controllers**:  
  Contém os controladores responsáveis por gerenciar as rotas e interações com os modelos.
  - `CatalogarMedidorController.cs`
  
- **Models**:  
  Define as estruturas de dados para os medidores.
  - `MedidoresTria`
  - `MedidoresVeri`
  
- **Data**:  
  Configuração e gerenciamento do contexto do banco de dados.
  - `MedidoresContext`

