// Importa namespaces necessários
using PokemonCardsAPI.Data; // Contexto do banco de dados
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🛠️ Adiciona serviços para Controllers
builder.Services.AddControllers(); // Habilita uso de Controllers

// 🔗 Configura o Entity Framework com SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Usa a Connection String do appsettings.json

// 🧪 Swagger: ferramenta para documentar e testar a API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ⚙️ Middleware: configurações que processam as requisições

app.UseSwagger();    // Ativa Swagger no projeto
app.UseSwaggerUI();  // Mostra a interface Swagger

//app.UseHttpsRedirection(); // Redireciona requisições HTTP para HTTPS (segurança)

app.UseAuthorization();    // Prepara o app para autenticação/autorização (pode configurar depois)

app.MapControllers();      // Mapeia os Controllers para que os endpoints funcionem

Console.WriteLine("🚀 API PokemonCardsAPI iniciando...");

app.Run(); // Inicia a aplicação