using System.Security.Cryptography;
using System.Text;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AccountController(UserManager<AppUser> userManager, ITokenService tokenService, IMapper mapper) : BaseApiController
{    

    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
    {
        if (await UserExists(registerDto.Username)) return BadRequest("Username is taken");

        var user = mapper.Map<AppUser>(registerDto);

        user.UserName = registerDto.Username.ToLower(); 

        var result = await userManager.CreateAsync(user, registerDto.Password);
        
        if(!result.Succeeded) return BadRequest(result.Errors);
            
        return new UserDto
        {
            Username = user.UserName,
            Token = tokenService.CreateToken(user),
            KnownAs = user.KnownAs,
            Gender = user.Gender
        };
    }

    private async Task<bool> UserExists(string username)
    {
        return await userManager.Users.AnyAsync(x => x.NormalizedUserName!.Equals(username.ToUpper()));
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        var user = await userManager.Users
        .SingleOrDefaultAsync(x => x.NormalizedUserName!.Equals(loginDto.Username.ToUpper()));

        if (user is null || user.UserName is null) return Unauthorized();

        var result = await userManager.CheckPasswordAsync(user, loginDto.Password);

        if(!result) return Unauthorized();

        return new UserDto
        {
            Username = user.UserName,
            Token = tokenService.CreateToken(user),
            KnownAs = user.KnownAs,
            Gender = user.Gender
        };
    }
}