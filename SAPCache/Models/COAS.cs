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
    [Table("COAS")]
    public class COAS
    {
        [Key]
        public string AUFNR { get; set; }//Order Code
        public string AUART { get; set; }//Order Type
        public string AUTYP { get; set; }//Order Category
        public string REFNR { get; set; }//Reference Order
        public string KTEXT { get; set; }//Description
        public string BUKRS { get; set; }//Company Code
        //public string WERKS { get; set; }//Plant
        public string WAERS { get; set; }//currency
        public string OBJNR { get; set; }//Object Number
        public string PRCTR { get; set; }//profit center
    }
    public class COASManager : SyncManager<COAS>
    {
        public COASManager(List<string> option) : base(option, "COAS", new Dictionary<string, Expression<Func<COAS, object>>>
            {
            {"AUFNR",x=>x.AUFNR},
            {"AUART",x=>x.AUART},
            {"AUTYP",x=>x.AUTYP},
            {"REFNR",x=>x.REFNR},
            {"KTEXT",x=>x.KTEXT},
            {"BUKRS",x=>x.BUKRS},
            //{"WERKS",x=>x.WERKS},
            {"WAERS",x=>x.WAERS},
            {"OBJNR",x=>x.OBJNR},
            {"PRCTR",x=>x.PRCTR}
            })
        {

        }
    }
}
