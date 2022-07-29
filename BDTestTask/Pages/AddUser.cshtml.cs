using BDTestTask.Contexts;
using BDTestTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BDTestTask.Pages
{
    public class AddUserModel : PageModel
    {
        [BindProperty]
        public Employee Employee { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }

        public void OnPostSave()
        {
            using (var db = new EmployeeContext())
            {
                db.employees.Add(Employee);
                db.SaveChanges();
            }
            Response.Redirect("/Table");
        }

        public void OnPostCancel()
        {
            Response.Redirect("/Table");
        }
    }
}