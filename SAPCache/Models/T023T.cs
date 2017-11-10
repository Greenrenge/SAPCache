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
    [Table("T023T")]
    public class T023T
    {
        [Key]
        public string MATKL { get; set; }//Material Group
        public string WGBEZ { get; set; }//Matl Grp Desc.
        public string WGBEZ60 { get; set; }//Mat.grp desc. 2

    }
    public class T023TManager : SyncManager<T023T>
    {
        public T023TManager(List<string> option) : base(option, "T023T", new Dictionary<string, Expression<Func<T023T, object>>>
            {
            {"MATKL",x=>x.MATKL},
            {"WGBEZ",x=>x.WGBEZ},
            {"WGBEZ60",x=>x.WGBEZ60},
            })
        {

        }
    }
}




