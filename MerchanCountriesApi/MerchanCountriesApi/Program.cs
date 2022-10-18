using MerchanCountriesApi.Core.Models;
using MerchanCountriesApi.Data.Context;
using MerchanCountriesApi.Data.Repositories;
using MerchanCountriesApi.Data.Repositories.Abstractions;
using MerchanCountriesApi.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoSettings>(options =>{
    options.Connection = builder.Configuration.GetSection("MongoSettings:Connection").Value;
    options.DatabaseName = builder.Configuration.GetSection("MongoSettings:DatabaseName").Value;
});

builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<IMongoDBContext, MongoDBContext>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();

builder.Services.AddHttpClient("RestCountries", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");

    //Here, we define when the API requires token.
    // httpClient.DefaultRequestHeaders.Add(
    //     HeaderNames.Accept, "");
    // httpClient.DefaultRequestHeaders.Add(
    //     HeaderNames.UserAgent, "");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
