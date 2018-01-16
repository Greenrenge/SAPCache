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
    [Table("T005U")]
    public class T005U
    {
        [Key]
        [Column(Order =1)]
        public string BLAND { get; set; }//Region   
        [Key]
        [Column(Order = 2)]
        public string LAND1 { get; set; }//Country
        public string BEZEI { get; set; }//Description

    }
    public class T005UManager : SyncManager<T005U>
    {
        public T005UManager(List<string> option) : base(option, "T005U", new Dictionary<string, Expression<Func<T005U, object>>>
            {
            {"BLAND",x=>x.BLAND},
            {"LAND1",x=>x.LAND1},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
