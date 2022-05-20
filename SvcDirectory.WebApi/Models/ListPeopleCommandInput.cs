using System.ComponentModel.DataAnnotations;

namespace SvcDirectory.WebApi.Models;

public class ListPeopleCommandInput
{
    [Required]
    public string DirectoryId { get; init; }
}