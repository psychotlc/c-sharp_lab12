using Lab12.Models;
using Lab12.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Records
{
    public class EditRecord : PageModel
    {
        private HospitalContext _db;

        [BindProperty]
        public Record? Record { get; private set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Pacient> Pacients { get; set; }

        public EditRecord(HospitalContext db)
        {
            _db = db;
            Doctors = _db.Doctors;
            Pacients = _db.Pacients;
        }

        public IActionResult OnGet(int? id)
        {
            var record = _db.Records.Find(id);

            if (record != null)
            {
                Record = new Record()
                {
                    ID = record.ID,
                    Title = record.Title,
                    DoctorID = record.DoctorID,
                    PacientID = record.PacientID,
                };
                return Page();
            }
            else
            {
                return RedirectToPage("../Error");
            }

        }

        public IActionResult OnPost()
        {

            if (Record != null)
            {
                var existingRecord = _db.Records.Find(Record.ID);
                if (existingRecord != null)
                {
                    existingRecord.ID = Record.ID;
                    existingRecord.Title = Record.Title;
                    existingRecord.DoctorID = Record.DoctorID;
                    existingRecord.PacientID = Record.PacientID;
                    _db.SaveChanges();
                }
            }
            return RedirectToPage("./Index");
        }
    }
}
