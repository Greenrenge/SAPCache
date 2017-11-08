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
    [Table("TVM3T")]
    public class TVM3T
    {
        [Key]
        public string MVGR3 { get; set; }//Material Group3

        public string BEZEI { get; set; }//Description


    }
    public class TVM3TManager : SyncManager<TVM3T>
    {
        public TVM3TManager(List<string> option) : base(option, "TVM3T", new Dictionary<string, Expression<Func<TVM3T, object>>>
            {
            {"MVGR3",x=>x.MVGR3},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
