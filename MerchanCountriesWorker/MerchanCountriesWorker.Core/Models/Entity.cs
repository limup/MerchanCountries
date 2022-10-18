using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MerchanCountriesWorker.Core.Models
{
    public abstract class Entity
    {
        [BsonId]
        public Guid Id { get; set; }
        
        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}