using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace OrganizationManagement.WebUI.Abstraction
{
    public abstract class ServiceBase<TEntity>
        where TEntity : EntityBase<int>
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public ServiceBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>>? expression = null)
        {
            var noTrackings = _dbSet.AsNoTracking();
            return expression == null ? noTrackings : noTrackings.Where(expression);
        }

        public virtual TEntity? Find(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.AsNoTracking()
                .FirstOrDefault(expression);
        }

        public virtual Task<int> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Add(entity);
            return _dbContext.SaveChangesAsync(cancellationToken);
        }

        public virtual Task<int> RemoveAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                throw new NullReferenceException();
            }
            _dbSet.Remove(entity);
            return _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
