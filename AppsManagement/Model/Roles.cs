using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppsManagement;

[Table("Roles")]
public class Roles : BaseModel
{
    [Key]
    [Column("id")]
    public int id { get; set; }

    [Column("role")]
    public string? Role { get; set; }
}
