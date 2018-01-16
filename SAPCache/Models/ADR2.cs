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
    [Table("ADR2")]
    public class ADR2
    {
        [Key]
        [Column(Order =1)]
        public string ADDRNUMBER { get; set; }//Address No
        [Key]
        [Column(Order = 2)]
        public string PERSNUMBER { get; set; }//Person No
        [Key]
        [Column(Order = 3)]
        public string CONSNUMBER { get; set; }//Sequence Number
        public string FLGDEFAULT { get; set; }//Standard No.
        public string R3_USER { get; set; }//MobilePhone
        public string TEL_NUMBER { get; set; }//Telephone No
        

    }
    public class ADR2Manager : SyncManager<ADR2>
    {
        public ADR2Manager(List<string> option) : base(option, "ADR2", new Dictionary<string, Expression<Func<ADR2, object>>>
            {
            {"ADDRNUMBER",x=>x.ADDRNUMBER},
            {"PERSNUMBER",x=>x.PERSNUMBER},
            {"CONSNUMBER",x=>x.CONSNUMBER},
            {"FLGDEFAULT",x=>x.FLGDEFAULT},
            {"R3_USER",x=>x.R3_USER},
            {"TEL_NUMBER",x=>x.TEL_NUMBER},
            })
        {

        }
    }
}
