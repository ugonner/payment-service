using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs.UserDTOs;
public class TokenDTO
{
    public string Token {get; set;}
    public string RefreshToken {get; set;}
}