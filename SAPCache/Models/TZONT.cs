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
    [Table("TZONT")]
    public class TZONT
    {
        [Key]
        public string ZONE1 { get; set; }//TransportZone
        public string VTEXT { get; set; }//Desc

    }
    public class TZONTManager : SyncManager<TZONT>
    {
        public TZONTManager(List<string> option) : base(option, "TZONT", new Dictionary<string, Expression<Func<TZONT, object>>>
            {
            {"ZONE1",x=>x.ZONE1},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
