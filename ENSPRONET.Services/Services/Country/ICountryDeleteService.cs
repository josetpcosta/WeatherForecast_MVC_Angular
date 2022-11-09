namespace ENSPRONET.Services.Services.Country;
using ENSPRONET.Domains.Domains;
public interface ICountryDeleteService
{
    Task Delete(int id);
}
