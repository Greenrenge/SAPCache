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
    [Table("TCK15")]
    public class TCK15
    {
        [Key]
        [Column(Order = 1)]
        public string BWKEY { get; set; }//Valuation Area
        [Key]
        [Column(Order = 2)]
        public string KOSGR { get; set; }//Overhead Group
        public string TXZSCHL { get; set; }//Ovrhd Grp Name

    }
    public class TCK15Manager : SyncManager<TCK15>
    {
        public TCK15Manager(List<string> option) : base(option, "TCK15", new Dictionary<string, Expression<Func<TCK15, object>>>
            {
            {"BWKEY",x=>x.BWKEY},
            {"KOSGR",x=>x.KOSGR},
            {"TXZSCHL",x=>x.TXZSCHL},
            })
        {

        }
    }
}
