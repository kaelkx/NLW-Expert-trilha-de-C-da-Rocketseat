using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAcecess;

public class UserRepository : IUserRepository
{

    private readonly RocketseatAuctionDbContext _dbContext;
    public UserRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

    public Boolean ExistIserWithEmail(string email) 
    {
       return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
