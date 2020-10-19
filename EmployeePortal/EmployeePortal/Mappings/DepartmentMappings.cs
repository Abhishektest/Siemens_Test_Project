using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePortal.Constants;
using EmployeePortal.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeePortal.Mappings
{
    public class DepartmentMappings: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> b)
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("tName")
                .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Departments");
        }


    }
}
