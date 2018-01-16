using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAPCache.Models
{
    [Table("ADR6")]
    public class ADR6
    {
        [Key]
        [Column(Order = 1)]
        public string ADDRNUMBER { get; set; }//Address No
        [Key]
        [Column(Order = 2)]
        public string PERSNUMBER { get; set; }//Person No
        [Key]
        [Column(Order = 3)]
        public string CONSNUMBER { get; set; }//Sequence Number
        public string FLGDEFAULT { get; set; }//Standard No.
        public string SMTP_ADDR { get; set; }//Email Addr
        public string SMTP_SRCH { get; set; }//Email Addr


    }
    public class ADR6Manager : SyncManager<ADR6>
    {
        public ADR6Manager(List<string> option) : base(option, "ADR6", new Dictionary<string, Expression<Func<ADR6, object>>>
            {
            {"ADDRNUMBER",x=>x.ADDRNUMBER},
            {"PERSNUMBER",x=>x.PERSNUMBER},
            {"CONSNUMBER",x=>x.CONSNUMBER},
            {"FLGDEFAULT",x=>x.FLGDEFAULT},
            {"SMTP_ADDR",x=>x.SMTP_ADDR},
            {"SMTP_SRCH",x=>x.SMTP_SRCH},
            })
        {

        }
    }
}
