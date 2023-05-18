using Microsoft.AspNetCore.Identity;

namespace _1670_NhatMinh_Source.Models
{
    public class ApplicationRole:IdentityRole
    {
        public string? Descriptions { get; set; }
    }
}
