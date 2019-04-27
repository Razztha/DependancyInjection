using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(this.employeeService.GetEmployees());
        }
    }
}