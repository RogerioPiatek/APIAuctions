using APIAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.Repositories;

public class APIAuctionDbContext : DbContext
{
  public APIAuctionDbContext(DbContextOptions options) : base(options) {}

  public DbSet<Auction> Auctions { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Offer> Offers { get; set; }
}