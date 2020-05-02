using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.App
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}
