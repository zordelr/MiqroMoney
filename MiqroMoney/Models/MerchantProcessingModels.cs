using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MiqroMoney.Models
{
    public class MIDContext : DbContext
    {
        public MIDContext() : base("DefaultConnection")
        {
        }

        public DbSet<MerchantProcessingIDs> mid { get; set; }
    }

    [Table("MerchantProcessingIDs")]
    public class MerchantProcessingIDs
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MerchantProcessingID { get; set; }
        public Int64 MerchantID { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }
        public DateTime LastModifiedTimestamp { get; set; }

    }


}
