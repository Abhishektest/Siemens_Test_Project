using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeePortal.Model.Authentication;
using EmployeePortal.Repositories.BaseRepository;

namespace EmployeePortal.Model
{
    public class Employee:Entity<int>
    {
        
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public ApplicationUser User { get; set; }
        public Department Department { get; set; }

    }
}