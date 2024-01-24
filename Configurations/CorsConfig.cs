namespace SimpleAPI.Configurations
{
    public static class CorsConfig
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Development", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

                options.AddPolicy("Production", builder => builder.WithOrigins("https://localhost:900").AllowAnyHeader().AllowAnyMethod());
            });
            return builder;
        }
    }
}
