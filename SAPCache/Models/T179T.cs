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
    [Table("T179T")]
    public class T179T
    {
        [Key]
        public string PRODH { get; set; }//Product Hierarchy

        public string VTEXT { get; set; }//Description


    }
    public class T179TManager : SyncManager<T179T>
    {
        public T179TManager(List<string> option) : base(option, "T179T", new Dictionary<string, Expression<Func<T179T, object>>>
            {
            {"PRODH",x=>x.PRODH},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
