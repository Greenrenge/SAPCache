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
    [Table("TWSPR")]
    public class TWSPR
    {
        [Key]
        public string WRKST { get; set; }//Basic material
    }
    public class TWSPRManager : SyncManager<TWSPR>
    {
        public TWSPRManager(List<string> option) : base(option, "TWSPR", new Dictionary<string, Expression<Func<TWSPR, object>>>
            {
            {"WRKST",x=>x.WRKST},
            })
        {

        }
    }
}
