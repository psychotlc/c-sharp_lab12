using Microsoft.EntityFrameworkCore;
using Pomelo;
using Lab12.Models;

namespace Lab12.Services
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
