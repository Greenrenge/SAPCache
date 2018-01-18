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
    [Table("KNVP")]
    public class KNVP
    {
        [Key]
        [Column(Order = 1)]
        public string KUNNR { get; set; }
        [Key]
        [Column(Order = 2)]
        public string VKORG { get; set; }
        [Key]
        [Column(Order = 3)]
        public string VTWEG { get; set; }
        [Key]
        [Column(Order = 4)]
        public string SPART { get; set; }
        [Key]
        [Column(Order = 5)]
        public string PARVW { get; set; }
        [Key]
        [Column(Order = 6)]
        public string PARZA { get; set; }
        public string KUNN2 { get; set; }
        public string LIFNR { get; set; }
        public string PERNR { get; set; }
        public string PARNR { get; set; }
        public string KNREF { get; set; }
        public string DEFPA { get; set; }


    }
    public class KNVPManager : SyncManager<KNVP>
    {
        public KNVPManager(List<string> option) : base(option, "KNVP", new Dictionary<string, Expression<Func<KNVP, object>>>
            {
            {"KUNNR",x=>x.KUNNR},
            {"VKORG",x=>x.VKORG},
            {"VTWEG",x=>x.VTWEG},
            {"SPART",x=>x.SPART},
            {"PARVW",x=>x.PARVW},
            {"PARZA",x=>x.PARZA},
            {"KUNN2",x=>x.KUNN2},
            {"LIFNR",x=>x.LIFNR},
            {"PERNR",x=>x.PERNR},
            {"PARNR",x=>x.PARNR},
            {"KNREF",x=>x.KNREF},
            {"DEFPA",x=>x.DEFPA},
            })
        {

        }
    }
}
