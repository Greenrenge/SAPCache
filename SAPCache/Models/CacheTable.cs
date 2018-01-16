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
        protected IDictionary<string, Expression<Func<T, object>>> _objectFieldSet;
        protected List<string> _options;
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

                using (var db = new SAPDbContext())
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

    public class SyncManagerMultiple<T> : CacheTable where T : class, new()
    {
        protected Tuple<IDictionary<string, Expression<Func<T, object>>>, Action<T, T>>[] _objectFieldSet;
        protected List<string> _options;
        protected IEnumerable<Func<T, string>> _primaryKeys;
        public SyncManagerMultiple(List<string> options, string tablename, IEnumerable<Func<T, string>> primaryKeys, params Tuple<IDictionary<string, Expression<Func<T, object>>>, Action<T, T>>[] originalAndUpdateData) : base(tablename)
        {
            _objectFieldSet = originalAndUpdateData;
            _options = options;
            _primaryKeys = primaryKeys;
        }

        public override bool SyncStart()
        {
            try
            {
                List<List<T>> tableSet = new List<List<T>>(_objectFieldSet.Count());
                foreach (var fieldset in _objectFieldSet) tableSet.Add(new List<T>());


                int index = 0;
                foreach (var fieldset in _objectFieldSet)
                {
                    var obj = SAPBaseService.GetSAPData(_tableName, fieldset.Item1, _options);
                    var tmp = obj.ToList();
                    foreach( var orderby in _primaryKeys)
                    {
                        tmp = tmp.OrderBy(orderby).ToList();
                    }
                    tableSet[index] = tmp;
                    index++;
                }

                //update
                int count = tableSet.First().Count;
                if(tableSet.TrueForAll(x=>x.Count == count))
                {
                    //exactly equal
                    int originalIndex = _objectFieldSet.Select((value, i) => new { value, index = i + 1 })
                                                        .Where(pair => pair.value.Item2 == null)
                                                        .Select(pair => pair.index)
                                                        .FirstOrDefault() - 1;
                    for (int i = 0; i < count; i++)
                    {
                        var origin = tableSet[originalIndex][i];
                        for (int j = 0; j < _objectFieldSet.Count(); j++)
                        {
                            if (j == originalIndex) continue;
                            var updateFunc =  _objectFieldSet[j].Item2;//origin,update
                            updateFunc(origin, tableSet[j][i]);
                        }
                    }

                    //database
                    using (var db = new SAPDbContext())
                    {
                        var obj = tableSet[originalIndex];
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
                else
                {
                    return false;
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
