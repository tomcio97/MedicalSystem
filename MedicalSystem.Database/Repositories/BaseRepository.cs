using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Database.Entities.Base;
using MedicalSystem.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Database.Repositories
{
    public abstract class BaseRepository <Entity> where Entity: BaseEntity
    {
        protected ApplicationDbContext dbContext;
        protected abstract DbSet<Entity> DbSet { get; }
        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Add(Entity entity)
        {
            DbSet.Add(entity);

            return SaveChanges();
        }

        public bool Delete(Entity entity)
        {
            var foundEntity = DbSet.FirstOrDefault(x => x.Id == entity.Id);

            if (foundEntity != null)
            {
                DbSet.Remove(foundEntity);

                return SaveChanges();
            }

            return false;

        }

        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }

    }
}
