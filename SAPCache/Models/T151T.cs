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
    [Table("T151T")]
    public class T151T
    {
        [Key]
        public string KDGRP { get; set; }//CustomerGroup(SaleManGroup)
        public string KTEXT { get; set; }//Desc

    }
    public class T151TManager : SyncManager<T151T>
    {
        public T151TManager(List<string> option) : base(option, "T151T", new Dictionary<string, Expression<Func<T151T, object>>>
            {
            {"KDGRP",x=>x.KDGRP},
            {"KTEXT",x=>x.KTEXT},
            })
        {

        }
    }
}
