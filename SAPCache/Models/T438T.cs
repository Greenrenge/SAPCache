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
    [Table("T438T")]
    public class T438T
    {
        [Key]
        public string DISMM { get; set; }//MRP Type
        public string DIBEZ { get; set; }//MRP description

    }
    public class T438TManager : SyncManager<T438T>
    {
        public T438TManager(List<string> option) : base(option, "T438T", new Dictionary<string, Expression<Func<T438T, object>>>
            {
            {"DISMM",x=>x.DISMM},
            {"DIBEZ",x=>x.DIBEZ},
            })
        {

        }
    }
}
