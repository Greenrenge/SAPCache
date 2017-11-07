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
    [Table("TVKBT")]
    public class TVKBT
    {
        [Key]
        public string VKBUR { get; set; }//SaleOffice
        public string BEZEI { get; set; }//Text/Desc

    }
    public class TVKBTManager : SyncManager<TVKBT>
    {
        public TVKBTManager(List<string> option) : base(option, "TVKBT", new Dictionary<string, Expression<Func<TVKBT, object>>>
            {
            {"VKBUR",x=>x.VKBUR},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
