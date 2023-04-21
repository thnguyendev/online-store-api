using OnlineStore.Infrastructure.Entities;

namespace OnlineStore.Core.Interfaces
{
    public interface IProfileService
    {
        Task<Profile?> GetProfileAsync();
    }
}
