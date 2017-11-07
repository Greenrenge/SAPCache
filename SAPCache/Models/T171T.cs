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
    [Table("T171T")]
    public class T171T
    {
        [Key]
        public string BZIRK { get; set; }//SaleDistrict
        public string BZTXT { get; set; }//Name

    }
    public class T171TManager : SyncManager<T171T>
    {
        public T171TManager(List<string> option) : base(option, "T171T", new Dictionary<string, Expression<Func<T171T, object>>>
            {
            {"BZIRK",x=>x.BZIRK},
            {"BZTXT",x=>x.BZTXT},
            })
        {

        }
    }
}
