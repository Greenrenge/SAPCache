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
    [Table("T025")]
    public class T025
    {
        [Key]
        public string BKLAS { get; set; }//Valuation Class
        public string KKREF { get; set; }//Acct cat. ref.


    }
    public class T025Manager : SyncManager<T025>
    {
        public T025Manager(List<string> option) : base(option, "T025", new Dictionary<string, Expression<Func<T025, object>>>
            {
            {"BKLAS",x=>x.BKLAS},
            {"KKREF",x=>x.KKREF},
            })
        {

        }
    }
}
