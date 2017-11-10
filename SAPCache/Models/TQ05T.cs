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
    [Table("TQ05T")]
    public class TQ05T
    {
        [Key]
        public string ZGTYP { get; set; }//CertificateType
        public string KURZTEXT { get; set; }//Short text


    }
    public class TQ05TManager : SyncManager<TQ05T>
    {
        public TQ05TManager(List<string> option) : base(option, "TQ05T", new Dictionary<string, Expression<Func<TQ05T, object>>>
            {
            {"ZGTYP",x=>x.ZGTYP},
            {"KURZTEXT",x=>x.KURZTEXT},
            })
        {

        }
    }
}
