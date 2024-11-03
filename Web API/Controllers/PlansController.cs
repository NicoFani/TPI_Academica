﻿using Datos.Models;
using Microsoft.AspNetCore.Mvc;
using Servicios;


namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlansController: ControllerBase
    {
        private readonly PlaneService _planService;

        public PlansController(IConfiguration configuration)
        {
            _planService = new PlaneService(configuration.GetConnectionString("defaultConnection")!);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Plane>> GetAllPlans()
        {
            var plan = _planService.GetAllPlane();
            return Ok(plan);
        }
        [HttpGet("{id}")]
        public ActionResult<Plane> GetPlanById(int id)
        {
            try
            {
                var plan = _planService.GetPlanById(id);
                if (plan == null)
                {
                    return NotFound($"No se encontró un plan con el ID {id}");
                }
                return Ok(plan);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }


        [HttpPost]
        public ActionResult AddPlan(Plane plan)
        {
            try
            {
                _planService.AddPlan(plan);
                return Ok("Plan added");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult UpdatePlan(int idPlan, Plane plan)
        {
            try
            {
                _planService.UpdatePlan(plan);
                return Ok("Plan updated");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeletePlan(int id)
        {
            try
            {
                _planService.DeletePlan(id);
                return Ok("Plan deleted");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
