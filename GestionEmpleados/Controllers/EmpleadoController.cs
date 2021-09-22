using GestionEmpleados.Interfaces;
using GestionEmpleados.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmpleados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private IBaseRepository<Empleados> Respo;

        public EmpleadoController(IBaseRepository<Empleados> _respo)
        {
            Respo = _respo;

        }
        /// <summary>
        /// Obtener todos los empleados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Empleados> Get()
        {
            return Respo.GetAll();
        }

        /// <summary>
        /// Obtenet empleado por ID
        /// </summary>
        /// <param name="CodEmpleado"></param>
        /// <returns></returns>
        [HttpGet("{CodEmpleado}")]
        public Empleados Get (int CodEmpleado)
        {
            return Respo.GetMany(w => w.CodEmpleado == CodEmpleado).FirstOrDefault();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Empleados empleado)
        {

            try
            {
                Respo.Insert(empleado);
                return Ok(empleado);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Put([FromBody] Empleados empleado)
        {

            try
            {
                Respo.Update(empleado);
                return Ok(empleado);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }



        [HttpDelete("{CodEmpleado}")]
        public ActionResult Delete(int CodEmpleado)
        {

            try
            {
                Respo.Delete(w => w.CodEmpleado == CodEmpleado);
                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }



    }
}
