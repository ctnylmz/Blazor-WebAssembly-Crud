using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpPost("Add")]
        public IActionResult Add(Feature feature)
        {
            var result = _featureService.Add(feature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Feature feature)
        {
            var result = _featureService.Delete(feature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Feature feature)
        {
            var result = _featureService.Update(feature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _featureService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = _featureService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
