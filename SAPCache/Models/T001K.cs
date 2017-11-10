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
    [Table("T001K")]
    public class T001K
    {
        [Key]
        public string BWKEY { get; set; }//Valuation Area
        public string BUKRS { get; set; }//Company Code


    }
    public class T001KManager : SyncManager<T001K>
    {
        public T001KManager(List<string> option) : base(option, "T001K", new Dictionary<string, Expression<Func<T001K, object>>>
            {
            {"BWKEY",x=>x.BWKEY},
            {"BUKRS",x=>x.BUKRS},
            })
        {

        }
    }
}
