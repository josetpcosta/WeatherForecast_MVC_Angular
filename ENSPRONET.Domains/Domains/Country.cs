namespace ENSPRONET.Domains.Domains;

/// <summary>
/// Object that represents a country. The country codes are defined bu the standard ISO 3166.
/// https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
/// </summary>
/// 
///  Explanation:
///     On c# we have multiple ways to declare the properties.
///         1 - By setting the name of the propriety next of the syntax get; set (example property Id);
///         2 - By declaring a private property and a public with a simmilar name. 
///             In this case the public propriety sets or gets the private property.
///             By doing this way, we are able attach  behaviours when getting or setting the property, like for example the _alpha3Code
///             which is validating the value before setting the value.
/// 
public class Country
{
    public int Id { get; set; }
    public string CountryName { get; set; }
    private string _alpha2Code;
    public string Alpha2Code { get => _alpha2Code; set { _alpha2Code = validateAlpha2Code(value); } }
    private string _alpha3Code;
    public string Alpha3Code { get => _alpha3Code; set { _alpha3Code = validateAlpha3Code(value); } }
    private int _numericCode;
    public int NumericCode { get => _numericCode; set { _numericCode = ValidateNumericCode(value); } }
    public string? SubDivisionCode { get; set; }
    public string? InternetDomain { get; set; }

    public ICollection<WeatherForecast> WeatherForecasts { get; set; }

    #region Validations
    private string validateAlpha2Code(string code)
    {
        if (code.Count() != 2)
            throw new ArgumentException("Invalid Alpha 2 code");
        else
            return code;
    }

    private string validateAlpha3Code(string code)
    {
        if (code.Count() != 3)
            throw new ArgumentException("Invalid Alpha 2 code");
        else
            return code;
    }

    private int ValidateNumericCode(int code)
    {
        if (code > 999)
            throw new ArgumentException("Invalid Numeric code");
        else
            return code;
    }

    #endregion
}
