﻿using BlackYellow.MVC.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackYellow.MVC.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        User GetUserByNamePassword(User user);
    }
}
