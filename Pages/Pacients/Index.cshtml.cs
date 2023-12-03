using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Pacients
{
    public class IndexPacient : PageModel
    {
        private Services.ICollection<Pacient> _db;
        public IEnumerable<Pacient> Pacients { get; set; }

        public IndexPacient(Services.ICollection<Pacient> db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Pacients = _db.GetAll();
        }
    }
}
