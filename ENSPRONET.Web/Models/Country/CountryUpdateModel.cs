using System.ComponentModel.DataAnnotations;

namespace ENSPRONET.Web.Models.Country;

public class CountryUpdateModel
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
    // public string? SubDivisionCode { get; set; }
    // public string? InternetDomain { get; set; }

    public ENSPRONET.Domains.Domains.Country Map()
    {
        return new ENSPRONET.Domains.Domains.Country()
        {
            CountryName = this.CountryName,
            Alpha2Code = this.Alpha2Code,
            Alpha3Code = this.Alpha3Code,
            NumericCode = this.NumericCode,
            // SubDivisionCode = this.SubDivisionCode,
            // InternetDomain = this.InternetDomain
        };
    }
}
