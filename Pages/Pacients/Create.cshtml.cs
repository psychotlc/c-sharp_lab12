using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Pacients
{
    public class CreatePacient : PageModel
    {
        private Services.ICollection<Pacient> _db;

        [BindProperty]
        public Pacient Pacient { get; set; }

        public CreatePacient(Services.ICollection<Pacient> db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            Pacient = new Pacient();
            if (Pacient == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost(Pacient pacient)
        {
            _db.Add(pacient);
            return RedirectToPage("./Index");
        }
    }
}
