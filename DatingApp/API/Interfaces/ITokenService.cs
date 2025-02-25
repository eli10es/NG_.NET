using System;
using System.Reflection.Metadata;
using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
