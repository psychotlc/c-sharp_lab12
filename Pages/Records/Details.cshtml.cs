using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Records
{
    public class DetailsRecord : PageModel
    {
        private Services.ICollection<Record> _db_records;
        private Services.ICollection<Pacient> _db_pacients;
        private Services.ICollection<Doctor> _db_doctors;
        public Record? Record { get; private set; }
        public string DoctorName { get; private set; }
        public string PacientName { get; private set; }

        public DetailsRecord(Services.ICollection<Record> db_records,
            Services.ICollection<Pacient> db_pacients,
            Services.ICollection<Doctor> db_doctors)
        {
            _db_records = db_records;
            _db_pacients = db_pacients;
            _db_doctors = db_doctors;
        }

        public void OnGet(int id)
        {
            Record = _db_records.Get(id);
            Record.PacientID = _db_pacients.Get(Record.PacientID).ID;
            Record.DoctorID = _db_doctors.Get(Record.DoctorID).ID;
            DoctorName = _db_doctors.Get(Record.DoctorID).Name;
            PacientName = _db_pacients.Get(Record.PacientID).Name;

        }
    }
}
