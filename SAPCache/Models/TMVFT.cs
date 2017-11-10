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
    [Table("TMVFT")]
    public class TMVFT
    {
        [Key]
        public string MTVFP { get; set; }//Avail. check
        public string BEZEI { get; set; }//Description


    }
    public class TMVFTManager : SyncManager<TMVFT>
    {
        public TMVFTManager(List<string> option) : base(option, "TMVFT", new Dictionary<string, Expression<Func<TMVFT, object>>>
            {
            {"MTVFP",x=>x.MTVFP},
            {"BEZEI",x=>x.BEZEI},
            })
        {

        }
    }
}
