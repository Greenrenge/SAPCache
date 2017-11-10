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
    [Table("T025T")]
    public class T025T
    {
        [Key]
        public string BKLAS { get; set; }//Valuation Class
        public string BKBEZ { get; set; }//Description


    }
    public class T025TManager : SyncManager<T025T>
    {
        public T025TManager(List<string> option) : base(option, "T025T", new Dictionary<string, Expression<Func<T025T, object>>>
            {
            {"BKLAS",x=>x.BKLAS},
            {"BKBEZ",x=>x.BKBEZ},
            })
        {

        }
    }
}
