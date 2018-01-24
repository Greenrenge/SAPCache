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
    [Table("TVSBT")]
    public class TVSBT
    {
        [Key]
        public string VSBED { get; set; }//Shipping Condition
        public string VTEXT { get; set; }//Description

    }
    public class TVSBTManager : SyncManager<TVSBT>
    {
        public TVSBTManager(List<string> option) : base(option, "TVSBT", new Dictionary<string, Expression<Func<TVSBT, object>>>
            {
            {"VSBED",x=>x.VSBED},
            {"VTEXT",x=>x.VTEXT}
            })
        {

        }
    }
}
