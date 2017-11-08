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
    [Table("TVM1T")]
    public class TVM1T
    {
        [Key]
        public string MVGR1 { get; set; }//Material Group1

        public string BEZEI { get; set; }//Description


    }
    public class TVM1TManager : SyncManager<TVM1T>
    {
        public TVM1TManager(List<string> option) : base(option, "TVM1T", new Dictionary<string, Expression<Func<TVM1T, object>>>
            {
            {"MVGR1",x=>x.MVGR1},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
