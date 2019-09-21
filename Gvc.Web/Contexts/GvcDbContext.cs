using Gvc.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gvc.Web.Contexts
{
    public class GvcDbContext : IdentityDbContext<ApplicationUser>
    {

        public GvcDbContext(DbContextOptions<GvcDbContext> options)
            : base(options)
        {
        }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }
    }
}