using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystem.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Database
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
