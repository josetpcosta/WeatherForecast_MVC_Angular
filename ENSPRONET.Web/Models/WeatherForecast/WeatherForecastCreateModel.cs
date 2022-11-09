namespace ENSPRONET.Web.Models.WeatherForecast;

using Domains.Domains;

public class WeatherForecastCreateModel
{
    public DateTime Date { get; set; } 

    public int TemperatureC { get; set; }

    // public int TemperatureF { get; set; } 
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public int CountryID { get; set; }


    public WeatherForecast Map()
    {
        return new WeatherForecast()
        {
            Date = this.Date,
            TemperatureC = this.TemperatureC,
            TemperatureF = this.TemperatureF,
            Summary = this.Summary
        };
    }
}