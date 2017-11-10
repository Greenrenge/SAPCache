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
    [Table("T134T")]
    public class T134T
    {
        [Key]
        public string MTART { get; set; }//Material Type
        public string MTBEZ { get; set; }//Mat.type descr.


    }
    public class T134TManager : SyncManager<T134T>
    {
        public T134TManager(List<string> option) : base(option, "T134T", new Dictionary<string, Expression<Func<T134T, object>>>
            {
            {"MTART",x=>x.MTART},
            {"MTBEZ",x=>x.MTBEZ},
            })
        {

        }
    }
}
