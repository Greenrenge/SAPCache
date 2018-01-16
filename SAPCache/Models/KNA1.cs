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
    [Table("KNA1")]
    public class KNA1 
    {
        [Key]
        public string KUNNR { get; set; }//customer code
        public string LAND1 { get; set; }//country
        public string NAME1 { get; set; }//name1
        public string NAME2 { get; set; }//name2
        public string KTOKD { get; set; }//account group
        public string LIFNR { get; set; }//vendor code
        public string STCEG { get; set; }//vat regis
        public string STCD1 { get; set; }//tax num1
        public string STCD2 { get; set; }//tax num2
        public string STCD3 { get; set; }//tax num3

        public string AUFSD { get; set; }//Order Block
        public string FAKSD { get; set; }//Billing Block
        public string LIFSD { get; set; }//Delivery Block
        public string CASSD { get; set; }//Sale Block
        public string LZONE { get; set; }//transportZone
        public string VBUND { get; set; }//Trading Partner
        public string ADRNR { get; set; }//Address Number (FK)

    }
    public class KNA1Manger: SyncManager<KNA1>
    {
        public KNA1Manger(List<string> option):base(option,"KNA1", new Dictionary<string, Expression<Func<KNA1, object>>>
            {
                {"KUNNR" ,x=>x.KUNNR},
                {"LAND1" ,x=>x.LAND1},
                {"NAME1" ,x=>x.NAME1},
                {"NAME2" ,x=>x.NAME2},
                {"KTOKD" ,x=>x.KTOKD},
                {"LIFNR" ,x=>x.LIFNR},
                {"STCEG" ,x=>x.STCEG},
                {"STCD1" ,x=>x.STCD1},
                {"STCD2" ,x=>x.STCD2},
                {"STCD3" ,x=>x.STCD3},
                {"AUFSD" ,x=>x.AUFSD},
                {"FAKSD" ,x=>x.FAKSD},
                {"LIFSD" ,x=>x.LIFSD},
                {"CASSD" ,x=>x.CASSD},
                {"LZONE" ,x=>x.LZONE},
                {"VBUND" ,x=>x.VBUND},
                {"ADRNR" ,x=>x.ADRNR},
            })
        {

        }
    }
}
