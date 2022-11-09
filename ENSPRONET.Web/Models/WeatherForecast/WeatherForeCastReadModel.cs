using System;

namespace ENSPRONET.Web.Models.WeatherForecast
{
    using ENSPRONET.Domains.Domains;
    public class WeatherForecastReadModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }

        //public Country Country {get; set;}


        public void Map(WeatherForecast weatherForecast)
        {
            this.Id = weatherForecast.Id;
            this.Date = weatherForecast.Date;
            this.TemperatureC = weatherForecast.TemperatureC;
            this.TemperatureF = weatherForecast.TemperatureF;
            this.Summary = weatherForecast.Summary; 
            //this.Country = weatherForecast.Country;
        }
    }
}
