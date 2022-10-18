using MerchanCountriesAngular.Core.Models;
using MerchanCountriesAngular.Data.Repositories;
using MerchanCountriesAngular.Data.Repositories.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<ICountryRepository, CountryRepository>();

builder.Services.AddHttpClient("RestCountries", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://merchancountriesapi:5224/api/");

    //Here, we define when the API requires token.
    // httpClient.DefaultRequestHeaders.Add(
    //     HeaderNames.Accept, "");
    // httpClient.DefaultRequestHeaders.Add(
    //     HeaderNames.UserAgent, "");
});

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}else{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
