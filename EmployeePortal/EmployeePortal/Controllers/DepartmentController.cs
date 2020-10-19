using System.Collections.Generic;
using System.Linq;
using EmployeePortal.DataContext;
using EmployeePortal.HandlerInterfaces;
using EmployeePortal.Handlers;
using EmployeePortal.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    [Route("api/department")]
    [ApiController]
    [AllowAnonymous]
    public class DepartmentController:ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IDepartmentHandler _departmentHandler;

        public DepartmentController(ApplicationDbContext context,IDepartmentHandler departmentHandler)
        {
            _context = context;
            _departmentHandler = departmentHandler;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<IEnumerable<Department>> GetAllEmployee()
        {

            return Ok(_context.Departments.ToList());
        }

        [HttpGet("{id}")]
        [Route("")]
        public ActionResult<IEnumerable<Department>> GetEmployeeById(int id)
        {

            return Ok(_context.Departments.Find(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Department> Create([FromBody] Department department)
        {
           return _departmentHandler.Create(department);
            //var dep= _context.Add(department).Entity;
            //_context.SaveChanges();
            //return dep;

        }

        [HttpPost]
        [Route("update")]
        public ActionResult<Department> Update([FromBody] Department departmnet)
        {

            return Ok(_context.Update(departmnet));
        }
    }
}
