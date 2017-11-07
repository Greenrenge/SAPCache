using MaleeUtilities.SAP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAPCache.Models
{
    public abstract class CacheTable
    {
        public string _tableName;
        public CacheTable(string tablename)
        {
            _tableName = tablename;
        }

        public abstract bool SyncStart();
    }

    public class SyncManager<T> : CacheTable where T : class, new()
    {
        private IDictionary<string, Expression<Func<T, object>>> _objectFieldSet;
        private List<string> _options;
        public SyncManager(List<string> options, string tablename, IDictionary<string, Expression<Func<T, object>>> objectFieldSet) : base(tablename)
        {
            _objectFieldSet = objectFieldSet;
            _options = options;
        }

        public override bool SyncStart()
        {
            try
            {
                var obj = SAPBaseService.GetSAPData(_tableName, _objectFieldSet, _options);

                using (var db = new IntramartDbContext())
                {
                    if (obj.Count > 0)
                    {
                        var dbset = db.Set<T>();
                        var exsitingInDb = dbset.ToList();
                        dbset.RemoveRange(exsitingInDb);
                        dbset.AddRange(obj);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(ex);
                return false;
            }
           
        }

    }
}
