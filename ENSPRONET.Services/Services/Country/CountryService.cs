using Bogus;
using CountryData;
using CountryData.Bogus;
using ENSPRONET.Services.Context;
using ENSPRONET.Services.Services.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ENSPRONET.Services.Services.Country;

public class CountryService : ICountryReadService, ICountryCreateService, ISeederService<Domains.Domains.Country>, ICountryUpdateService, ICountryDeleteService
{
    private readonly ENSPRONETContext ENSPRONETContext;
    public CountryService(ENSPRONETContext ensproNetContext)
    {
        ENSPRONETContext = ensproNetContext;
    }

    public CountryService()
    {

    }

    public async Task<int> Create(Domains.Domains.Country country)
    {
        if (country == null)
            throw new ArgumentNullException("country");

        ENSPRONETContext.Add(country);

        await ENSPRONETContext.SaveChangesAsync();

        return country.Id;
    }

    public async Task CreateBulk(List<Domains.Domains.Country> countries)
    {
        if (countries == null || countries?.Count == 0)
            throw new ArgumentNullException("countries");

        ENSPRONETContext.AddRange(countries);

        await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task<List<Domains.Domains.Country>> List()
    {
        return ENSPRONETContext.Countries.ToList();
    }

    public async Task<Domains.Domains.Country> ReadByAlpha2Code(string code)
    {
        if (String.IsNullOrEmpty(code))
            throw new ArgumentNullException(code);

        return await ENSPRONETContext.Countries.FirstAsync(m => m.Alpha2Code == code);
    }

    public IEnumerable<Domains.Domains.Country> GenerateSeedData(int numberRecords)
    {
        if (numberRecords <= 0)
            throw new ArgumentException("number records needs to be higher than 0");

        int index = 1;
        var allCountryInfo = CountryLoader.CountryInfo;
        var fakerCountryDefinition = new Faker<Domains.Domains.Country>()
            .RuleFor(m => m.Id, f => index++)
            .RuleFor(m => m.CountryName, f => f.Country().Name())
            .RuleFor(m => m.Alpha2Code, (f, u) => allCountryInfo.First(m => m.Name == u.CountryName).Iso)
            .RuleFor(m => m.Alpha3Code, (f, u) => allCountryInfo.First(m => m.Name == u.CountryName).Iso3)
            .RuleFor(m => m.InternetDomain, (f, u) => allCountryInfo.First(m => m.Name == u.CountryName).TopLevelDomain)
            .RuleFor(m => m.NumericCode, (f, u) => allCountryInfo.First(m => m.Name == u.CountryName).IsoNumeric)
            .RuleFor(m => m.SubDivisionCode, (f, u) => allCountryInfo.First(m => m.Name == u.CountryName).Fips.ToString());

        return fakerCountryDefinition.Generate(numberRecords);
    }

    public async Task Update(int id, Domains.Domains.Country country)
    {
        if (id == default(int) || country == null)
            throw new ArgumentNullException("country");

        var countrySelected = await ENSPRONETContext.Countries.FirstAsync(m => m.Id == id);

        countrySelected.Alpha2Code = country.Alpha2Code;
        countrySelected.Alpha3Code = country.Alpha3Code;
        countrySelected.CountryName = country.CountryName;
        countrySelected.NumericCode = country.NumericCode;
        // countrySelected.SubDivisionCode = country.SubDivisionCode;
        // countrySelected.InternetDomain = country.InternetDomain;

        ENSPRONETContext.Update(countrySelected);

        await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        if (id == default(int))
            throw new ArgumentNullException("id");

        var countrySelected = await ENSPRONETContext.Countries.FirstAsync(m => m.Id == id);

        ENSPRONETContext.Remove(countrySelected);

        await ENSPRONETContext.SaveChangesAsync();
    }
}
