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
    [Table("TVBVK")]
    public class TVBVK
    {
        [Key]
        [Column(Order = 1)]
        public string VKBUR { get; set; } //SaleOffice
        [Key]
        [Column(Order = 2)]
        public string VKGRP { get; set; }  //SaleGroup

    }
    public class TVBVKManager : SyncManager<TVBVK>
    {
        public TVBVKManager(List<string> option) : base(option, "TVBVK", new Dictionary<string, Expression<Func<TVBVK, object>>>
            {
            {"VKBUR",x=>x.VKBUR},
            {"VKGRP",x=>x.VKGRP}
            })
        {

        }
    }
}
