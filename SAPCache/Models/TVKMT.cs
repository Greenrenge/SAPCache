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
    [Table("TVKMT")]
    public class TVKMT
    {
        [Key]
        public string KTGRM { get; set; }//Acct asgnmt grp
        public string VTEXT { get; set; }//Description


    }
    public class TVKMTManager : SyncManager<TVKMT>
    {
        public TVKMTManager(List<string> option) : base(option, "TVKMT", new Dictionary<string, Expression<Func<TVKMT, object>>>
            {
            {"KTGRM",x=>x.KTGRM},
            {"VTEXT",x=>x.VTEXT},
            })
        {

        }
    }
}
