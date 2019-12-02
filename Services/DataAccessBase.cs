using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using curly.Api.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public abstract class DataAccessBase<TEntity>
        where TEntity : IEntity
    {
        protected abstract IMongoCollection<TEntity> _mongoCollection { get; }

        // Insert
        public virtual async Task<TEntity> InsertOrUpdateAsync(TEntity entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Id))
            {
                entity.Id = ObjectId.GenerateNewId().ToString();
            }

            var newEntity = await _mongoCollection.ReplaceOneAsync(
                x => x.Id.Equals(entity.Id),
                entity,
                new UpdateOptions
                {
                    IsUpsert = true
                });

            return entity;
        }

        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _mongoCollection.InsertOneAsync(entity);
            return entity;
        }

        // Insert Many
        public virtual async void InsertManyAsync(IEnumerable<TEntity> documents)
        {
            await _mongoCollection.InsertManyAsync(documents);
        }

        // Retrieve
        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            //Expression<Func<TEntity, bool>> dataPredicate = entity => (entity.Id == string.Empty);
            return await _mongoCollection.Find(entity => true).ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(string id)
        {
            return await _mongoCollection.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public virtual async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _mongoCollection.Find(predicate).ToListAsync();
        }

        // Update
        public virtual async Task<bool> UpdateAsync(TEntity document, string updateFieldName, string updateFieldValue)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", document.Id);
            var update = Builders<TEntity>.Update.Set(updateFieldName, updateFieldValue);

            var result = await _mongoCollection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        // Delete
        public async Task<bool> DeleteByIdAsync(string id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", id);
            var result = await _mongoCollection.DeleteOneAsync(filter);
            return result.DeletedCount != 0;
        }

        // Count
        public virtual long Count()
        {
            return _mongoCollection.CountDocuments(new BsonDocument());
        }

        public virtual async Task<long> CountAsync()
        {
            return await _mongoCollection.CountDocumentsAsync(new BsonDocument());
        }
    }
}
