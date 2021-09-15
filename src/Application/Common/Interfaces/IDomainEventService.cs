using clean.Domain.Common;
using System.Threading.Tasks;

namespace clean.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
