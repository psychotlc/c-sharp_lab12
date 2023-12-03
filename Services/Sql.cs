using Microsoft.EntityFrameworkCore;
using Lab12.Models;

namespace Lab12.Services
{
    public class SqlDoctors : ICollection<Doctor>
    {
        private HospitalContext _db;

        public SqlDoctors(HospitalContext db)
        {
            _db = db;
        }

        public Doctor? Get(int? id)
        {
            return _db.Doctors.Find(id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _db.Doctors;
        }

        public Doctor Add(Doctor doctor)
        {
            _db.Doctors.Add(doctor);
            _db.SaveChanges();
            return doctor;
        }

        public Doctor? Edit(Doctor newDoctor)
        {
            var doctor = _db.Doctors.Attach(newDoctor);
            doctor.State = EntityState.Modified;
            _db.SaveChanges();
            return newDoctor;
        }

        public Doctor? Delete(int id)
        {
            var doctor = _db.Doctors.Find(id);
            if (doctor != null)
            {
                _db.Doctors.Remove(doctor);
                _db.SaveChanges();
            }

            return doctor;
        }
    }

    public class SqlPacients : ICollection<Pacient>
    {
        private HospitalContext _db;

        public SqlPacients(HospitalContext db)
        {
            _db = db;
        }

        public Pacient? Get(int? id)
        {
            return _db.Pacients.Find(id);
        }

        public IEnumerable<Pacient> GetAll()
        {
            return _db.Pacients;
        }

        public Pacient Add(Pacient pacient)
        {
            _db.Pacients.Add(pacient);
            _db.SaveChanges();
            return pacient;
        }

        public Pacient? Edit(Pacient newPacient)
        {
            var pacient = _db.Pacients.Attach(newPacient);
            pacient.State = EntityState.Modified;
            _db.SaveChanges();
            return newPacient;
        }

        public Pacient? Delete(int id)
        {
            var pacient = _db.Pacients.Find(id);
            if (pacient != null)
            {
                _db.Pacients.Remove(pacient);
                _db.SaveChanges();
            }

            return pacient;
        }
    }

    public class SqlRecords : ICollection<Record>
    {
        private HospitalContext _db;

        public SqlRecords(HospitalContext db)
        {
            _db = db;
        }

        public Record? Get(int? id)
        {
            return _db.Records.Find(id);
        }

        public IEnumerable<Record> GetAll()
        {
            return _db.Records;
        }

        public Record Add(Record record)
        {
            _db.Records.Add(record);
            _db.SaveChanges();
            return record;
        }

        public Record? Edit(Record newRecord)
        {
            var record = _db.Records.Attach(newRecord);
            record.State = EntityState.Modified;
            _db.SaveChanges();
            return newRecord;
        }

        public Record? Delete(int id)
        {
            var record = _db.Records.Find(id);
            if (record != null)
            {
                _db.Records.Remove(record);
                _db.SaveChanges();
            }

            return record;
        }
    }
}
