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
    [Table("V_AUART")]
    public class V_AUART
    {
        [Key]
        public string AUART { get; set; }//Order Type
        public string AUTYP { get; set; }//Order Category
        public string TXT { get; set; }//short text
    }
    public class V_AUARTManager : SyncManager<V_AUART>
    {
        public V_AUARTManager(List<string> option) : base(option, "V_AUART", new Dictionary<string, Expression<Func<V_AUART, object>>>
            {
            {"AUART",x=>x.AUART },
            {"AUTYP",x=>x.AUTYP },
            {"TXT"  ,x=>x.TXT }
            })     
        {

        }
    }
}
