using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"{GetType().Name}: {_title} - {_date.ToShortDateString()}";
    }
}
