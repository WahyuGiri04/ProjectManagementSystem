using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement;


[Table("Employee")]
public class Employee : BaseModel
{
    [Key]
    [Column("id")]
    public int id { get; set; }

    [Column("npp")]
    public string? npp { get; set; }

    [Column("first_name")]
    public string? firstName { get; set; }

    [Column("last_name")]
    public string? lastName { get; set; }

    [Column("full_name")]
    public string? fullName { get; set; }

    [Column("email")]
    public string? email { get; set; }

    [Column("images")]
    public string? images { get; set; }

    [Column("tanggal_lahir")]
    public DateTime? tanggalLahir { get; set; }

    [Column("no_hp")]
    public string? noHp { get; set; }

    [Column("address")]
    public string? address { get; set; }
}
