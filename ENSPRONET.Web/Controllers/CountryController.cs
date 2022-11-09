using ENSPRONET.Services.Services.Country;
using Microsoft.AspNetCore.Mvc;
using ENSPRONET.Domains.Domains;
using ENSPRONET.Web.Models.Country;

namespace ENSPRONET.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> logger;
    private readonly ICountryReadService countryReadService;
    private readonly ICountryCreateService countryCreateService;
    private readonly ICountryUpdateService countryUpdateService;
    private readonly ICountryDeleteService countryDeleteService;

    public CountryController(ILogger<CountryController> logger, ICountryReadService countryReadService, ICountryCreateService countryCreateService,
        ICountryUpdateService countryUpdateService, ICountryDeleteService countryDeleteService)
    {
        this.logger = logger;
        this.countryReadService = countryReadService;
        this.countryCreateService = countryCreateService;
        this.countryUpdateService = countryUpdateService;
        this.countryDeleteService = countryDeleteService;
    }

    [HttpGet]
    public async Task<ActionResult<string>> Get(string alpha2Code)
    {
        if (string.IsNullOrEmpty(alpha2Code))
            return BadRequest();

        Country selectedObject = await countryReadService.ReadByAlpha2Code(alpha2Code);

        CountryReadModel countryReadModel = new CountryReadModel();
        countryReadModel.Map(selectedObject);

        return Ok(countryReadModel);
    }

    [HttpGet("GetAllCountries")]
    public async Task<ActionResult<List<CountryReadModel>>> GetAllCountries()
    {
        List<CountryReadModel> listCountries = new List<CountryReadModel>();

        foreach (var country in await countryReadService.List())
        {
            CountryReadModel model = new CountryReadModel();
            model.Map(country);

            listCountries.Add(model);
        }
        return Ok(listCountries);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CountryCreateModel countryCreateModel)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        Country countryDomain = countryCreateModel.Map();

        return Ok(await countryCreateService.Create(countryDomain));
    }

    [HttpPut]
    public async Task<IActionResult> Put(int id, [FromBody] CountryUpdateModel countryUpdateModel)
    {
        if (id == default(int) || !ModelState.IsValid)
            return BadRequest();

        await countryUpdateService.Update(id, countryUpdateModel.Map());

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        if (id == default(int))
            return BadRequest();

        await countryDeleteService.Delete(id);

        return Ok();
    }
}
