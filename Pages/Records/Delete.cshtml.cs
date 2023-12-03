using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Records
{
    public class DeleteRecord : PageModel
    {
        private Services.ICollection<Record> _db;

        public DeleteRecord(Services.ICollection<Record> db)
        {
            _db = db;
        }

        [BindProperty]
        public Record? Record { get; set; }

        public IActionResult OnGet(int id)
        {
            Record = _db.Get(id);
            if (Record == null)
            {
                return RedirectToPage("../Error");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _db.Delete(Record.ID);
            return RedirectToPage("./Index");
        }
    }
}
