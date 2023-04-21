using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Interfaces;
using OnlineStore.Infrastructure.Entities;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Core.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public async Task<Profile?> GetProfileAsync() => await _profileRepository.GetDbSet().FirstOrDefaultAsync();
    }
}
