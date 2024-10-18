namespace EducationalApi.Domain.Entities.Exceptions.Users.Collegians
{
    public class CollegianExceptions : Exception
    {
        public List<string> Errors { get; set; } = new();
        public CollegianExceptions() : base() { }
        public CollegianExceptions(string message) : base(message)
        {
            Errors.Add(message);
        }

        public CollegianExceptions(string message, Exception exception) : base(message, exception)
        {
            Errors.Add(message);
        }
    }
}
