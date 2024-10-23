using Datos.Model;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialitiesController : ControllerBase
    {
        private readonly SpecialitiesService _specialityService;

        public SpecialitiesController(SpecialitiesService specialityService)
        {
            _specialityService = specialityService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Specialities>> GetAllSpecialities()
        {
            var specialities = _specialityService.GetAllSpecialities();
            return Ok(specialities);
        }
        [HttpGet("{id}")]
        public ActionResult<Specialities> GetSpecialityById(int id)
        {
            try
            {
                var speciality = _specialityService.GetSpecialityById(id);
                return Ok(speciality);
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddSpeciality(string specialityDescription)
        {
            try
            {
                _specialityService.AddSpeciality(specialityDescription);
                return Ok("Speciality added");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult UpdateSpeciality(int id, string specialityDescription)
        {
            try
            {
                _specialityService.UpdateSpeciality(id, specialityDescription);
                return Ok("Speciality updated");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteComission(int id)
        {
            try
            {
                _specialityService.DeleteSpeciality(id);
                return Ok("Speciality deleted");
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
