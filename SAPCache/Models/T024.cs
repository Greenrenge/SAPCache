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
    [Table("T024")]
    public class T024
    {
        [Key]
        public string EKGRP { get; set; }//Purch.Group
        public string EKNAM { get; set; }//Description
        public string SMTP_ADDR {get; set; }//E-Mail Address


    }
    public class T024Manager : SyncManager<T024>
    {
        public T024Manager(List<string> option) : base(option, "T024", new Dictionary<string, Expression<Func<T024, object>>>
            {
            {"EKGRP",x=>x.EKGRP },
            {"EKNAM",x=>x.EKNAM },
            {"SMTP_ADDR"  ,x=>x.SMTP_ADDR }
            })
        {

        }
    }
}
