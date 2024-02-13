using APIAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.Repositories;

public class APIAuctionDbContext : DbContext
{
  public DbSet<Auction> Auctions { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Offer> Offers { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=/home/user/Documents/auction.db");
  }
}