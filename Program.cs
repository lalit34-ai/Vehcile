// Project Title        : Vehicle Management System
// author               : Lalit Kumar Yadav
// created at           : Aspire System Office
// last Modified Date   : 06.03.2023
// reviewed Date        : 23.02.2023
// reviewed By          : Anitha Manogaran

using Microsoft.EntityFrameworkCore;
using VEHCILE.Data;
using VEHCILE.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger=new LoggerConfiguration().WriteTo.Console().WriteTo.File("log.txt",rollingInterval:RollingInterval.Day).CreateLogger();
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddScoped<BusRepository>();
builder.Services.AddScoped<IData, inner>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options=>{
    options.Cookie.HttpOnly=true;
    options.ExpireTimeSpan=TimeSpan.FromMinutes(30);
    options.LoginPath="/Home/Log";
    options.AccessDeniedPath="/Home/AccessDenied";
});

// builder.Services
//     .AddAuthentication(options =>
//     {
//         options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//         options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//         options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//     })
//     .AddJwtBearer(o =>
//     {
//         o.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidIssuer = builder.Configuration["Jwt:Issuer"],
//             ValidAudience = builder.Configuration["Jwt:Audience"],
//             IssuerSigningKey = new SymmetricSecurityKey(
//                 Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
//             ),
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = false,
//             ValidateIssuerSigningKey = true
//         };
//     });

builder.Services.AddAuthentication();
var app = builder.Build();

app.UseAuthentication();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthorization();

// app.MapGet("/security/getMessage", () => "Hello World!").RequireAuthorization();
// app.MapPost(
//     "/security/createToken",
//     [AllowAnonymous]
//     (LoginEmployee employee) =>
//     {
//         if (employee.EmployeeID == "lalitkumar.ndit@gmail.com" && employee.Password == "Aspire@12")
//         {
//             var issuer = builder.Configuration["Jwt:Issuer"];
//             var audience = builder.Configuration["Jwt:Audience"];
//             var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);
//             var tokenDescriptor = new SecurityTokenDescriptor
//             {
//                 Subject = new ClaimsIdentity(
//                     new[]
//                     {
//                         new Claim("Id", Guid.NewGuid().ToString()),
//                         new Claim(JwtRegisteredClaimNames.Sub, employee.EmployeeID),
//                         new Claim(JwtRegisteredClaimNames.Email, employee.EmployeeID),
//                         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
//                     }
//                 ),
//                 Expires = DateTime.UtcNow.AddMinutes(5),
//                 Issuer = issuer,
//                 Audience = audience,
//                 SigningCredentials = new SigningCredentials(
//                     new SymmetricSecurityKey(key),
//                     SecurityAlgorithms.HmacSha512Signature
//                 )
//             };
//             var tokenHandler = new JwtSecurityTokenHandler();
//             var token = tokenHandler.CreateToken(tokenDescriptor);
//             var jwtToken = tokenHandler.WriteToken(token);
//             var stringToken = tokenHandler.WriteToken(token);
//             return Results.Ok(stringToken);
//         }
//         return Results.Unauthorized();
//     }
// );

app.UseAuthentication();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Log}/{id?}");

app.Run();
