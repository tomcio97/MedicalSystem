using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Database.Entities;

namespace MedicalSystem.Database.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        IQueryable<Doctor> GetDoctors();
    }
}
