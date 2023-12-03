using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Doctors
{
    public class EditDoctor : PageModel
    {
        private Services.ICollection<Doctor> _db;

        [BindProperty]
        public Doctor? Doctor { get; private set; }

        public EditDoctor(Services.ICollection<Doctor> db)
        {
            _db = db;
        }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Doctor = _db.Get(id);
            }
            else
            {
                Doctor = new Doctor();
            }

            if (Doctor == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost(Doctor doctor)
        {
            _db.Edit(doctor);
            return RedirectToPage("./Index");
        }
    }
}
