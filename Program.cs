using SimpleAPI.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddApiConfig()
    .AddCorsConfig()
    .AddDbContextConfig()
    .AddIdentityConfig()
    .AddSwaggerConfig();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else
{
    app.UseCors("Production");
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
