using Dotenetcore_Demo;
using Dotenetcore_Demo.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSwaggerGen(options => {
//    options.IncludeXmlComments("D:\\Demo_Project\\Dotenetcore_Demo\\Dotenetcore_Demo\\obj\\Debug\\net6.0\\Dotenetcore_Demo.xml");
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DatabaseSetting>(
    builder.Configuration.GetSection("StudentDatabase"));

builder.Services.AddSingleton<StudentService>();
builder.Services.AddSingleton<DemoService>();
//builder.Services.AddSingleton<>
var app = builder.Build();
app.UseCors(options =>
           options.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());
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
