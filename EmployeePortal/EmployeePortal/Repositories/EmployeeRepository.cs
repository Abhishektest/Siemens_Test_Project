using EmployeePortal.DataContext;
using EmployeePortal.Model;
using EmployeePortal.Repositories.BaseRepository;

namespace EmployeePortal.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, int>
    {
        public EmployeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
