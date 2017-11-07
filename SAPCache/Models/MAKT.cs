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
    [Table("MAKT")]
    public class MAKT
    {
        [Key]
        public string MATNR { get; set; }//SaleOrg
        public string MAKTX { get; set; }//Desc1
        public string MAKTG { get; set; }//Desc2

    }
    public class MAKTManager : SyncManager<MAKT>
    {
        public MAKTManager(List<string> option) : base(option, "MAKT", new Dictionary<string, Expression<Func<MAKT, object>>>
            {
            {"MATNR",x=>x.MATNR},
            {"MAKTX",x=>x.MAKTX},
            {"MAKTG",x=>x.MAKTG},
            })
        {

        }
    }
}
