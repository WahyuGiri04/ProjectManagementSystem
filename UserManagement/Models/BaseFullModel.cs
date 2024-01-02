using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement;

public class BaseFullModel : BaseModel 
{
    [Column("deleted_date")]
    public DateTime? deletedDate {get;set;}

    [Column("deleted_by")]
    public int? deletedBy {get;set;}
}
