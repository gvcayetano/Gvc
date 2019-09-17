using System.Collections.Generic;
using Gvc.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gvc.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetSocialMedia()
        {
            var socialMediaLinks = new List<SocialMediaLinks>()
            {
                new SocialMediaLinks()
                {
                    Url = "http://bit.ly/2zhCJ4T",
                    FontAwesomeClass = "fab fa-facebook",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "http://bit.ly/2MB63Ml",
                    FontAwesomeClass = "fab fa-github",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "http://bit.ly/2PdP9Fz",
                    FontAwesomeClass = "fab fa-instagram",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "http://bit.ly/2ZpLBQq",
                    FontAwesomeClass = "fab fa-linkedin",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "http://bit.ly/2HikHUr",
                    FontAwesomeClass = "fab fa-twitter",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "https://stackshare.io/gvcayetano/my-stack",
                    FontAwesomeClass = "fas fa-layer-group",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "https://hub.docker.com/u/gvcayetano",
                    FontAwesomeClass = "fab fa-docker",
                    Username = "@gvcayetano"
                },
                new SocialMediaLinks()
                {
                    Url = "https://www.twitch.tv/iamjayjay",
                    FontAwesomeClass = "fab fa-twitch",
                    Username = "@iamjayjay"
                }
            };
            return Ok(socialMediaLinks);
        }
    }
}