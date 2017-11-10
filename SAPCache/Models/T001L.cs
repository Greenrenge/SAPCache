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
    [Table("T001L")]
    public class T001L
    {
        [Key]
        [Column(Order = 1)]
        public string WERKS { get; set; }//Plant
        [Key]
        [Column(Order = 2)]
        public string LGORT { get; set; }//Stor. Location
        public string LGOBE { get; set; }//Description

    }
    public class T001LManager : SyncManager<T001L>
    {
        public T001LManager(List<string> option) : base(option, "T001L", new Dictionary<string, Expression<Func<T001L, object>>>
            {
            {"WERKS",x=>x.WERKS},
            {"LGORT",x=>x.LGORT},
            {"LGOBE",x=>x.LGOBE},
            })
        {

        }
    }
}
