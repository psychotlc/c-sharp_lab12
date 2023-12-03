using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Doctors
{
    public class IndexDoctor : PageModel
    {
        private Services.ICollection<Doctor> _db;
        public IEnumerable<Doctor> Doctors { get; set; }

        public IndexDoctor(Services.ICollection<Doctor> db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Doctors = _db.GetAll();
        }
    }
}
