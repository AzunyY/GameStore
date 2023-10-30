using PetaPoco;

namespace gmstore1.Models.Repositories
{
    public abstract class AbstractRepository<T>
    {
        protected readonly IDatabase _db;

        protected AbstractRepository(IDatabase db)
        {
            _db = db;
        }

        public virtual void Add(T item)
        {
            _db.Insert(item);
        }

        public virtual void Remove(int item)
        {
            _db.Delete(item);
        }

        public virtual void Update(T item)
        {
            _db.Update(item);
        }

        public virtual T FindByID(int id)
        {
            return _db.Single<T>(id);
        }
    }
}
