using ConsoleApp.Services;
using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

string connectionStringOrderDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Education\04._Datalagring\Data_Storage_Assignment\Infrastructure\Data\Orders\order_db.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

string connectionStringProductCatalog = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Education\04._Datalagring\Data_Storage_Assignment\Infrastructure\Data\ProductCatalog\ProductCatalog.mdf;Integrated Security=True;Connect Timeout=30";


var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    // OrderDB services
    services.AddDbContext<OrderDbContext>(x => x.UseSqlServer(connectionStringOrderDb));
    services.AddScoped<OrderRowRepository>();
    services.AddScoped<OrderRepository>();
    services.AddScoped<CustomerRepository>();
    services.AddScoped<AddressRepository>();
    services.AddScoped<PaymentMethodRepository>();
    services.AddScoped<DeliveryMethodRepository>();

    // ProductCatalog services
    services.AddDbContext<ProductCatalogContext>(x => x.UseSqlServer(connectionStringProductCatalog));
    services.AddScoped<ProductRepository>();
    services.AddScoped<BrandRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<SubCategoryRepository>();

    // Business logic services
    services.AddScoped<MenuService>();
    services.AddScoped<OrderService>();
    services.AddScoped<CustomerService>();
    services.AddScoped<ProductService>();

}).Build(); 
builder.Start();

//var addressRepository = builder.Services.GetRequiredService<AddressRepository>();
//var paymentMethodRepository = builder.Services.GetRequiredService<PaymentMethodRepository>();

var menuService = builder.Services.GetRequiredService<MenuService>();

menuService.Run();


