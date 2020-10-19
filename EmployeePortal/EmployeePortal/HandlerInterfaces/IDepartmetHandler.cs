using EmployeePortal.Model;
using EmployeePortal.Repositories;

namespace EmployeePortal.HandlerInterfaces
{
    public interface IDepartmentHandler
    {

        Department Add(Department department);
        Department Create(Department department);

        Department Update(Department department);

        Department Upsert(Department department);

    }

}