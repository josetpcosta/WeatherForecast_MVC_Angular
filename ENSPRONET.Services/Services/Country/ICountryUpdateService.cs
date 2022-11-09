namespace ENSPRONET.Services.Services.Country;
using ENSPRONET.Domains.Domains;

public interface ICountryUpdateService
{
    Task Update(int id, Country country);
}
