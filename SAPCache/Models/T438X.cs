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
    [Table("T438X")]
    public class T438X
    {
        [Key]
        [Column(Order = 1)]
        public string WERKS { get; set; }//Plant
        [Key]
        [Column(Order = 2)]
        public string DISGR { get; set; }//MRP group
        public string TEXT40 { get; set; }//Text, 40 Characters

    }
    public class T438XManager : SyncManager<T438X>
    {
        public T438XManager(List<string> option) : base(option, "T438X", new Dictionary<string, Expression<Func<T438X, object>>>
            {
            {"WERKS",x=>x.WERKS},
            {"DISGR",x=>x.DISGR},
            {"TEXT40",x=>x.TEXT40},
            })
        {

        }
    }
}
