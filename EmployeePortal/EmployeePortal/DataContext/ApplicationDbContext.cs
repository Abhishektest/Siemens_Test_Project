using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EmployeePortal.Model;
using EmployeePortal.Model.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Employee = EmployeePortal.Model.Employee;

namespace EmployeePortal.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        private readonly string MappingNameSpace = "EmployeePortal.Mappings";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {   AddConfigurations(builder);
            base.OnModelCreating(builder);
        }
        private void AddConfigurations(ModelBuilder modelBuilder)
        {
            var entityConfigurationTypes = FindTypesToRegister();
            entityConfigurationTypes.ToList().ForEach(entityConfigurationType =>
            {
                dynamic configurationInstance = Activator.CreateInstance(entityConfigurationType);
                modelBuilder.ApplyConfiguration(configurationInstance);
            });
        }
        private IEnumerable<Type> FindTypesToRegister()
        {
            return MappingAssemblyAndNamespaces.SelectMany(pair => pair.Key.GetTypes()
                .Where(type => type
                    .GetInterfaces()
                    .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
            );
        }
        protected virtual IDictionary<Assembly, IEnumerable<string>> MappingAssemblyAndNamespaces =>
            new Dictionary<Assembly, IEnumerable<string>>()
            {
                {GetType().Assembly, new[] {MappingNameSpace}}
            };
        

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
