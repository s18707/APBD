using Cw11.Models;
using Cw11.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IDbService service;

        public DoctorController(IDbService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetDoctor()
        {
            var result = service.GetDoctors();
            return Ok(result);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            var result = service.UpdateDoctors(doctor);

            //if (result == null)
            //    return BadRequest("Zły id doktora!");
            //if (result == 2)
            return Ok(result);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult InsertDoctor(Doctor doctor)
        {
            var result = service.InsertDoctors(doctor);

            if (result == null)
            {
                return BadRequest("Doctor o takim id juz istnieje!");
            }

            return Ok("Doctor został dodany!");

        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteDoctor(Doctor doctor)
        {
            var result = service.DeleteDoctors(doctor);

            if (result == null)
            {
                return BadRequest("Nie istnieje doctor o podanym id!");
            }

            return Ok("Doctor o podanym id został usunięty!");

        }
    }
}
