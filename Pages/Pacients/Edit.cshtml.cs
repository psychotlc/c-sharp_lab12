using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Pacients
{
    public class EditPacient : PageModel
    {
        private Services.ICollection<Pacient> _db;

        [BindProperty]
        public Pacient? Pacient { get; private set; }

        public EditPacient(Services.ICollection<Pacient> db)
        {
            _db = db;
        }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Pacient = _db.Get(id);
            }
            else
            {
                Pacient = new Pacient();
            }

            if (Pacient == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost(Pacient pacient)
        {
            
            Pacient.Name = pacient.Name;
            _db.Edit(Pacient);

            return RedirectToPage("./Index");
        }
    }
}
