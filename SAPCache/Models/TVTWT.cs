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
    [Table("TVTWT")]
    public class TVTWT
    {
        [Key]
        public string VTWEG { get; set; }//Channel
        public string VTEXT { get; set; }//Text/Desc

    }
    public class TVTWTManager : SyncManager<TVTWT>
    {
        public TVTWTManager(List<string> option) : base(option, "TVTWT", new Dictionary<string, Expression<Func<TVTWT, object>>>
            {
            {"VTWEG",x=>x.VTWEG},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
