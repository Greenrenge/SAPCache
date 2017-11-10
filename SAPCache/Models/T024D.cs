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
    [Table("T024D")]
    public class T024D
    {
        [Key]
        [Column(Order =1)]
        public string WERKS { get; set; }//Plant
        [Key]
        [Column(Order = 2)]
        public string DISPO { get; set; }//MRP Controller
        public string DSNAM { get; set; }//Controller name

    }
    public class T024DManager : SyncManager<T024D>
    {
        public T024DManager(List<string> option) : base(option, "T024D", new Dictionary<string, Expression<Func<T024D, object>>>
            {
            {"WERKS",x=>x.WERKS},
            {"DISPO",x=>x.DISPO},
            {"DSNAM",x=>x.DSNAM},
            })
        {

        }
    }
}
