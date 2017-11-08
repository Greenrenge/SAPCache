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
    [Table("MVKE")]
    public class MVKE
    {
        [Key]
        [Column(Order = 1)]
        public string MATNR { get; set; }//Mat Code
        [Key]
        [Column(Order = 2)]
        public string VKORG { get; set; }//Sale Org
        [Key]
        [Column(Order = 3)]
        public string VTWEG { get; set; }//Channel

        public string VERSG { get; set; }//Material Statistic group
        public string SKTOF { get; set; }//Cash Discount
        public string VRKME { get; set; }//SaleUnit
        public string MTPOS { get; set; }//Item Category Group
        public string DWERK { get; set; }//Delivery Plant
        public string PRODH { get; set; }//Product Hierarchy
        public string KONDM { get; set; }//Material pricing group
        public string KTGRM { get; set; }//Acct assignment group
        public string MVGR1 { get; set; }//Mat group1
        public string MVGR2 { get; set; }//Mat group2
        public string MVGR3 { get; set; }//Mat group3
        public string MVGR4 { get; set; }//Mat group4
        public string MVGR5 { get; set; }//Mat group5

    }
    public class MVKEManager : SyncManager<MVKE>
    {
        public MVKEManager(List<string> option) : base(option, "MVKE", new Dictionary<string, Expression<Func<MVKE, object>>>
            {
            {"MATNR",x=>x.MATNR},
            {"VKORG",x=>x.VKORG},
            {"VTWEG",x=>x.VTWEG},
            {"VERSG",x=>x.VERSG},
            {"SKTOF",x=>x.SKTOF},
            {"VRKME",x=>x.VRKME},
            {"MTPOS",x=>x.MTPOS},
            {"DWERK",x=>x.DWERK},
            {"PRODH",x=>x.PRODH},
            {"KONDM",x=>x.KONDM},
            {"KTGRM",x=>x.KTGRM},
            {"MVGR1",x=>x.MVGR1},
            {"MVGR2",x=>x.MVGR2},
            {"MVGR3",x=>x.MVGR3},
            {"MVGR4",x=>x.MVGR4},
            {"MVGR5",x=>x.MVGR5},
            })
        {

        }
    }
}
