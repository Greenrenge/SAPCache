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
    [Table("KNVV")]
    public class KNVV
    {
        [Key]
        [Column(Order = 1)]
        public string KUNNR { get; set; }//customer code
        [Key]
        [Column(Order = 2)]
        public string VKORG { get; set; }//Sale org
        [Key]
        [Column(Order = 3)]
        public string VTWEG { get; set; }//Channel
        [Key]
        [Column(Order = 4)]
        public string SPART { get; set; }//Division

        public string VERSG { get; set; }//CustomerStatisticGroup
        public string KALKS { get; set; }//CustomerPriceProcedure
        public string KDGRP { get; set; }//CustomerGroup
        public string BZIRK { get; set; }//SalesDistrict
        public string INCO1 { get; set; }//Incoterms
        public string INCO2 { get; set; }//Incoterms(Part2)
        public string ANTLF { get; set; }//Max.Part.Deliveries
        public string KZTLF { get; set; }//Part.dlv./item
        public string KZAZU { get; set; }//Order Combination
        public string LPRIO { get; set; }//Delivery Priority
        public string VSBED { get; set; }//Shipping Condition
        public string WAERS { get; set; }//Currency
        public string KTGRD { get; set; }//AcctAssgGr
        public string ZTERM { get; set; }//TermOfPayment
        public string VKGRP { get; set; }//SalesGroup
        public string VKBUR { get; set; }//SalesOffice
        public string KVGR1 { get; set; }//CustomerGroup1
        public string KVGR2 { get; set; }//CustomerGroup2
        public string KVGR3 { get; set; }//CustomerGroup3
        public string KVGR4 { get; set; }//CustomerGroup4
        public string KVGR5 { get; set; }//CustomerGroup5
        public string KURST { get; set; }//ExchangeRateType
        public string KKBER { get; set; }//CreditControlArea
        public string CASSD { get; set; }//SaleBlock
    }
    public class KNVVManager : SyncManager<KNVV>
    {
        public KNVVManager(List<string> option) : base(option, "KNVV", new Dictionary<string, Expression<Func<KNVV, object>>>
            {
            {"KUNNR",x=>x.KUNNR},
            {"VKORG",x=>x.VKORG},
            {"VTWEG",x=>x.VTWEG},
            {"SPART",x=>x.SPART},
            {"VERSG",x=>x.VERSG},
            {"KALKS",x=>x.KALKS},
            {"KDGRP",x=>x.KDGRP},
            {"BZIRK",x=>x.BZIRK},
            {"INCO1",x=>x.INCO1},
            {"INCO2",x=>x.INCO2},
            {"ANTLF",x=>x.ANTLF},
            {"KZTLF",x=>x.KZTLF},
            {"KZAZU",x=>x.KZAZU},
            {"LPRIO",x=>x.LPRIO},
            {"VSBED",x=>x.VSBED},
            {"WAERS",x=>x.WAERS},
            {"KTGRD",x=>x.KTGRD},
            {"ZTERM",x=>x.ZTERM},
            {"VKGRP",x=>x.VKGRP},
            {"VKBUR",x=>x.VKBUR},
            {"KVGR1",x=>x.KVGR1},
            {"KVGR2",x=>x.KVGR2},
            {"KVGR3",x=>x.KVGR3},
            {"KVGR4",x=>x.KVGR4},
            {"KVGR5",x=>x.KVGR5},
            {"KURST",x=>x.KURST},
            {"KKBER",x=>x.KKBER },
            {"CASSD",x=>x.CASSD }
            })
        {

        }
    }
}
