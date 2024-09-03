using Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Clerks.Commands.InsertClerck;
public class InsertClerkCommand : IRequest<bool>
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime Birthdate { get; set; }
    public string NationalCode { get; set; }
    public bool Gender { get; set; }
    public short Nationalty { get; set; }
    public EnPosition Position { get; set; }
    public string Email { get; set; }
    public long UserCode { get; set; }
}
