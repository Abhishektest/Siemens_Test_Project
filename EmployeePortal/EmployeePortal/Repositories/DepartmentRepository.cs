using System;
using System.Collections.Generic;
using System.Text;
using EmployeePortal.DataContext;
using EmployeePortal.Model;
using EmployeePortal.Repositories.BaseRepository;

namespace EmployeePortal.Repositories
{
    public class DepartmentRepository: BaseRepository<Department,int>
    { 
        public DepartmentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
    
}
