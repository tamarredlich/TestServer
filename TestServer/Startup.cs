//using Microsoft.EntityFrameworkCore;
namespace TestServer
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        private readonly string AllowSpecificOrigins = "_AllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                string AllowedOrigins = Configuration.GetValue<string>("AllowedHosts");
                options.AddPolicy(AllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins(AllowedOrigins).AllowAnyMethod().AllowAnyHeader();
                    });
            });

            //services.AddDbContext<gimsqlContext>(option =>
            //     option.UseLazyLoadingProxies()
            //     .UseSqlServer(Configuration.GetSection("ConnectionStrings").GetValue<string>("BLConnectionString")
            //     , opt => opt.EnableRetryOnFailure(
            //      maxRetryCount: 5,
            //      maxRetryDelay: TimeSpan.FromSeconds(1),
            //      errorNumbersToAdd: null)));

            services.AddControllers();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Frame-Options", "DENY");
                context.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                context.Response.Headers.Add("Cache-Control", "no-cache");
                await next();
            });

            app.UseRouting();

            app.UseCors(AllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
