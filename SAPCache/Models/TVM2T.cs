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
    [Table("TVM2T")]
    public class TVM2T
    {
        [Key]
        public string MVGR2 { get; set; }//Material Group2

        public string BEZEI { get; set; }//Description


    }
    public class TVM2TManager : SyncManager<TVM2T>
    {
        public TVM2TManager(List<string> option) : base(option, "TVM2T", new Dictionary<string, Expression<Func<TVM2T, object>>>
            {
            {"MVGR2",x=>x.MVGR2},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
