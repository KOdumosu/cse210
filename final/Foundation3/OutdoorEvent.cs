
public class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent(string title, string description,DateTime date, DateTime time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Event\nWeather Forecast: {_weatherForecast}";
    }
}
