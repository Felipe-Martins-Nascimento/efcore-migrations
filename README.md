# PraticaMigration

API de gerenciamento de jogadores e posições de futebol, construída com C#.NET, Entity Framework Core e MySQL.  
O projeto foca em **migrations**, seed de dados e boas práticas em desenvolvimento de APIs.

---

## 🚀 Tecnologias
- C#  
- .NET 
- Entity Framework Core  
- MySQL   

---

## 📌 Funcionalidades
- CRUD de **Jogadores**  
- CRUD de **Posições**  
- **Seed de dados** inicial (ex.: Neymar, Casemiro, Thiago Silva, Alisson)   


---

### ▶️ Como rodar o projeto
Coloca uma seção de instrução rápida:

```md
## ▶️ Como rodar o Migration no projeto

# Restaurar pacotes
dotnet restore

# Aplicar migrations
dotnet ef database update

# Rodar a API
dotnet run

📚 *Aprendizados*:  
- Esse projeto foi feito para treinar migrations e boas práticas com EF Core
- Criar seed de dados automático  
- Configurar relacionamento entre entidades (Jogador ↔ Posição)  
- Estrutura de projeto .NET organizada
