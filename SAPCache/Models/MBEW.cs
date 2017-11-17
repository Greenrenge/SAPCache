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
    [Table("MBEW")]
    public class MBEW
    {
        [Key]
        [Column(Order =1)]
        public string MATNR { get; set; }//Material
        [Key]
        [Column(Order = 2)]
        public string BWKEY { get; set; }//Valuation Area
        [Key]
        [Column(Order = 3)]
        public string BWTAR { get; set; }//Valuation Type
        public string LBKUM { get; set; }//Total Stock
        public string SALK3 { get; set; }//Total Value
        public string VPRSV { get; set; }//Price Control
        public string VERPR { get; set; }//Moving price
        public string STPRS { get; set; }//Standard price
        public string PEINH { get; set; }//Price Unit
        public string BKLAS { get; set; }//Valuation Class
    }
    public class MBEWManager : SyncManager<MBEW>
    {
        public MBEWManager(List<string> option) : base(option, "MBEW", new Dictionary<string, Expression<Func<MBEW, object>>>
            {
            {"MATNR",x=>x.MATNR},
            {"BWKEY",x=>x.BWKEY},
            {"BWTAR",x=>x.BWTAR},
            {"LBKUM",x=>x.LBKUM},
            {"SALK3",x=>x.SALK3},
            {"VPRSV",x=>x.VPRSV},
            {"VERPR",x=>x.VERPR},
            {"STPRS",x=>x.STPRS},
            {"PEINH",x=>x.PEINH},
            {"BKLAS",x=>x.BKLAS},
            })
        {

        }
    }
}
