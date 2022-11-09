namespace ENSPRONET.Services.Services.Country;
using ENSPRONET.Domains.Domains;
public interface ICountryCreateService
{
    Task CreateBulk(List<Country> countries);

    Task<int> Create(Country country);
}
