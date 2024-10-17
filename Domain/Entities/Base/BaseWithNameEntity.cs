using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
public class BaseWithNameEntity: BaseEntity
{
    [Required]
    public string Name { get; set; }
}