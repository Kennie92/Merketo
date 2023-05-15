using WebbApp.Helpers.Repositories;
using WebbApp.Models.Entities;
using WebbApp.Models.Identities;

namespace WebbApp.Helpers.Services;

public class AddressService
{

    private readonly AddressRepository _addressRepo;
    private readonly UserAddresRepository _userAddressRepository;

    public AddressService(AddressRepository addressRepo, UserAddresRepository userAddressRepository)
    {
        _addressRepo = addressRepo;
        _userAddressRepository = userAddressRepository;
    }

    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity addressEntity)
    {
        var entity = await _addressRepo.GetAsync(x => 
        x.StreetName == addressEntity.StreetName &&
        x.PostalCode == addressEntity.PostalCode &&
        x.City == addressEntity.City
        );

        entity ??= await _addressRepo.AddAsync(addressEntity);
        return entity!;
    }

    public async Task AddAddressAsync(AppUser user, AddressEntity addressEntity)
    {
        await _userAddressRepository.AddAsync(new AccountAddressEntity
        {
            UserId = user.Id,
            AddressId = addressEntity.Id,
        });
    }
    
}
