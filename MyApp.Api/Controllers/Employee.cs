using System.Runtime.InteropServices;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entites;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
        [HttpGet("")]
        public async Task<IActionResult>GetAllEmployees()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);

        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeByID([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeebyIDQuery(employeeId));

            return Ok(result);
        }

        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new EmployeeUpdateCommand(employeeId, employee));
            return Ok(result);
        }

        //[HttpDelete("{employeeId}")]
        //public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        //{
        //    var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
        //    return Ok(result);
        //}

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
    }
}
