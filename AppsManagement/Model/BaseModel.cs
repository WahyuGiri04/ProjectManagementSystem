using System.ComponentModel.DataAnnotations.Schema;

namespace AppsManagement;

public class BaseModel
{
    [Column("created_date")]
    public DateTime createdDate {get;set;}

    [Column("created_by")]
    public int createdBy {get;set;}

    [Column("last_updated_date")]
    public DateTime lastUpdatedDate {get;set;}

    [Column("last_updated_by")]
    public int lastUpdatedBy {get;set;}

    [Column("is_active")]
    public bool isActive {get;set;}

    [Column("is_deleted")]
    public bool isDeleted {get;set;}

}
