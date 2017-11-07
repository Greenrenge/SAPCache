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
    [Table("TVGRT")]
    public class TVGRT
    {
        [Key]
        public string VKGRP { get; set; }//SaleGroup
        public string BEZEI { get; set; }//Text/Desc

    }
    public class TVGRTManager : SyncManager<TVGRT>
    {
        public TVGRTManager(List<string> option) : base(option, "TVGRT", new Dictionary<string, Expression<Func<TVGRT, object>>>
            {
            {"VKGRP",x=>x.VKGRP},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
