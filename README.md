# Pokémon Cards API

API REST em C# (.NET 8) com CRUD completo de cartas Pokémon, Dockerizada e publicada gratuitamente no Render.

---

## 🔗 Link Online

[https://pokemon-cards-api-r39r.onrender.com](https://pokemon-cards-api-r39r.onrender.com)

---

## 📌 Endpoints

| Método | Rota                  | Descrição                   |
|--------|-----------------------|-----------------------------|
| GET    | `/api/pokemon`        | Lista todos os Pokémons     |
| GET    | `/api/pokemon/{id}`   | Retorna um Pokémon por ID   |
| POST   | `/api/pokemon`        | Cria um novo Pokémon        |
| PUT    | `/api/pokemon/{id}`   | Atualiza um Pokémon         |
| DELETE | `/api/pokemon/{id}`   | Remove um Pokémon           |

---

## 🛠️ Tecnologias

- .NET 8
- Entity Framework Core
- SQL Server (local ou remoto)
- Docker
- Swagger
- Render.com (deploy gratuito)

---

## 🐞 Problemas e Soluções

### 1. `404 Not Found` no Render

✅ Resolvido adicionando a rota raiz no `Program.cs`:

```csharp
app.MapGet("/", () => "API de Cartas Pokémon online!");
```

---

### 2. Erro 500 devido a banco local

✅ Solução: usar banco **remoto gratuito** como Railway ou Planetscale.

---

### 3. Porta 8080 em uso no Docker

✅ Solução: pare containers existentes com:

```bash
docker ps
docker stop <id>
```

---

## 📦 Docker e Deploy

```bash
# Build da imagem Docker
docker build -t pokemon-cards-api .

# Executar localmente
docker run -d -p 8080:8080 pokemon-cards-api
```

Deploy via `render.yaml` no Render.com com plano gratuito.

---

## 💾 Banco de Dados

- Desenvolvido com SQL Server local
- Pode ser migrado para PostgreSQL ou MySQL em nuvens gratuitas como:
  - Railway
  - Planetscale

---

## 📁 Estrutura

```
Controllers/
Models/
Data/
Program.cs
Dockerfile
render.yaml
```

---

## 🙋 Autor

Jeferson de Souza Martins  
44 anos • Desenvolvedor Backend Jr (.NET / Azure / SQL / React) • PCD (cordas vocais)

---
