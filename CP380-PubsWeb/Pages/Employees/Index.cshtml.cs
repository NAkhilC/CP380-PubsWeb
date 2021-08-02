using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP380_PubsLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CP380_PubsWeb.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly PubsDbContext _db;

        public IndexModel(PubsDbContext db)
        {
            _db = db;
        }
        public List<CP380_PubsLab.Models.Employee> Employee { get; set; }
        public void OnGet( short Id)
        {
            Employee = (List<Employee>)_db.Employee.Where(b => b.Job_Id == Id).ToList();
        }
    }
}
