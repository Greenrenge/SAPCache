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
    [Table("T005T")]
    public class T005T
    {
        [Key]
        public string LAND1 { get; set; }//Country
        public string LANDX { get; set; }//Text

    }
    public class T005TManager : SyncManager<T005T>
    {
        public T005TManager(List<string> option) : base(option, "T005T", new Dictionary<string, Expression<Func<T005T, object>>>
            {
            {"LAND1",x=>x.LAND1},
            {"LANDX",x=>x.LANDX},
            })
        {

        }
    }
}
