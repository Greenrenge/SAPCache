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
    [Table("CEPCT")]
    public class CEPCT
    {
        [Key]
        [Column(Order = 1)]
        public string PRCTR { get; set; }//Profit Center
        [Key]
        [Column(Order = 2)]
        public string DATBI { get; set; }//Valid To
        [Key]
        [Column(Order = 3)]
        public string KOKRS { get; set; }//CO Area
        public string KTEXT { get; set; }//Name
        public string LTEXT { get; set; }//Long Text
        public string MCTXT { get; set; }//PrCtr text

    }
    public class CEPCTManager : SyncManager<CEPCT>
    {
        public CEPCTManager(List<string> option) : base(option, "CEPCT", new Dictionary<string, Expression<Func<CEPCT, object>>>
            {
            {"PRCTR",x=>x.PRCTR},
            {"DATBI",x=>x.DATBI},
            {"KOKRS",x=>x.KOKRS},
            {"KTEXT",x=>x.KTEXT},
            {"LTEXT",x=>x.LTEXT},
            {"MCTXT",x=>x.MCTXT},
            })
        {

        }
    }
}
