
public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail): base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception Event\nRSVP Email: {_rsvpEmail}";
    }
}
