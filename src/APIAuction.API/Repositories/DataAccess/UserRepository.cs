using APIAuction.API.Contracts;
using APIAuction.API.Entities;

namespace APIAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
  private readonly APIAuctionDbContext _dbContext;
  public UserRepository(APIAuctionDbContext dbContext) => _dbContext = dbContext;

  public bool ExistUserWithEmail(string email)
  {
    return _dbContext.Users.Any(user => user.Email.Equals(email));
  }

  public User GetUserByEmail(string email)
  {
    return _dbContext.Users.First(user => user.Email.Equals(email));
  }
}
