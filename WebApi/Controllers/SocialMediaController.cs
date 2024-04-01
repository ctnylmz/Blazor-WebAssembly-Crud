using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpPost("Add")]
        public IActionResult Add(SocialMedia socialMedia)
        {
            var result = _socialMediaService.Add(socialMedia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(SocialMedia socialMedia)
        {
            var result = _socialMediaService.Delete(socialMedia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(SocialMedia socialMedia)
        {
            var result = _socialMediaService.Update(socialMedia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _socialMediaService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = _socialMediaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
