﻿using PG.Model;
using PG.Repository;
using System;

namespace PG.BLL
{
    public abstract class BaseService<TEntity, TRepository> 
        where TEntity: BaseModel
        where TRepository: IRepository<TEntity>
    {
        protected TRepository Repo;

        protected BaseService(TRepository repository)
        {
            Repo = repository;
        }

        public virtual int Create(TEntity newEntity)
        {
            newEntity.Created = DateTime.UtcNow;
            return Repo.Create(newEntity);
        }

        public virtual void Delete(int id)
        {
            Repo.Delete(id);
        }

        public virtual TEntity GetById(int id)
        {
            return Repo.Get(id);
        }
        
        public virtual void Update(TEntity entity)
        {
            entity.Updated = DateTime.UtcNow;
            Repo.Update(entity);
        }
    }
}
