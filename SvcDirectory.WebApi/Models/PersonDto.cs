namespace SvcDirectory.WebApi.Models;

public class PersonDto
{
    public string Id { get; }

    public string FirstName { get; }

    public string? MiddleName { get; }

    public string LastName { get; }

    public string? PreferredName { get; }

    public string? Gender { get; }

    public DateTime? DateOfBirth { get; }

    public PersonDto(string id, string firstName, string? middleName, string lastName, string? preferredName,
        string? gender, DateTime? dateOfBirth)
    {
        Id = id;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        PreferredName = preferredName;
        Gender = gender;
        DateOfBirth = dateOfBirth;
    }
}