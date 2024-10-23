using Datos.Model;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComissionsController : ControllerBase
    {
        private readonly ComissionsService _comissionService;

        public ComissionsController(ComissionsService comissionService)
        {
            _comissionService = comissionService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Comissions>> GetAllComissions()
        {
            var comissions = _comissionService.GetAllComissions();
            return Ok(comissions);
        }
        [HttpGet("{id}")]
        public ActionResult<Comissions> GetComissionById(int id)
        {
            try
            {
                var comission = _comissionService.GetComissionById(id);
                return Ok(comission);
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddComission(Comissions comission)
        {
            try
            {
                _comissionService.AddComission(comission);
                return Ok("Comission added");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult UpdateComission(Comissions comission)
        {
            try
            {
                _comissionService.UpdateComission(comission);
                return Ok("Comission updated");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteComission(int id) {
            try
            {
                _comissionService.DeleteComission(id);
                return Ok("Comission deleted");
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
