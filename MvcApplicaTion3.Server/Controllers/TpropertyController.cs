using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MvcApplicaTion3.Server.Controllers
{
    public class TpropertyController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        [Route("api/[controller]")]

            private ITpropertyService _tpropertyService;
            private readonly ITpropertyService _tpropertyService;

            public TpropertyController(ITpropertyService tpropertyService)
            {
                _tpropertyService = tpropertyService;
            }

            [HttpPost]
            public Tproperty Create(Tproperty model)
        [HttpGet]
            public IActionResult GetAll()
            {
                return _tpropertyService.Create(model);
                var models = _tpropertyService.GetAll();
                return Ok(models);
            }

            [HttpPatch]
            public Tproperty Update(Tproperty model)
        [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                return _tpropertyService.Update(model);
                var model = _tpropertyService.GetById(id);

                if (model == null)
                {
                    return NotFound();
                }

                return Ok(model);
            }

            [HttpGet("{id}")]
            public Tproperty Get(int id)
        [HttpPost]
            public IActionResult Create(Tproperty model)
            {
                return _tpropertyService.Get(id);
                var createdModel = _tpropertyService.Create(model);
                return CreatedAtAction(nameof(GetById), new { id = createdModel.Id }, createdModel);
            }

            [HttpGet]
            public IEnumerable<Tproperty> GetAll()
        [HttpPut("{id}")]
            public IActionResult Update(int id, Tproperty updatedModel)
            {
                return _tpropertyService.Get();
                var existingModel = _tpropertyService.Update(id, updatedModel);

                if (existingModel == null)
                {
                    return NotFound();
                }

                return Ok(existingModel);
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _tpropertyService.Delete(id);

                return Ok();
                return NoContent();
            }
        }
    }

