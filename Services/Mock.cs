using Lab12.Models;

namespace Lab12.Services;

public class MockDoctors : ICollection<Doctor>
{
    private readonly List<Doctor> _doctors;

    public MockDoctors()
    {
        _doctors = new List<Doctor>()
        {
            new Doctor()
            {
                ID = 0,
                Name = "Dr. Smith"
            },
            new Doctor()
            {
                ID = 1,
                Name = "Dr. Johnson"
            },
            new Doctor()
            {
                ID = 2,
                Name = "Dr. Davis"
            }
        };
    }

    public Doctor? Get(int? id)
    {
        return _doctors.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Doctor> GetAll()
    {
        return _doctors;
    }

    public Doctor Add(Doctor doctor)
    {
        doctor.ID = _doctors.Max(x => x.ID) + 1;
        _doctors.Add(doctor);
        return doctor;
    }

    public Doctor? Delete(int id)
    {
        var doctor = _doctors.FirstOrDefault(x => x.ID == id);
        if (doctor != null)
        {
            _doctors.Remove(doctor);
        }

        return doctor;
    }

    public Doctor? Edit(Doctor newDoctor)
    {
        var doctor = _doctors.FirstOrDefault(x => x.ID == newDoctor.ID);
        if (doctor != null)
        {
            doctor.ID = newDoctor.ID;
            doctor.Name = newDoctor.Name;
        }

        return doctor;
    }

}

public class MockPacients : ICollection<Pacient>
{
    private readonly List<Pacient> _pacients;

    public MockPacients()
    {
        _pacients = new List<Pacient>()
        {
            new Pacient()
            {
                ID = 0,
                Name = "John Doe"
            },
            new Pacient()
            {
                ID = 1,
                Name = "Jane Doe"
            },
            new Pacient()
            {
                ID = 2,
                Name = "Bob Smith"
            }
        };
    }

    public Pacient? Get(int? id)
    {
        return _pacients.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Pacient> GetAll()
    {
        return _pacients;
    }

    public Pacient Add(Pacient pacient)
    {
        pacient.ID = _pacients.Max(x => x.ID) + 1;
        _pacients.Add(pacient);
        return pacient;
    }

    public Pacient? Delete(int id)
    {
        var pacient = _pacients.FirstOrDefault(x => x.ID == id);
        if (pacient != null)
        {
            _pacients.Remove(pacient);
        }

        return pacient;
    }

    public Pacient? Edit(Pacient newPacient)
    {
        var pacient = _pacients.FirstOrDefault(x => x.ID == newPacient.ID);
        if (pacient != null)
        {
            pacient.ID = newPacient.ID;
            pacient.Name = newPacient.Name;
        }

        return pacient;
    }
}

public class MockRecords : ICollection<Record>
{
    private readonly List<Record> _records;

    public MockRecords()
    {
        _records = new List<Record>()
        {
            new Record()
            {
                ID = 0,
                Title = "Appointment 1",
                DoctorID = 0,
                PacientID = 1
            },
            new Record()
            {
                ID = 1,
                Title = "Appointment 2",
                DoctorID = 1,
                PacientID = 2
            },
            new Record()
            {
                ID = 2,
                Title = "Appointment 3",
                DoctorID = 2,
                PacientID = 0
            }
        };
    }

    public Record? Get(int? id)
    {
        return _records.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Record> GetAll()
    {
        return _records;
    }

    public Record Add(Record record)
    {
        record.ID = _records.Max(x => x.ID) + 1;
        _records.Add(record);
        return record;
    }

    public Record? Delete(int id)
    {
        var record = _records.FirstOrDefault(x => x.ID == id);
        if (record != null)
        {
            _records.Remove(record);
        }

        return record;
    }

    public Record? Edit(Record newRecord)
    {
        var record = _records.FirstOrDefault(x => x.ID == newRecord.ID);
        if (record != null)
        {
            record.ID = newRecord.ID;
            record.Title = newRecord.Title;
            record.DoctorID = newRecord.DoctorID;
            record.PacientID = newRecord.PacientID;
        }

        return record;
    }
}
