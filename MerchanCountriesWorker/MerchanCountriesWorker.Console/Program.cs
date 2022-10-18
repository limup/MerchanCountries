using System.Security.AccessControl;
using MerchanCountriesWorker.Console;
using MerchanCountriesWorker.Console.Repositories;
using MerchanCountriesWorker.Core.Models;
using MerchanCountriesWorker.Data.Context;
using MerchanCountriesWorker.Data.Repositories;
using MerchanCountriesWorker.Data.Repositories.Abstractions;
using MerchanCountriesWorker.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Http;
using Microsoft.Net.Http.Headers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<ScopedBackgroundService>();
        services.Configure<MongoSettings>(context.Configuration.GetSection("MongoSettings"));

        services.AddScoped<IScopedProcessingService, DefaultScopedProcessingService>();
        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddScoped<IMongoDBContext, MongoDBContext>();
        services.AddScoped<ICountryRepository, CountryRepository>();

        services.AddHttpClient("RestCountries", httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");

            //Here, we define when the API requires token.
            // httpClient.DefaultRequestHeaders.Add(
            //     HeaderNames.Accept, "");
            // httpClient.DefaultRequestHeaders.Add(
            //     HeaderNames.UserAgent, "");
        }
        );
    })
    .Build();

host.Run();
