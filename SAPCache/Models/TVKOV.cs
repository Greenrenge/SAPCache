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
    [Table("TVKOV")]
    public class TVKOV
    {
        [Key]
        [Column(Order = 1)]
        public string VKORG { get; set; } //SaleOrg
        [Key]
        [Column(Order = 2)]
        public string VTWEG { get;set;}  //Channel

    }
    public class TVKOVManager : SyncManager<TVKOV>
    {
        public TVKOVManager(List<string> option) : base(option, "TVKOV", new Dictionary<string, Expression<Func<TVKOV, object>>>
            {
            {"VKORG",x=>x.VKORG},
            {"VTWEG",x=>x.VTWEG}
            })
        {

        }
    }
}
