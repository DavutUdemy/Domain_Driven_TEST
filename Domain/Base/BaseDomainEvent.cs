using System;
namespace Domain.Base
{
    public abstract class BaseDomainEvent 
    {
        public BaseDomainEvent()
        {
            EventId = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public virtual Guid EventId { get; set; }
        public virtual DateTime CreatedOn { get; set; }
    }

}