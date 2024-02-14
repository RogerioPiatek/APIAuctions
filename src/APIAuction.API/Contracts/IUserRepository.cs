using APIAuction.API.Entities;

namespace APIAuction.API.Contracts; 

public interface IUserRepository
{
  bool ExistUserWithEmail(string email);
  User GetUserByEmail(string email);
}