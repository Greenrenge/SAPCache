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
    [Table("TVSMT")]
    public class TVSMT
    {
        [Key]
        public string STGMA { get; set; }//Matl stats grp
        public string BEZEI20 { get; set; }//Description


    }
    public class TVSMTManager : SyncManager<TVSMT>
    {
        public TVSMTManager(List<string> option) : base(option, "TVSMT", new Dictionary<string, Expression<Func<TVSMT, object>>>
            {
            {"STGMA",x=>x.STGMA},
            {"BEZEI20",x=>x.BEZEI20},
            })
        {

        }
    }
}
