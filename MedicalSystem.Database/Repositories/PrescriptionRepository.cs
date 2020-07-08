using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Database.Entities;
using MedicalSystem.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Database.Repositories
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {
        protected override DbSet<Prescription> DbSet => dbContext.Prescriptions;

        public PrescriptionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Prescription> GetPrescriptions()
        {
            return DbSet.Include(x => x.Medicines).Select(x => x);
        }
    }
}
