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
    [Table("LFA1")]
    public class LFA1
    {
        [Key]
        public string LIFNR {get;set;}//vendor
        public string LAND1 {get;set;}//country
        public string NAME1 {get;set;}//name1
        public string NAME2 {get;set;}//name2
        public string ADRNR {get;set;}//address code
        public string KTOKK {get;set;}//accountgroup
        public string KUNNR {get;set;}//customer code
        public string STCD1 {get;set;}//tax1
        public string STCD2 {get;set;}//tax2
        public string VBUND {get;set;}//tradding partner
        public string STCEG { get; set; } //vat regis
    }
    public class LFA1Manager : SyncManager<LFA1>
    {
        public LFA1Manager(List<string> option) : base(option, "LFA1", new Dictionary<string, Expression<Func<LFA1, object>>>
            {
            {"LIFNR",x=>x.LIFNR},
            {"LAND1",x=>x.LAND1},
            {"NAME1",x=>x.NAME1},
            {"NAME2",x=>x.NAME2},
            {"ADRNR",x=>x.ADRNR},
            {"KTOKK",x=>x.KTOKK},
            {"KUNNR",x=>x.KUNNR},
            {"STCD1",x=>x.STCD1},
            {"STCD2",x=>x.STCD2},
            {"VBUND",x=>x.VBUND},
            {"STCEG",x=>x.STCEG}
            })
        {

        }
    }
}
