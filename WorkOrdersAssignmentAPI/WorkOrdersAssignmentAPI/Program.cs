using Microsoft.EntityFrameworkCore;
using WorkOrdersAssignmentAPI.BusinessLogic.Interfaces;
using WorkOrdersAssignmentAPI.BusinessLogic.Services;
using WorkOrdersAssignmentAPI.Repository.DatabaseContext;
using WorkOrdersAssignmentAPI.Repository.Interfaces;
using WorkOrdersAssignmentAPI.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<WorkOrdersDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITechnicians,TechniciansService>();

builder.Services.AddScoped<ITechniciansRepo, TechniciansRepoService>();

builder.Services.AddScoped<IWorkOrders, WorkOrdersService>();

builder.Services.AddScoped<IWorkOrdersRepo, WorkOrdersRepoService>();

var app = builder.Build();

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
