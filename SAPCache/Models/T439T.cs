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
    [Table("T439T")]
    public class T439T
    {
        [Key]
        public string DISLS { get; set; }//Lot size
        public string LOSLT { get; set; }//Description


    }
    public class T439TManager : SyncManager<T439T>
    {
        public T439TManager(List<string> option) : base(option, "T439T", new Dictionary<string, Expression<Func<T439T, object>>>
            {
            {"DISLS",x=>x.DISLS},
            {"LOSLT",x=>x.LOSLT},
            })
        {

        }
    }
}
