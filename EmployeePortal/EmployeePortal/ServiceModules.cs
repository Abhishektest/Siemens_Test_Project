using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using EmployeePortal.HandlerInterfaces;
using EmployeePortal.Handlers;
using EmployeePortal.Repositories;

namespace EmployeePortal
{
    public class ServiceModules : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<DepartmentHandler>().As<IDepartmentHandler>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentRepository>().InstancePerLifetimeScope();

        }
    }
}
