using System.ComponentModel.DataAnnotations;
using System.Data;
using EmployeePortal.Repositories.BaseRepository;

namespace EmployeePortal.Model
{
    public class Department:Entity<int>
    {
        
        public string Name { get; set; }
    }
}