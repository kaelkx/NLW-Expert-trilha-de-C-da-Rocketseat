﻿using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistIserWithEmail(string email);

    User GetUserByEmail(string email);
}
