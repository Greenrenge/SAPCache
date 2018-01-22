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
    [Table("KNKK")]
    public class KNKK
    {
        [Key]
        [Column(Order = 1)]
        public string KUNNR { get; set; }//CUSTOMER CODE
        [Key]
        [Column(Order = 2)]
        public string KKBER { get; set; }//CREDIT CONTROL AREA
        public string KLIMK { get; set; }//CREDIT LIMIT


    }
    public class KNKKManager : SyncManager<KNKK>
    {
        public KNKKManager(List<string> option) : base(option, "KNKK", new Dictionary<string, Expression<Func<KNKK, object>>>
            {
            {"KUNNR",x=>x.KUNNR},
            {"KKBER",x=>x.KKBER},
            {"KLIMK",x=>x.KLIMK},
            })
        {

        }
    }
}
