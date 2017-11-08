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
    [Table("SKA1")]
    public class SKA1
    {
        [Key]
        [Column(Order = 1)]
        public string KTOPL { get; set; }//chart of account
        [Key]
        [Column(Order = 2)]
        public string SAKNR { get; set; }//G/L Account

        public string XBILK { get; set; }//balance sheet account
        public string KTOKS { get; set; }//AccountGroup
        public string XLOEV { get; set; }//Deletion flag

    }
    public class SKA1Manager : SyncManager<SKA1>
    {
        public SKA1Manager(List<string> option) : base(option, "SKA1", new Dictionary<string, Expression<Func<SKA1, object>>>
            {
            {"KTOPL",x=>x.KTOPL},
            {"SAKNR",x=>x.SAKNR},
            {"XBILK",x=>x.XBILK},
            {"KTOKS",x=>x.KTOKS},
            {"XLOEV",x=>x.XLOEV},
            })
        {

        }
    }
}
