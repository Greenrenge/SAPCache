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
    [Table("TVV2T")]
    public class TVV2T
    {
        [Key]
        public string KVGR2 { get; set; }//CustomerGroup2
        public string BEZEI { get; set; }//Desc

    }
    public class TVV2TManager : SyncManager<TVV2T>
    {
        public TVV2TManager(List<string> option) : base(option, "TVV2T", new Dictionary<string, Expression<Func<TVV2T, object>>>
            {
            {"KVGR2",x=>x.KVGR2},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
