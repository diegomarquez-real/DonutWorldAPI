using DonutWorldAPI.Data;
using DonutWorldAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonutWorldAPI.Controllers
{
    [Route("api/donuts")]
    [ApiController]
    public class DonutWorldController : ControllerBase
    {
        private readonly IDonutWorldRepo _repository;

        public DonutWorldController(IDonutWorldRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Donut>> GetAllDonutes()
        {
            var donutItems = _repository.GetAllDonuts();

            return Ok(donutItems);
        }

        [HttpGet("{id}", Name ="GetDonutById")]
        public ActionResult<Donut> GetDonutById(int id)
        {
            var donutItem = _repository.GetDonutById(id);

            if(donutItem != null)
            {
                return Ok(donutItem);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Donut> CreateDonut(Donut donut)
        {
            _repository.CreateDonut(donut);
            _repository.SaveChanges();

            return Ok(donut);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDonut(int id)
        {
            var donutFromRepo = _repository.GetDonutById(id);

            if (donutFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteDonut(donutFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDonut(int id, Donut donut)
        {
            var donutFromRepo = _repository.GetDonutById(id);

            if(donutFromRepo == null)
            {
                return NotFound();
            }

            _repository.UpdateDonut(donut);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
