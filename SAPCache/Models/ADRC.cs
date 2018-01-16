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
    [Table("ADRC")]
    public class ADRC
    {
        [Key]
        [Column(Order =1)]
        public string ADDRNUMBER { get; set; }//Address No
        [Key]
        [Column(Order = 2)]
        public string NATION { get; set; }//Version (I = international)
        public string NAME1 { get; set; }//Name 1
        public string NAME2 { get; set; }//Name 2
        public string NAME3 { get; set; }//Name 3
        public string NAME4 { get; set; }//Name 4
        public string STR_SUPPL1 { get; set; }//Street2
        public string STR_SUPPL2 { get; set; }//Street3
        public string STR_SUPPL3 { get; set; }//Street4
        public string LOCATION { get; set; }//Street5
        public string COUNTRY { get; set; }//Country
        public string REGION { get; set; }//region  
        public string SORT1 { get; set; }//Search Term1
        public string SORT2 { get; set; }//Search Term2
        public string TEL_NUMBER { get; set; }//Tel no
        public string TEL_EXTENS { get; set; }//Tel ext
        public string FAX_NUMBER { get; set; }//Fax No
        public string FAX_EXTENS { get; set; }//Fax ext
        public string CITY2 { get; set; }//District
        public string POST_CODE1 { get; set; }//Postal Code
        public string CITY1 { get; set; }//City
        public string TRANSPZONE { get; set; }//TransportZone

    }
    public class ADRCManager : SyncManagerMultiple<ADRC>
    {
        public ADRCManager(List<string> option) : base(option, "ADRC",
            new List<Func<ADRC, string>>
            {
                //PK
                {x=>x.ADDRNUMBER },
                {x=>x.NATION }
            },
            new Tuple<IDictionary<string, Expression<Func<ADRC, object>>>, Action<ADRC, ADRC>>(
                        new Dictionary<string, Expression<Func<ADRC, object>>>
                        {
                        {"ADDRNUMBER",x=>x.ADDRNUMBER},
                        {"NATION",x=>x.NATION},
                        {"NAME1",x=>x.NAME1},
                        {"NAME2",x=>x.NAME2},
                        {"NAME3",x=>x.NAME3},
                        {"NAME4",x=>x.NAME4},
                        //{"STR_SUPPL1",x=>x.STR_SUPPL1},//Data buffer exceeded
                        //{"STR_SUPPL2",x=>x.STR_SUPPL2},
                        //{"STR_SUPPL3",x=>x.STR_SUPPL3},
                        {"LOCATION",x=>x.LOCATION},
                        {"COUNTRY",x=>x.COUNTRY},
                        {"REGION",x=>x.REGION},
                        {"SORT1",x=>x.SORT1},
                        {"SORT2",x=>x.SORT2},
                        {"TEL_NUMBER",x=>x.TEL_NUMBER},
                        {"TEL_EXTENS",x=>x.TEL_EXTENS},
                        {"FAX_NUMBER",x=>x.FAX_NUMBER},
                        {"FAX_EXTENS",x=>x.FAX_EXTENS},
                        {"CITY2",x=>x.CITY2},
                        {"POST_CODE1",x=>x.POST_CODE1},
                        {"CITY1",x=>x.CITY1},
                        {"TRANSPZONE",x=>x.TRANSPZONE},
                        }
                    , null)

            ,
             new Tuple<IDictionary<string, Expression<Func<ADRC, object>>>, Action<ADRC, ADRC>>
            (
                        new Dictionary<string, Expression<Func<ADRC, object>>>
                        {
                             {"ADDRNUMBER",x=>x.ADDRNUMBER},
                             {"NATION",x=>x.NATION},
                             {"STR_SUPPL1",x=>x.STR_SUPPL1},//Data buffer exceeded
                             //{"STR_SUPPL2",x=>x.STR_SUPPL2},
                             //{"STR_SUPPL3",x=>x.STR_SUPPL3},
                        }
                    ,
                       (db,sap) =>
                       {
                           db.STR_SUPPL1 = sap.STR_SUPPL1;
                       }
            )
            ,
             new Tuple<IDictionary<string, Expression<Func<ADRC, object>>>, Action<ADRC, ADRC>>
            (
                        new Dictionary<string, Expression<Func<ADRC, object>>>
                        {
                             {"ADDRNUMBER",x=>x.ADDRNUMBER},
                             {"NATION",x=>x.NATION},
                             {"STR_SUPPL2",x=>x.STR_SUPPL2},
                             {"STR_SUPPL3",x=>x.STR_SUPPL3},
                        }
                    ,
                       (db, sap) =>
                       {
                           db.STR_SUPPL2 = sap.STR_SUPPL2;
                           db.STR_SUPPL3 = sap.STR_SUPPL3;
                       }
            )


            )
        {

        }
    }
}
