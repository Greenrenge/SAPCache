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
    [Table("MARA")]
    public class MARA
    {
        [Key]
        public string MATNR { get; set; }//MaterialCode
        public string VPSTA { get; set; }//Compl.maint.status
        public string PSTAT { get; set; }//MaintenanceStatus
        public string MTART { get; set; }//MaterialType
        public string MBRSH { get; set; }//IndustrySector
        public string MATKL { get; set; }//MaterialGroup
        public string BISMT { get; set; }//OldMaterialNo
        public string MEINS { get; set; }//Base Unit of Measurement
        public string GROES { get; set; }//Size/Dimensions
        public string BRGEW { get; set; }//Gross Weight
        public string NTGEW { get; set; }//Net Wieght
        public string GEWEI { get; set; }//Weight Unit
        public string VOLUM { get; set; }//Volumn
        public string VOLEH { get; set; }//VolumnUnit
        public string DISST { get; set; }//Low-level code
        public string TRAGR { get; set; }//Transportation Group
        public string SPART { get; set; }//Division
        public string EAN11 { get; set; }//EAN/UPC
        public string NUMTP { get; set; }//EAN Category
        public string PRDHA { get; set; }//Product Hierarchy
        public string EXTWG { get; set; }//External Mat Group

    }
    public class MARAManager : SyncManager<MARA>
    {
        public MARAManager(List<string> option) : base(option, "MARA", new Dictionary<string, Expression<Func<MARA, object>>>
            {
            {"MATNR",x=>x.MATNR},
            {"VPSTA",x=>x.VPSTA},
            {"PSTAT",x=>x.PSTAT},
            {"MTART",x=>x.MTART},
            {"MBRSH",x=>x.MBRSH},
            {"MATKL",x=>x.MATKL},
            {"BISMT",x=>x.BISMT},
            {"MEINS",x=>x.MEINS},
            {"GROES",x=>x.GROES},
            {"BRGEW",x=>x.BRGEW},
            {"NTGEW",x=>x.NTGEW},
            {"GEWEI",x=>x.GEWEI},
            {"VOLUM",x=>x.VOLUM},
            {"VOLEH",x=>x.VOLEH},
            {"DISST",x=>x.DISST},
            {"TRAGR",x=>x.TRAGR},
            {"SPART",x=>x.SPART},
            {"EAN11",x=>x.EAN11},
            {"NUMTP",x=>x.NUMTP},
            {"PRDHA",x=>x.PRDHA},
            {"EXTWG",x=>x.EXTWG}
            })
        {

        }
    }
}
