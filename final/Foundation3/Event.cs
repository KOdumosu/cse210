
public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address; 
    }

    public virtual string GetStandardDetails()
    {
          return $"Standard Details-\nTitle: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.ToString()}";
    }

    public virtual string  GetFullDetails()
    {
        return $"Full Details-\nTitle: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.ToString()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Short Descrition-\nType: Generic Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
