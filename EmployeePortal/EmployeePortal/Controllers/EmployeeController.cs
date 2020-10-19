using System.Collections.Generic;
using System.Linq;
using EmployeePortal.DataContext;
using EmployeePortal.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<IEnumerable<Employee>> GetAllEmployee()
        {

            return Ok(_context.Employees.ToList());
        }
        
        [HttpGet("{id}")]
        [Route("")]
        public ActionResult<IEnumerable<Employee>> GetEmployeeById(int id)
        {

            return Ok(_context.Employees.Find(id));
        }
        [HttpPost]
        [Route("")]
        public ActionResult<Employee> Create([FromBody]Employee employee)
        {

            return Ok(_context.Add(employee));
        }
        [HttpPost]
        [Route("update")]
        public ActionResult<Employee> Update([FromBody]Employee employee)
        {

            return Ok(_context.Update(employee));
        }
    }
}
