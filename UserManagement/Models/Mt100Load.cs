using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement;

[Table("MT100_Load")]
public partial class Mt100Load
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("client_id")]
        public string? ClientId { get; set; }
        [Column("code")]
        public string? Code { get; set; }
        [Column("refnumber")]
        public string? Refnumber { get; set; }
        [Column("valuedate")]
        public string? Valuedate { get; set; }
        [Column("ccy")]
        public string? Ccy { get; set; }
        [Column("amount")]
        public string? Amount { get; set; }
        [Column("orderingpartyname")]
        public string? Orderingpartyname { get; set; }
        [Column("orderingpartyaccount")]
        public string? Orderingpartyaccount { get; set; }
        [Column("filler1")]
        public string? Filler1 { get; set; }
        [Column("filler2")]
        public string? Filler2 { get; set; }
        [Column("filler3")]
        public string? Filler3 { get; set; }
        [Column("filler4")]
        public string? Filler4 { get; set; }
        [Column("filler5")]
        public string? Filler5 { get; set; }
        [Column("filler6")]
        public string? Filler6 { get; set; }
        [Column("bene_bank_code")]
        public string? BeneBankCode { get; set; }
        [Column("bene_bank_name")]
        public string? BeneBankName { get; set; }
        [Column("bene_bank_add1")]
        public string? BeneBankAdd1 { get; set; }
        [Column("bene_bank_add2")]
        public string? BeneBankAdd2 { get; set; }
        [Column("bene_account_no")]
        public string? BeneAccountNo { get; set; }
        [Column("bene_name")]
        public string? BeneName { get; set; }
        [Column("remark1")]
        public string? Remark1 { get; set; }
        [Column("remark2")]
        public string? Remark2 { get; set; }
        [Column("charge")]
        public string? Charge { get; set; }
        [Column("emailbene")]
        public string? Emailbene { get; set; }
        [Column("statusbnidirect")]
        public string? Statusbnidirect { get; set; }
        [Column("statusbnidirectdesc")]
        public string? Statusbnidirectdesc { get; set; }
        [Column("filerefno")]
        public string? Filerefno { get; set; }
        [Column("trxrefno")]
        public string? Trxrefno { get; set; }
        [Column("hostjurnal")]
        public string? Hostjurnal { get; set; }
}
