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
    [Table("TVM4T")]
    public class TVM4T
    {
        [Key]
        public string MVGR4 { get; set; }//Material Group4

        public string BEZEI { get; set; }//Description


    }
    public class TVM4TManager : SyncManager<TVM4T>
    {
        public TVM4TManager(List<string> option) : base(option, "TVM4T", new Dictionary<string, Expression<Func<TVM4T, object>>>
            {
            {"MVGR4",x=>x.MVGR4},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
