using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Doctors
{
    public class CreateDoctor : PageModel
    {
        private Services.ICollection<Doctor> _db;

        [BindProperty]
        public Doctor Doctor { get; set; }

        public CreateDoctor(Services.ICollection<Doctor> db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            Doctor = new Doctor();
            if (Doctor == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost(Doctor doctor)
        {
            _db.Add(doctor);
            return RedirectToPage("./Index");
        }
    }
}
