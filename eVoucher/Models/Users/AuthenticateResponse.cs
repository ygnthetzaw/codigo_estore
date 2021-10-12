using System.Text.Json.Serialization;
using eVoucher.Entities;

namespace eVoucher.Models.Users
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string jwtToken, string refreshToken)
        {
            Id = user.Id;
            FullName = user.FullName;
            Username = user.Username;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}