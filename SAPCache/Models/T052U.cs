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
    [Table("T052U")]
    public class T052U
    {
        [Key]
        public string ZTERM { get; set; }//PaymentTerm
        public string TEXT1 { get; set; }//Desc

    }
    public class T052UManager : SyncManager<T052U>
    {
        public T052UManager(List<string> option) : base(option, "T052U", new Dictionary<string, Expression<Func<T052U, object>>>
            {
            {"ZTERM",x=>x.ZTERM},
            {"TEXT1",x=>x.TEXT1},
            })
        {

        }
    }
}
