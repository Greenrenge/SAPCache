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
    [Table("TVV1T")]
    public class TVV1T
    {
        [Key]
        public string KVGR1 { get; set; }//CustomerGroup1
        public string BEZEI { get; set; }//Desc

    }
    public class TVV1TManager : SyncManager<TVV1T>
    {
        public TVV1TManager(List<string> option) : base(option, "TVV1T", new Dictionary<string, Expression<Func<TVV1T, object>>>
            {
            {"KVGR1",x=>x.KVGR1},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
