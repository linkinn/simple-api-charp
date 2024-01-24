namespace SimpleAPI.Configurations
{
    public static class ApiConfig
    {
        public static WebApplicationBuilder AddApiConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            return builder;
        }
    }
}
