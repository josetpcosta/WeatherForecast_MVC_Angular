using ENSPRONET.Services.Services.Country;
using ENSPRONET.Services.Services.WeatherForecast;
using ENSPRONET.Web.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using ENSPRONET.Domains.Domains;

namespace ENSPRONET.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastReadService weatherForecastReadService;
    private readonly IWeatherForecastCreateService weatherForecastCreateService;
    private readonly IWeatherForecastUpdateTemperatureService weatherForecastUpdateTemperatureService;
    private readonly IWeatherForecastDeleteTemperatureService weatherForecastDeleteTemperatureService;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastReadService weatherForecastReadService,
    IWeatherForecastCreateService weatherForecastCreateService, IWeatherForecastUpdateTemperatureService weatherForecastUpdateTemperatureService, 
    IWeatherForecastDeleteTemperatureService weatherForecastDeleteTemperatureService)
    {
        _logger = logger;
        this.weatherForecastReadService = weatherForecastReadService;
        this.weatherForecastCreateService = weatherForecastCreateService;
        this.weatherForecastUpdateTemperatureService = weatherForecastUpdateTemperatureService;
        this.weatherForecastDeleteTemperatureService = weatherForecastDeleteTemperatureService;
    }


    [HttpGet("GetbyCountry/{countryId}")]
    public async Task<ActionResult<List<WeatherForecastGetByCountryModel>>> GetbyCountry(int countryId)
    {
        if (countryId == default(int))
            return new BadRequestResult();

        List<WeatherForecastGetByCountryModel> listForecasts = new List<WeatherForecastGetByCountryModel>();

        foreach (var forecast in await weatherForecastReadService.List(countryId))
        {
            WeatherForecastGetByCountryModel castedWeatherForecast = new WeatherForecastGetByCountryModel();
            castedWeatherForecast.Map(forecast);

            listForecasts.Add(castedWeatherForecast);
        }


        return Ok(listForecasts);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] WeatherForecastCreateModel weatherForecastCreateModel)
    {

        if (weatherForecastCreateModel == null)
            return new BadRequestResult();

        var mappedWeatherForecastDomain = weatherForecastCreateModel.Map();

        return Ok(await weatherForecastCreateService.Create(mappedWeatherForecastDomain, weatherForecastCreateModel.CountryID));
    }


    [HttpGet]
    public IEnumerable<WeatherForecastReadModel> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastReadModel
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

     
    [HttpGet("GetTemperatureByID/{id}")]
    public async Task<ActionResult<WeatherForecastReadModel>> GetTemperatureById(int id)
    {
        if (id == default(int) || !ModelState.IsValid)
            return BadRequest();

        WeatherForecast selectedObject = await weatherForecastReadService.GetTemperatureByID(id);

        WeatherForecastReadModel model = new WeatherForecastReadModel();
        model.Map(selectedObject);
        return Ok(model);
    }

    [HttpPut]
    public async Task<IActionResult> Put(int id, [FromBody] WeatherForecastUpdateTemperatureModel weatherForecastUpdateTemperatureModel)
    {
        if (id == default(int) || !ModelState.IsValid)
            return BadRequest();

        await weatherForecastUpdateTemperatureService.Update(id, weatherForecastUpdateTemperatureModel.Map());

        return Ok();
    } 

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        if (id == default(int))
            return BadRequest();

        await weatherForecastDeleteTemperatureService.Delete(id);

        return Ok();
    }
}
