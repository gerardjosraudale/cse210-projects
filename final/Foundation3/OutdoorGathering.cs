public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}
