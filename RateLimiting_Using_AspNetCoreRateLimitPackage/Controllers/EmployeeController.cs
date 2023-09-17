using Microsoft.AspNetCore.Mvc;
using RateLimiting_Using_AspNetCoreRateLimitPackage.Models;

namespace RateLimiting_Using_AspNetCoreRateLimitPackage.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet("getAllEmployees")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return GetEmployeesDeatils();
        }

        [HttpGet("getEmployeeById/{id}")]
        [Produces("application/json")]
        public Employee GetEmployeeById(int id)
        {
            return GetEmployeesDeatils().Find(e => e.Id == id);
        }

        private List<Employee> GetEmployeesDeatils()
        {
            return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "Test",
                LastName = "Name",
                EmailId ="Test.Name@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Test",
                LastName = "Name1",
                EmailId ="Test.Name1@gmail.com"
            }
        };
        }
    }

}
