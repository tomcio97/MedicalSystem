using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystem.Database.Entities.Base;

namespace MedicalSystem.Database.Interfaces
{
    public interface IBaseRepository<Entity> where Entity: BaseEntity
    {
        bool Add(Entity entity);
        bool Delete(Entity entity);
    }
}
