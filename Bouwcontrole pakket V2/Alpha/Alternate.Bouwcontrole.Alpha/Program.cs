using Alternate.Bouwcontrole.Alpha.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IOnderdelenService, OnderdelenService>();
builder.Services.AddScoped<IControleService, ControleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Home wordt Bouwcontrole: de alpha start meteen op het scanscherm
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bouwcontrole}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
