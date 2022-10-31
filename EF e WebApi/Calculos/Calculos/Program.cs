namespace Calculos {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // Ele so vai usar o Swagger se tiver esse de Desenvolvimento. Que esta localizado nas propriedades
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            // Usará Redirecionamento.
            app.UseHttpsRedirection();
            // Usará
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}