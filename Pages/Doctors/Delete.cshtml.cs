using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Doctors
{
    public class DeleteDoctor : PageModel
    {
        private Services.ICollection<Doctor> _db;

        public DeleteDoctor(Services.ICollection<Doctor> db)
        {
            _db = db;
        }

        [BindProperty]
        public Doctor? Doctor { get; set; }

        public IActionResult OnGet(int id)
        {
            Doctor = _db.Get(id);
            if (Doctor == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _db.Delete(Doctor.ID);
            return RedirectToPage("./Index");
        }
    }
}
