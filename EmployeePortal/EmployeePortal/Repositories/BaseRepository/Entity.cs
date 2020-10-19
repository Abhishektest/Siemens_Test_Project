using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Repositories.BaseRepository
{
    [Serializable]
    public class Entity<T> 
    {
        [Key]
        public virtual T Id { get; set; }
    }
}