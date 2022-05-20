using Microsoft.AspNetCore.Mvc;
using SvcDirectory.WebApi.Models;

namespace SvcDirectory.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController
{
    [HttpPost(nameof(ListPeople))]
    public async Task<IEnumerable<PersonDto>> ListPeople(ListPeopleCommandInput input)
    {
        return new List<PersonDto>
        {
            new(
                "DEMO_PERSON_ID",
                "DEMO_FIRST_NAME",
                "DEMO_MIDDLE_NAME",
                "DEMO_LAST_NAME",
                "DEMO_PREFERRED_NAME",
                "MAN",
                new DateTime(1955, 7, 17)
            )
        };
    }
}