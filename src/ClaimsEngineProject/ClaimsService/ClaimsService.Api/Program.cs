using ClaimsService.Application;
using ClaimsService.Application.Abstraction;
using ClaimsService.Application.DTOs;
using ClaimsService.Application.Mapping;
using ClaimsService.Application.Validators;
using ClaimsService.Infrastructure; // required for SwaggerGen
using FluentValidation;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Problem details middleware
builder.Services.AddProblemDetails();

// ✅ Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Claims API",
        Version = "v1"
    });
});

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(ClaimProfile).Assembly);

// Register FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<CreateClaimDtoValidator>();

// Register application services
builder.Services.AddInfrastructure(builder.Configuration);

// Register repository (infra)
builder.Services.AddApplication();

var app = builder.Build();

// Exception handling
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler();
}


// ✅ Enable Swagger in dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Claims API V1");
    });
}

// Demo endpoints
string[] summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("test", () => "This is a test");

// Claims endpoints
app.MapPost("/claims", async (
    CreateClaimDto claimDto,
    IClaimsService claimService,
    IValidator<CreateClaimDto> validator
    ) =>
{
    var validation = await validator.ValidateAsync(claimDto);
    if (!validation.IsValid)
        return Results.ValidationProblem(validation.ToDictionary());

    var id = await claimService.CreateClaimAsync(claimDto);
    return Results.Created($"/claims/{id}", new { id });
});

app.MapGet("/claims/{id:int}", async (int id, IClaimsService service) =>
{
    var claim = await service.GetByIdAsync(id);
    if (claim is null)
    {
        return Results.NotFound(new
        {
            Message = $"Claim with Id {id} was not found.",
            RequestedId = id,
            Timestamp = DateTime.UtcNow
        });
    }

    return Results.Ok(claim);
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
