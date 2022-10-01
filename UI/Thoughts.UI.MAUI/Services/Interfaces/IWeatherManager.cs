﻿using Thoughts.WebAPI.Clients.Test.Weather;

namespace Thoughts.UI.MAUI.Services.Interfaces
{
    public interface IWeatherManager
    {
        Task<IEnumerable<WeatherInfo>> GetAllInfos(CancellationToken cancellationToken = default);
    }
}
