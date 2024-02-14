using APIAuction.API.Contracts;
using APIAuction.API.Filters;
using APIAuction.API.Repositories;
using APIAuction.API.Repositories.DataAccess;
using APIAuction.API.Services;
using APIAuction.API.UseCases.Auctions.CreateOffer;
using APIAuction.API.UseCases.Auctions.GetCurrent;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.
                      Enter 'Bearer' [space] and then your token in the text input below;
                      Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header
                },
                new List<string>()
            }
        });

});

builder.Services.AddScoped<AuthenticationUserAttribute>();
builder.Services.AddScoped<ILoggedUser, LoggedUser>();
builder.Services.AddScoped<CreateOfferUseCase>();
builder.Services.AddScoped<GetCurrentAuctionUseCase>();
builder.Services.AddScoped<IAuctionRepository, AuctionRepository>();
builder.Services.AddScoped<IOfferRepository, OfferRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<APIAuctionDbContext>(options =>
{
    options.UseSqlite(@"Data Source=/home/user/Documents/auction.db");
});

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

