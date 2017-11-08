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
    [Table("SKAT")]
    public class SKAT
    {
        [Key]
        [Column(Order = 1)]
        public string KTOPL { get; set; }//chart of account
        [Key]
        [Column(Order = 2)]
        public string SAKNR { get; set; }//G/L Account

        public string TXT20 { get; set; }//short text
        public string TXT50 { get; set; }//long text
        public string MCOD1 { get; set; }//long text

    }
    public class SKATManager : SyncManager<SKAT>
    {
        public SKATManager(List<string> option) : base(option, "SKAT", new Dictionary<string, Expression<Func<SKAT, object>>>
            {
            {"KTOPL",x=>x.KTOPL},
            {"SAKNR",x=>x.SAKNR},
            {"TXT20",x=>x.TXT20},
            {"TXT50",x=>x.TXT50},
            {"MCOD1",x=>x.MCOD1},
            })
        {

        }
    }
}
