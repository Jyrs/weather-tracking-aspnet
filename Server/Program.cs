using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeatherApp.Infrastructure.Other.MappingProfile;
using WeatherApp.Infrastructure.Data;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();


builder.Services.AddRazorPages();
builder.Services.AddBlazorBootstrap();
builder.Services.AddSwaggerGen();


////////////////////
///добавление конфига маппера
var mapperConfig = new MapperConfiguration(mc =>{mc.AddProfile(new MappingProfile());});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton<IMapper>(mapper);

//я не уверен на счет этой строчки
builder.Services.AddAutoMapper(typeof(MappingProfile));

/////////////////////


///добавление подключения к базе
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddDbContext<Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgre")));


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}
else
    app.UseExceptionHandler("/Error");


app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
