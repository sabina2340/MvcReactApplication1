using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace MvcApplicaTion3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    public class TgroupController : ControllerBase
    {
        private ITgroupService _tgroupService;
        private readonly ITgroupService _tgroupService;

        public TgroupController(ITgroupService tgroupService)
        {
            _tgroupService = tgroupService;
        }
        public TgroupController(ITgroupService tgroupService)
        {
            _tgroupService = tgroupService;
        }

        [HttpPost]
        public Tgroup Create(Tgroup model)
        {
            return _tgroupService.Create(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var models = _tgroupService.GetAll();
            return Ok(models);
        }

        [HttpPatch]
        public Tgroup Update(Tgroup model)
        {
            return _tgroupService.Update(model);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var model = _tgroupService.GetById(id);

            [HttpGet("{id}")]
            public Tgroup Get(int id)
            if (model == null)
            {
                return _tgroupService.Get(id);
                return NotFound();
            }

            [HttpGet]
            public IEnumerable<Tgroup> GetAll()
            {
                return _tgroupService.Get();
            }
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tgroupService.Delete(id);
            [HttpPost]
            public IActionResult Create(Tgroup model)
            {
                var createdModel = _tgroupService.Create(model);
                return CreatedAtAction(nameof(GetById), new { id = createdModel.Id }, createdModel);
            }

            return Ok();
            [HttpPut("{id}")]
            public IActionResult Update(int id, Tgroup updatedModel)
            {
                var existingModel = _tgroupService.Update(id, updatedModel);

                if (existingModel == null)
                {
                    return NotFound();
                }

                return Ok(existingModel);
            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _tgroupService.Delete(id);
                return NoContent();
            }
        }
    }