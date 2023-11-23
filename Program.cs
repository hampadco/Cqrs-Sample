using Microsoft.EntityFrameworkCore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});



//DbContext
//builder.Services.AddDbContext<Context>();
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStudent,Student>(); 
builder.Services.AddScoped<ILog,Log>();
builder.Services.AddScoped<IUnitOfWok,UnitOfWok>();
//Addscope

//MediatR
builder.Services.AddMediatR(typeof(SaveStudentCommand).Assembly);
builder.Services.AddMediatR(typeof(GetAllStudentQuery).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



//CORS
app.UseCors("AllowAll");


app.UseHttpsRedirection();



app.UseAuthorization();

app.MapControllers();

app.Run();
