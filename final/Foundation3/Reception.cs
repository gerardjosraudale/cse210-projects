public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
