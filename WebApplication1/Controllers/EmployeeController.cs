using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.App;
using WebApplication1.Tenant;

namespace WebApplication1.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly AppDbContext context;

        public EmployeeController(AppDbContext context)
        {
            context.Database.EnsureCreated();
            this.context = context;
        }

        public IActionResult Index()
        {
            return Json(context.Employees);
        }
    }
}
