# 🏥 CLINICADOCMAIS API

<p align="center">
  <img src="https://img.shields.io/badge/.NET-9-blue?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/ASP.NET-Core-purple?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Entity%20Framework-Core-green?style=for-the-badge" />
  <img src="https://img.shields.io/badge/MySQL-Database-orange?style=for-the-badge&logo=mysql" />
</p>

<p align="center">
  🚀 API para gerenciamento de pacientes desenvolvida com ASP.NET Core
</p>

---

## 📌 Sobre o Projeto

A **CLINICADOCMAIS API** é uma aplicação desenvolvida em **C# com ASP.NET Core** que permite o gerenciamento completo de pacientes, utilizando arquitetura MVC e banco de dados MySQL.

---

## 📚 Tabela de Conteúdos

* [🚀 Tecnologias](#-tecnologias)
* [⚙️ Pré-requisitos](#️-pré-requisitos)
* [📦 Instalação](#-instalação)
* [🔧 Configuração](#-configuração)
* [▶️ Execução](#️-execução)
* [💡 Funcionalidades](#-funcionalidades)
* [🧰 Comandos Úteis](#-comandos-úteis)
* [🔄 Git](#-git)
* [🛠 Troubleshooting](#-troubleshooting)
* [📄 Licença](#-licença)

---

## 🚀 Tecnologias

* ⚙️ ASP.NET Core 9
* 🗄️ Entity Framework Core
* 🐬 MySQL
* 💻 .NET CLI

---

## ⚙️ Pré-requisitos

Antes de começar, instale:

* [.NET SDK](https://dotnet.microsoft.com/)
* MySQL Server
* Git

Verifique instalação:

```bash
dotnet --version
dotnet --info
```

---

## 📦 Instalação

```bash
# Clonar repositório
git clone <URL_DO_REPOSITORIO>

# Entrar na pasta
cd CLINICADOCMAIS

# Restaurar dependências
dotnet restore
```

---

## 🔧 Configuração

Edite o arquivo `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=clinicadb;User=root;Password=senha;"
}
```

Aplicar migrations:

```bash
dotnet ef database update
```

---

## ▶️ Execução

```bash
dotnet run
```

📍 A aplicação estará disponível em:

```
https://localhost:5001
```

---

## 💡 Funcionalidades

✨ Cadastro de pacientes
🔍 Consulta de registros
✏️ Atualização de dados
❌ Remoção de pacientes
🌐 API RESTful

---

## 🧰 Comandos Úteis

```bash
dotnet --help
dotnet --list-sdks
dotnet --list-runtimes
```

---

## 🔄 Git

### Configuração

```bash
git config --global user.name "Seu Nome"
git config --global user.email "email@exemplo.com"
```

### Fluxo básico

```bash
git status
git add .
git commit -m "mensagem"
```

### Branches

```bash
git checkout -b nova-branch
git merge nova-branch
```

### Remoto

```bash
git push origin main
git pull
```

---

## 🛠 Troubleshooting

❗ Erro no MySQL

* Verifique usuário/senha
* Confirme se o serviço está ativo

❗ Erro no .NET

* Rode `dotnet restore`
* Confirme versão do SDK

---

## 📄 Licença

📝 Este projeto está sob a licença MIT.

---

## ⭐ Apoie o Projeto

Se esse projeto te ajudou:

⭐ Dê uma estrela no repositório
🤝 Contribua com melhorias
📢 Compartilhe com outros devs

---
