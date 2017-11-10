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
    [Table("T190ST")]
    public class T190ST
    {
        [Key]
        public string KOSCH { get; set; }//Prod.allocation
        public string VTEXT { get; set; }//Description


    }
    public class T190STManager : SyncManager<T190ST>
    {
        public T190STManager(List<string> option) : base(option, "T190ST", new Dictionary<string, Expression<Func<T190ST, object>>>
            {
            {"KOSCH",x=>x.KOSCH},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
