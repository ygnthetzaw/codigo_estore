using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace eVoucher.Entities
{
    public class User : Base
    {
        public int Id { get; set; }
        public string FullName { get; set; }        
        public string Username { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}