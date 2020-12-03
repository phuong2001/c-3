using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class EFEmployeeRepository :ISEmployeeRepository
    {
        private EmployeeDBContext context;
        public EFEmployeeRepository(EmployeeDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
    
    
}
