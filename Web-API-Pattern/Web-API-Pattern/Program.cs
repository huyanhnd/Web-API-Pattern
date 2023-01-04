using Microsoft.EntityFrameworkCore;
using Web_API_Pattern.Controllers.Base;
using Web_API_Pattern.Domain.Repositories;
using Web_API_Pattern.Domain.Services;
using Web_API_Pattern.Persistence.Contexts;
using Web_API_Pattern.Persistence.Repositories;
using Web_API_Pattern.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    var services = builder.Services;

    services.AddCors();
    services.AddSwaggerGen();
    services.AddControllers().ConfigureApiBehaviorOptions(options =>
    {
        // Adds a custom error response factory when ModelState is invalid
        options.InvalidModelStateResponseFactory = InvalidModelStateResponseFactory.ProduceErrorResponse;
    });

    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("WebAPIPatternDB"));
    });

    // Life cycle DI: AddSingleton(), AddTransient(), AddScoped()
    services.AddScoped<IUnitOfWork, UnitOfWork>();

    services.AddScoped<ICategoryRepository, CategoryRepository>();
    services.AddScoped<IProductRepository, ProductRepository>();

    services.AddScoped<ICategoryService, CategoryService>();
    services.AddScoped<IProductService, ProductService>();

    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
