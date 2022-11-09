namespace ENSPRONET.Services.Services.Country;
using ENSPRONET.Domains.Domains;
public interface ICountryReadService
{
    Task<Country> ReadByAlpha2Code(string code);
    Task<List<Country>> List();
}
