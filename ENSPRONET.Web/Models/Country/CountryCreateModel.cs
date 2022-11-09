using System.ComponentModel.DataAnnotations;
using ENSPRONET.Domains.Domains;

namespace ENSPRONET.Web.Models.Country;

public class CountryCreateModel
{
    [Required]
    public string CountryName { get; set; }
    [Required]
    [StringLength(2)]
    public string Alpha2Code { get; set; }
    [Required]
    [StringLength(3)]
    public string Alpha3Code { get; set; }
    [Required]
    public int NumericCode { get; set; }
    public string? SubDivisionCode { get; set; }
    public string? InternetDomain { get; set; }

    public Domains.Domains.Country Map()
    {

        Domains.Domains.Country countryDomainMapped = new Domains.Domains.Country()
        {
            Alpha2Code = this.Alpha2Code,
            Alpha3Code = this.Alpha3Code,
            CountryName = this.CountryName,
            InternetDomain = this.InternetDomain,
            NumericCode = this.NumericCode,
            SubDivisionCode = this.SubDivisionCode
        };
        return countryDomainMapped;
    }
}
