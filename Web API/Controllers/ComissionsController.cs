using Datos;
using Datos.Models;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComissionsController : ControllerBase
    {
        private readonly Context _context;
        private readonly ComisionesService _comissionService;

        public ComissionsController(Context context)
        {
            _context = context;
            _comissionService = new ComisionesService(context);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Comisione>> GetAllComissions()
        {
            var comissions = _comissionService.GetAllComissions();
            return Ok(comissions);
        }
        [HttpGet("{id}")]
        public ActionResult<Comisione> GetComissionById(int id)
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
        public ActionResult AddComission(Comisione comission)
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
        public ActionResult UpdateComission(Comisione comission)
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
