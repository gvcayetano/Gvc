using Gvc.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gvc.Data.Contexts
{
    public class GvcDbContext : IdentityDbContext<ApplicationUser>
    {

        public GvcDbContext(DbContextOptions<GvcDbContext> options)
            : base(options)
        {
        }
    }
}