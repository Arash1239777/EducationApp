namespace EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
public class ClercksExeptions : Exception
{
    public List<string> Errors { get; set; } = new();
    public ClercksExeptions() : base() { }
    public ClercksExeptions(string message) : base(message)
    {
        Errors.Add(message);
    }

    public ClercksExeptions(string message, Exception exception) : base(message, exception)
    {
        Errors.Add(message);
    }
}
