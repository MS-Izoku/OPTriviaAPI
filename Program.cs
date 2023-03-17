// added global tag to make things easier, it allows things like the DataContext to be used anywhere in the project (instead of requiring it manually every time)
global using OPTriviaAPI.Data;
global using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region CORS setup using middleware

var MyOrigins = "corspolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

#endregion

// Add services to the container.

builder.Services.AddControllers();

// added manually to asscociate the Trivia DB with this project
builder.Services.AddDbContext<DataContext>(options => {
    // using the DefaultConnection key from the appsettings.json file
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS, this has to be here in this order (according to documentation)
// must be above UseAuthorization and MapControllers
app.UseCors(MyOrigins);

app.UseHttpsRedirection();



app.UseAuthorization();

app.MapControllers();

app.Run();
