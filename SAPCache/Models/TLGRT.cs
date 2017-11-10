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
    [Table("TLGRT")]
    public class TLGRT
    {
        [Key]
        public string LADGR { get; set; }//Loading Group
        public string VTEXT { get; set; }//Description


    }
    public class TLGRTManager : SyncManager<TLGRT>
    {
        public TLGRTManager(List<string> option) : base(option, "TLGRT", new Dictionary<string, Expression<Func<TLGRT, object>>>
            {
            {"LADGR",x=>x.LADGR},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
