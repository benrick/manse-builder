using System;

namespace ManseBuilder.Core.Model
{
    public abstract class BaseAggregate
    {
        public Guid UniqueId { get; protected set; } = Guid.NewGuid();
    }
}