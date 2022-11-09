namespace ENSPRONET.Web.Models.Country;

public class CountryReadModel
{
    public int Id { get; set; }
    public string CountryName { get; set; }
    public string Alpha2Code { get; set; }
    public string Alpha3Code { get; set; }
    public int NumericCode { get; set; }
    public string? SubDivisionCode { get; set; }
    public string? InternetDomain { get; set; }

    public void Map(ENSPRONET.Domains.Domains.Country countryDomain)
    {
        this.Id = countryDomain.Id;
        this.CountryName = countryDomain.CountryName;
        this.Alpha2Code = countryDomain.Alpha2Code;
        this.Alpha3Code = countryDomain.Alpha3Code;
        this.NumericCode = countryDomain.NumericCode;
        this.SubDivisionCode = countryDomain.SubDivisionCode;
        this.InternetDomain = countryDomain.InternetDomain;
    }
}
