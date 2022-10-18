using System;

namespace MerchanCountriesAngular.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}