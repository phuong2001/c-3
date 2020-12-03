using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public interface ISEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
