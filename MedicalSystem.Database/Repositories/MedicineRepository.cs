using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Database.Entities;
using MedicalSystem.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Database.Repositories
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        protected override DbSet<Medicine> DbSet => dbContext.Medicines;

        public MedicineRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Medicine> GetMedicines()
        {
            return DbSet.Select(x => x);
        }
    }
}
