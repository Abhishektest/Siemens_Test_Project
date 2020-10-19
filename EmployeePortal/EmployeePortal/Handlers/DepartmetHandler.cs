using EmployeePortal.HandlerInterfaces;
using EmployeePortal.Model;
using EmployeePortal.Repositories;

namespace EmployeePortal.Handlers
{
    public class DepartmentHandler: IDepartmentHandler
    {
        private readonly DepartmentRepository _departmentRepository;

        public DepartmentHandler(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public Department Add(Department department)
        {
           return _departmentRepository.Add(department);
        }
        public Department Create(Department department)
        {
            return _departmentRepository.AddWithContextSave(department);
        }
        public Department Update(Department department)
        {
            return _departmentRepository.Add(department);
        }
        public Department Upsert(Department department)
        {
          return  _departmentRepository.Upsert(department);
        }
    }

}
