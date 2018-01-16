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
    [Table("PA0001")]
    public class PA0001
    {
        [Key]
        [Column(Order = 1)]
        public string PERNR { get; set; }//Personal No. (SE)
        [Key]
        [Column(Order =2)]
        public string ENDDA { get; set; }
        public string ENAME { get; set; }//Employee Name
        public string BUKRS { get; set; }//Company Code

    }
    public class PA0001Manager : SyncManager<PA0001>
    {
        public PA0001Manager(List<string> option) : base(option, "PA0001", new Dictionary<string, Expression<Func<PA0001, object>>>
            {
            {"PERNR",x=>x.PERNR},
            {"ENDDA",x=>x.ENDDA},
            {"ENAME",x=>x.ENAME},
            {"BUKRS",x=>x.BUKRS},
            })
        {

        }
    }
}
