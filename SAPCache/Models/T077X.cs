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
    [Table("T077X")]
    public class T077X
    {
        [Key]
        public string KTOKD { get; set; }//AccountGroup
        public string TXT30 { get; set; }//Desc

    }
    public class T077XManager : SyncManager<T077X>
    {
        public T077XManager(List<string> option) : base(option, "T077X", new Dictionary<string, Expression<Func<T077X, object>>>
            {
            {"KTOKD",x=>x.KTOKD},
            {"TXT30",x=>x.TXT30},
            })
        {

        }
    }
}
