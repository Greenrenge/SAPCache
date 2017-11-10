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
    [Table("TSPAT")]
    public class TSPAT
    {
        [Key]
        public string SPART { get; set; }//Division
        public string VTEXT { get; set; }//Name


    }
    public class TSPATManager : SyncManager<TSPAT>
    {
        public TSPATManager(List<string> option) : base(option, "TSPAT", new Dictionary<string, Expression<Func<TSPAT, object>>>
            {
            {"SPART",x=>x.SPART},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
