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
    [Table("TQ30T")]
    public class TQ30T
    {
        [Key]
        public string ART { get; set; }//Inspection Type
        public string KURZTEXT { get; set; }//Short text


    }
    public class TQ30TManager : SyncManager<TQ30T>
    {
        public TQ30TManager(List<string> option) : base(option, "TQ30T", new Dictionary<string, Expression<Func<TQ30T, object>>>
            {
            {"ART",x=>x.ART},
            {"KURZTEXT",x=>x.KURZTEXT},
            })
        {

        }
    }
}
