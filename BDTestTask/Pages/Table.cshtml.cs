using BDTestTask.Contexts;
using BDTestTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BDTestTask.Pages
{
    public class TableModel : PageModel
    {
        public Employee[] employees { get; set; }

        public void OnGet()
        {
            using (var db = new EmployeeContext())
            {
                employees = db.employees.ToArray();
            }
        }
    }
}
