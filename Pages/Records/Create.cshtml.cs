using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Records
{
    public class CreateRecord : PageModel
    {
        private Services.ICollection<Record> _db;

        [BindProperty]
        public Record? Record { get; private set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Pacient> Pacients { get; set; }

        public CreateRecord(Services.ICollection<Record> db_records,
            Services.ICollection<Doctor> db_doctors,
            Services.ICollection<Pacient> db_pacients)
        {
            _db = db_records;
            Doctors = db_doctors.GetAll();
            Pacients = db_pacients.GetAll();
        }

        public IActionResult OnGet()
        {
            Record = new Record();
            if (Record == null)
            {
                return RedirectToPage("../Error");
            }
            return Page();
        }

        public IActionResult OnPost(Record record)
        {
            record.DoctorID = Doctors.FirstOrDefault(d => d.ID == record.DoctorID).ID;
            record.PacientID = Pacients.FirstOrDefault(p => p.ID == record.PacientID).ID;
            _db.Add(record);
            return RedirectToPage("./Index");
        }
    }
}
