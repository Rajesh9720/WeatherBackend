using System;
using System.Collections.Generic;

namespace BDweather.Models;

public partial class Weather
{
    public int LocationsId { get; set; }

    public string? Locations { get; set; }

    public string? Temp { get; set; }

    public string? WindSpeed { get; set; }

    public string? Precipitation { get; set; }

    public string? Feels { get; set; }

    public string? Clouds { get; set; }
}
