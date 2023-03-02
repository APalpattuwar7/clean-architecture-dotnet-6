using Domain.Primitives

public sealed class Webinar : Entity
{
    public Webinar(Guid id, string name, DateTime scheduledOn) : base(id)
    {
        Name = name;
        ScheduledOn = scheduledOn;
    }

    public string Name { get; set; }

    public DateTime ScheduledOn { get; set; }
}