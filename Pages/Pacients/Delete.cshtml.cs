using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Pacients
{
    public class DeletePacient : PageModel
    {
        private Services.ICollection<Pacient> _db;

        public DeletePacient(Services.ICollection<Pacient> db)
        {
            _db = db;
        }

        [BindProperty]
        public Pacient? Pacient { get; set; }

        public IActionResult OnGet(int id)
        {
            Pacient = _db.Get(id);
            if (Pacient == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _db.Delete(Pacient.ID);
            return RedirectToPage("./Index");
        }
    }
}
