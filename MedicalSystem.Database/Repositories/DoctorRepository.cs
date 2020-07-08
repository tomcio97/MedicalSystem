using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Database.Entities;
using MedicalSystem.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Database.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => dbContext.Doctors;

        public DoctorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Doctor> GetDoctors()
        {
            return DbSet.Include(x => x.Prescriptions).ThenInclude(x => x.Medicines).Select(x => x);
        }
    }
}
