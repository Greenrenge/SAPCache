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
    [Table("TCK14")]
    public class TCK14
    {
        [Key]
        [Column(Order = 1)]
        public string BWKEY { get; set; }//Valuation Area
        [Key]
        [Column(Order = 2)]
        public string KOSGR { get; set; }//Overhead Group
        public string ZSCHL { get; set; }//Overhead key

    }
    public class TCK14Manager : SyncManager<TCK14>
    {
        public TCK14Manager(List<string> option) : base(option, "TCK14", new Dictionary<string, Expression<Func<TCK14, object>>>
            {
            {"BWKEY",x=>x.BWKEY},
            {"KOSGR",x=>x.KOSGR},
            {"ZSCHL",x=>x.ZSCHL},
            })
        {

        }
    }
}
