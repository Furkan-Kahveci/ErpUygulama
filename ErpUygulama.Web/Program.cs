using ErpUygulama.Web.Data.Context;
using ErpUygulama.Web.Repositories;
using ErpUygulama.Web.Services.Erp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ErpUygulamaDbContext>();
builder.Services.AddScoped(typeof(IRepositories<>), typeof(Repsoitory<>));
builder.Services.AddScoped<IErpService, ErpService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
