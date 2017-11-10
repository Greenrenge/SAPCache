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
    [Table("TQ08T")]
    public class TQ08T
    {
        [Key]
        public string QM_PUR { get; set; }//QM Control Key
        public string KURZTEXT { get; set; }//Short text


    }
    public class TQ08TManager : SyncManager<TQ08T>
    {
        public TQ08TManager(List<string> option) : base(option, "TQ08T", new Dictionary<string, Expression<Func<TQ08T, object>>>
            {
            {"QM_PUR",x=>x.QM_PUR},
            {"KURZTEXT",x=>x.KURZTEXT},
            })
        {

        }
    }
}
