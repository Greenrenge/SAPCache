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
    [Table("TVKOT")]
    public class TVKOT
    {
        [Key]
        public string VKORG { get; set; }//SaleOrg
        public string VTEXT { get; set; }//Name

    }
    public class TVKOTManager : SyncManager<TVKOT>
    {
        public TVKOTManager(List<string> option) : base(option, "TVKOT", new Dictionary<string, Expression<Func<TVKOT, object>>>
            {
            {"VKORG",x=>x.VKORG},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
