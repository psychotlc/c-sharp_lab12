using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Records
{
    public class IndexRecord : PageModel
    {
        private Services.ICollection<Record> _db;
        public IEnumerable<Record>? Records { get; set; }

        public IndexRecord(Services.ICollection<Record> db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Records = _db.GetAll();
        }
    }
}
