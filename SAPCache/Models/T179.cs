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
    [Table("T179")]
    public class T179
    {
        [Key]
        public string PRODH { get; set; }//Product Hierarchy
      
        public string STUFE { get; set; }//Level Number
       

    }
    public class T179Manager : SyncManager<T179>
    {
        public T179Manager(List<string> option) : base(option, "T179", new Dictionary<string, Expression<Func<T179, object>>>
            {
            {"PRODH",x=>x.PRODH},
            {"STUFE",x=>x.STUFE},
            })
        {

        }
    }
}
