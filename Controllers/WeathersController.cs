using Microsoft.AspNetCore.Mvc;
using BDweather.Models;

namespace BDweather.Controllers;

[ApiController]
[Route("api/weather")]
public class WeatherControllers : ControllerBase
{
    private readonly WeatherDbContext DB;

public WeatherControllers (WeatherDbContext db)
{
    this.DB = db;
}
[HttpGet("GetWeatherDetails")]





public Weather GetWeatherDetails(string city)
{
    try
    {
       return  DB.Weathers.Where(e =>e.Locations.Equals(city)).FirstOrDefault();
    }
    catch (System.Exception)
    {
        
        throw;
    }
}
}