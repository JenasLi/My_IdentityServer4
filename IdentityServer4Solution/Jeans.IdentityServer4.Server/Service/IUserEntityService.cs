﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.IdentityServer4.Server.Service
{
    public interface IUserEntityService
    {
        Task ValidateAsync(string userName, string password);
    }
}
