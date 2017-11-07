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
    [Table("TVV3T")]
    public class TVV3T
    {
        [Key]
        public string KVGR3 { get; set; }//CustomerGroup3
        public string BEZEI { get; set; }//Desc

    }
    public class TVV3TManager : SyncManager<TVV3T>
    {
        public TVV3TManager(List<string> option) : base(option, "TVV3T", new Dictionary<string, Expression<Func<TVV3T, object>>>
            {
            {"KVGR3",x=>x.KVGR3},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
