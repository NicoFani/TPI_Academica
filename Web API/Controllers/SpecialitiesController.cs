using Datos.Models;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialitiesController : ControllerBase
    {
        private readonly EspecialidadesService _specialityService;

        public SpecialitiesController(IConfiguration configuration)
        {
            _specialityService = new EspecialidadesService(configuration.GetConnectionString("defaultConnection")!);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Especialidade>> GetAllSpecialities()
        {
            var especialidade = _specialityService.GetAllEspecialidade();
            return Ok(especialidade);
        }
        [HttpGet("{id}")]
        public ActionResult<Especialidade> GetSpecialityById(int id)
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