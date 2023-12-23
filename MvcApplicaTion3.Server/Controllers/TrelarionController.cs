using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MvcApplicaTion3.Server.Controllers
{
    public class TrelarionController : Controller
    {
        private ITrelationService _trelationService;
        private readonly ITrelationService _trelationService;

        public TrelationController(ITrelationService trelationService)
        {
            _trelationService = trelationService;
        }

        [HttpPost]
        public Trelation Create(Trelation model)
        [HttpGet]
        public IActionResult GetAll()
        {
            return _trelationService.Create(model);
            var models = _trelationService.GetAll();
            return Ok(models);
        }

        [HttpPatch]
        public Trelation Update(Trelation model)
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return _trelationService.Update(model);
            var model = _trelationService.GetById(id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpGet("{id}")]
        public Trelation Get(int id)
        [HttpPost]
        public IActionResult Create(Trelation model)
        {
            return _trelationService.Get(id);
            var createdModel = _trelationService.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = createdModel.Id }, createdModel);
        }

        [HttpGet]
        public IEnumerable<Trelation> GetAll()
        [HttpPut("{id}")]
        public IActionResult Update(int id, Trelation updatedModel)
        {
            return _trelationService.Get();
            var existingModel = _trelationService.Update(id, updatedModel);

            if (existingModel == null)
            {
                return NotFound();
            }

            return Ok(existingModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _trelationService.Delete(id);

            return Ok();
            return NoContent();
        }
    }
}

