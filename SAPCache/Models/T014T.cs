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
    [Table("T014T")]
    public class T014T
    {
        [Key]
        public string KKBER { get; set; }//CreditControlArea
        public string KKBTX { get; set; }//Desc

    }
    public class T014TManager : SyncManager<T014T>
    {
        public T014TManager(List<string> option) : base(option, "T014T", new Dictionary<string, Expression<Func<T014T, object>>>
            {
            {"KKBER",x=>x.KKBER},
            {"KKBTX",x=>x.KKBTX},
            })
        {

        }
    }
}
