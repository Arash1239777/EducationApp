namespace EducationalApi.Domain.Entities.Exceptions.Users.Masters;
public class MastersExeptions : Exception
{
    public List<string> Errors { get; set; } = new();
    public MastersExeptions() : base() { }
    public MastersExeptions(string message): base(message)
    {
        Errors.Add(message);   
    }

    public MastersExeptions(string message, Exception exception) : base(message, exception)
    {
        Errors.Add(message);
    }
}
