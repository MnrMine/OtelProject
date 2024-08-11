

using Microsoft.AspNetCore.Identity;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.BusinessLayer.Concrete;
using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.DataAccessLayer.EntityFramework;
using OtelRezervasyon.EntityLayer.Concrete;
using OtelRezervasyon.MediatorPattern.Handlers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGalleryService, GalleryManager>();
builder.Services.AddScoped<IGalleryDal, EfGalleryDal>();

builder.Services.AddScoped<IRoomService, RoomsManager>();
builder.Services.AddScoped<IRoomsDal, EfRoomDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<INotificationService, NotificationManager>();
builder.Services.AddScoped<INotificationDal, EfNotificationDal>();

builder.Services.AddDbContext<HotelContext>();
builder.Services.AddScoped<SearchRoomQueryHandler>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<HotelContext>();

// Yeni eklemeler
builder.Services.AddHttpClient();

// Configuration'ý ekleyin (eðer zaten eklenmemiþse)
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
        name: "pdfexport",
        pattern: "{controller=JsPdf}/{action=PdfExport}/{id?}");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();