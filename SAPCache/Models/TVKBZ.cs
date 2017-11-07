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
    [Table("TVKBZ")]
    public class TVKBZ
    {
        [Key]
        [Column(Order = 1)]
        public string VKORG { get; set; } //SaleOrg
        [Key]
        [Column(Order = 2)]
        public string VTWEG { get; set; }  //Channel
        [Key]
        [Column(Order = 3)]
        public string SPART { get; set; }  //Division
        [Key]
        [Column(Order = 4)]
        public string VKBUR { get; set; }  //SaleOffice

    }
    public class TVKBZManager : SyncManager<TVKBZ>
    {
        public TVKBZManager(List<string> option) : base(option, "TVKBZ", new Dictionary<string, Expression<Func<TVKBZ, object>>>
            {
            {"VKORG",x=>x.VKORG},
            {"VTWEG",x=>x.VTWEG},
            {"SPART",x=>x.SPART},
            {"VKBUR",x=>x.VKBUR}
            })
        {

        }
    }
}
