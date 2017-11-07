using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaleeUtilities.Extensions;
using MaleeUtilities.SAP.Services;
using MaleeUtilities.SAP.Utils;
using SAPCache.Models;
using System.Linq.Expressions;
using log4net;
namespace SAPCache
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger("Main");
        static void Main(string[] args)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Appconfig.Initialize(path, ConfigurationManager.AppSettings, null);

            #region Logger
            log4net.GlobalContext.Properties["LOG4NET_ERROR"] = Appconfig.LOG4NET_ERROR; //log file path
            log4net.GlobalContext.Properties["LOG4NET_DEBUG"] = Appconfig.LOG4NET_DEBUG; //log file path
            log4net.Config.XmlConfigurator.Configure();
            #endregion

            #region Cache Appconfig to memory
            List<string> tableoptions = Appconfig.TableOptions;
            Dictionary<string, string> TableOptionPair = new Dictionary<string, string>();
            tableoptions.ForEach(x =>
                {
                    string tablename = x.SubstringUntil("[");
                    string tableOption = x.SubstringBetween('[', ']');
                    TableOptionPair.Add(tablename, tableOption);
                });
            #endregion

            #region setting sap
            DestinationRegister.RegistrationDestination(new SAPDestinationSetting { AppServerHost = Appconfig.SAPServerHost, Client = Appconfig.SAPClient, SystemNumber = Appconfig.SAPSystemNumber, SystemID = Appconfig.SAPSystemID, User = Appconfig.SAPUser, Password = Appconfig.SAPPassword });
            #endregion


            /***
             * Step to cache new table
             * 1.defined model/model manager  and add to intramartdbcontext
             * 2.put option/table to app config
             * 3.register table in program class
             * */
            #region RegisteringTable and Type
            Dictionary<string, Type> tableDict = new Dictionary<string, Type>();
            tableDict.Add("KNA1",typeof(KNA1Manger));
            tableDict.Add("COAS", typeof(COASManager));
            tableDict.Add("V_AUART", typeof(V_AUARTManager));
            tableDict.Add("LFA1", typeof(LFA1Manager));
            tableDict.Add("KNVV", typeof(KNVVManager));
            tableDict.Add("TVV1T", typeof(TVV1TManager));
            tableDict.Add("TVV2T", typeof(TVV2TManager));
            tableDict.Add("TVV3T", typeof(TVV3TManager));
            tableDict.Add("TVKOV", typeof(TVKOVManager));
            tableDict.Add("TVKBZ", typeof(TVKBZManager));
            tableDict.Add("TVTWT", typeof(TVTWTManager));
            tableDict.Add("TVKBT", typeof(TVKBTManager));
            tableDict.Add("TVBVK", typeof(TVBVKManager));
            tableDict.Add("TVGRT", typeof(TVGRTManager));
            tableDict.Add("T171T", typeof(T171TManager));
            tableDict.Add("TVKOT", typeof(TVKOTManager));
            tableDict.Add("MARA", typeof(MARAManager));
            tableDict.Add("MAKT", typeof(MAKTManager));
            
            #endregion


            log.Debug("Sync Begins");

            #region startSync
            foreach (var tablename in Appconfig.TableToSync)
            {
                var option = new List<string>();
                if(TableOptionPair.ContainsKey(tablename)) option.Add(TableOptionPair[tablename]);
                if(tableDict.ContainsKey(tablename))
                {
                    var targetClass = tableDict[tablename];
                    CacheTable instance = (CacheTable)Activator.CreateInstance(targetClass,option);
                    var syncComplete = instance.SyncStart();
                    if(syncComplete)
                    {
                        log.Debug("Table ["+ instance._tableName+ "] has been synced.");
                    }
                    else
                    {
                        log.Error("Table [" + instance._tableName + "] ERROR occured.");
                    }
                }
            }
            #endregion

        }
    }
}
