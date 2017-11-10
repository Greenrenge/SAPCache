using MaleeUtilities.SAP.Services;
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
    [Table("T006A")]
    public class T006A
    {
        [Key]
        public string MSEHI { get; set; }//Int.meas.unit
        public string MSEH3 { get; set; }//Commercial
        public string MSEH6 { get; set; }//Technical
        public string MSEHT { get; set; }//Meas.unit text
        public string MSEHL { get; set; }//Unit text
    }
    public class T006AManager : SyncManager<T006A>
    {
        public T006AManager(List<string> option) : base(option, "T006A", new Dictionary<string, Expression<Func<T006A, object>>>
            {
            {"MSEHI",x=>x.MSEHI},
            {"MSEH3",x=>x.MSEH3},
            {"MSEH6",x=>x.MSEH6},
            {"MSEHT",x=>x.MSEHT},
            {"MSEHL",x=>x.MSEHL},
            })
        {

        }
    }
    
}
