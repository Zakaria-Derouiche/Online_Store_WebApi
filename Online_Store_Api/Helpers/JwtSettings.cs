using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Online_Store_Api.Helpers
{
    public class JwtSettings
    { 
        public string Key { get; set; }
        public string Issuer { get; set; }

        public string Audience { get; set; }

        public string DurationInDays { get; set; }
    }
}
