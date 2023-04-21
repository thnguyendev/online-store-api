using Microsoft.Extensions.Logging.AzureAppServices;
using OnlineStore.Core.Extensions;
using OnlineStore.Infrastructure.Extensions;

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
    builder.AddAzureWebAppDiagnostics();
    builder.Services.Configure<AzureFileLoggerOptions>(options =>
    {
        options.RetainedFileCountLimit = 14;
    });
});
var logger = loggerFactory.CreateLogger<Program>();
try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add logging
    builder.Logging.ClearProviders();
    builder.Logging.AddConsole();
    builder.Logging.AddAzureWebAppDiagnostics();
    builder.Services.Configure<AzureFileLoggerOptions>(options =>
    {
        options.RetainedFileCountLimit = 14;
    });

    // Add services to the container.
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
    });
    builder.Services.AddControllers();
    builder.Services.AddHealthChecks();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Service extensions
    builder.Services.AddInfrastructureServices(builder.Configuration);
    builder.Services.AddCoreServices(builder.Configuration);

    // Add background jobs

    // Create app
    var app = builder.Build();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseExceptionHandler("/error");
    app.UseCors();
    app.MapControllers();
    app.MapHealthChecks("/healthcheck");

    // Configure app

    await app.RunAsync();
}
catch (Exception ex)
{
    logger.LogCritical(ex, "App terminated unexpectedly");
}