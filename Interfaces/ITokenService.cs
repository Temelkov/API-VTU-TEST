using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
