using Application.model.Base;
using System.ComponentModel.DataAnnotations;

public class BaseDtoWithNameEntity : BaseDtoEntity
{
    [Required]
    public string Name { get; set; }
}