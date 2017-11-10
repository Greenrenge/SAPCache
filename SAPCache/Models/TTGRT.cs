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
    [Table("TTGRT")]
    public class TTGRT
    {
        [Key]
        public string TRAGR { get; set; }//Trans. Group
        public string VTEXT { get; set; }//Description


    }
    public class TTGRTManager : SyncManager<TTGRT>
    {
        public TTGRTManager(List<string> option) : base(option, "TTGRT", new Dictionary<string, Expression<Func<TTGRT, object>>>
            {
            {"TRAGR",x=>x.TRAGR},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
