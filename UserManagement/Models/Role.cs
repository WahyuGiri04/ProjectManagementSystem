using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement;

[Table("role")]
public class Role
{
    [Key]
    public int Id { get; set; }
    [Column("role")]
    public required string Roles { get; set; }
}
