using assignment_four.Models;

var builder = WebApplication.CreateBuilder(args);

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

app.MapGet("/api/animals/", () => AnimalManager.GetAnimals());

app.MapGet(
    "/api/animals/{id}",
    (short id) =>
    {
        return AnimalManager.GetAnimalById(id);
    }
);

app.MapPost(
    "/api/animals/{id}",
    (short id, string name, int weight, AnimalCategory animCategory, string color) =>
    {
        AnimalManager.AddAnimal(id, name, weight, animCategory, color);
    }
);

app.MapDelete(
    "/api/animals/{id}",
    (short id) =>
    {
        AnimalManager.RemoveAnimal(id);
    }
);

app.MapPost(
    "/api/animals/edit/",
    (short id, string? name, int? weight, AnimalCategory? animCategory) =>
    {
        AnimalManager.EditAnimal(id, name, weight, animCategory);
    }
);

app.MapGet(
    "/api/animals/visit/{id}",
    (short id) =>
    {
        AnimalManager.GetVisits(id);
    }
);

app.MapPut(
    "/api/animals/visit/",
    (short id, DateTime date, string description, int priceInCents) =>
    {
        AnimalManager.AddVisit(id, date, description, priceInCents);
    }
);

app.UseHttpsRedirection();

app.Run();
