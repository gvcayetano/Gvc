using System.Collections.Generic;
using System.Threading.Tasks;
using Gvc.Data.Models;
using Gvc.Web.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gvc.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly GvcDbContext _gvcDbContext;

        public AboutController(
            GvcDbContext gvcDbContext
        )
        {
            _gvcDbContext = gvcDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SocialMediaLink>>> GetSocialMediaLinks()
        {
            return await _gvcDbContext.SocialMediaLinks.ToListAsync();
        }
    }
}