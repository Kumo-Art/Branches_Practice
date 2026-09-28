using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Branches_Practice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Branches_Practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices  _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }


        [HttpGet("GetAll")]
        public ActionResult<List<string>> StudentGetAll()
        {
            return _studentServices.StudentGetAll();
        }

        [HttpGet("GetCount")]
        public ActionResult<int> GetCount()
        {
            return Ok(_studentServices.StudentCount());
        }
    }
}