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
            tableDict.Add("SKA1", typeof(SKA1Manager));
            tableDict.Add("SKAT", typeof(SKATManager));
            tableDict.Add("MVKE", typeof(MVKEManager));
            tableDict.Add("T179", typeof(T179Manager));
            tableDict.Add("T179T", typeof(T179TManager));
            tableDict.Add("TVM1T", typeof(TVM1TManager));
            tableDict.Add("TVM2T", typeof(TVM2TManager));
            tableDict.Add("TVM3T", typeof(TVM3TManager));
            tableDict.Add("TVM4T", typeof(TVM4TManager));
            tableDict.Add("T134T", typeof(T134TManager));
            tableDict.Add("T006A", typeof(T006AManager));
            tableDict.Add("T001K", typeof(T001KManager));
            tableDict.Add("T190ST", typeof(T190STManager));
            tableDict.Add("TWSPR", typeof(TWSPRManager));
            tableDict.Add("T023T", typeof(T023TManager));
            tableDict.Add("TSPAT", typeof(TSPATManager));
            tableDict.Add("TVSMT", typeof(TVSMTManager));
            tableDict.Add("TVKMT", typeof(TVKMTManager));
            tableDict.Add("TMVFT", typeof(TMVFTManager));
            tableDict.Add("TTGRT", typeof(TTGRTManager));
            tableDict.Add("TLGRT", typeof(TLGRTManager));
            tableDict.Add("T024", typeof(T024Manager));
            tableDict.Add("T438X", typeof(T438XManager));
            tableDict.Add("T438T", typeof(T438TManager));
            tableDict.Add("T439T", typeof(T439TManager));
            tableDict.Add("T024D", typeof(T024DManager));
            tableDict.Add("T001L", typeof(T001LManager));
            tableDict.Add("TQ30T", typeof(TQ30TManager));
            tableDict.Add("TQ08T", typeof(TQ08TManager));
            tableDict.Add("TQ05T", typeof(TQ05TManager));
            tableDict.Add("T025", typeof(T025Manager));
            tableDict.Add("T025T", typeof(T025TManager));
            tableDict.Add("TCK14", typeof(TCK14Manager));
            tableDict.Add("TCK15", typeof(TCK15Manager));
            tableDict.Add("CEPCT", typeof(CEPCTManager));
            tableDict.Add("MBEW", typeof(MBEWManager));
            tableDict.Add("T077X", typeof(T077XManager));
            tableDict.Add("T151T", typeof(T151TManager));
            tableDict.Add("TZONT", typeof(TZONTManager));
            tableDict.Add("T005U", typeof(T005UManager));
            tableDict.Add("T052U", typeof(T052UManager));
            tableDict.Add("PA0001", typeof(PA0001Manager));
            tableDict.Add("T005T", typeof(T005TManager));
            tableDict.Add("T014T", typeof(T014TManager));
            tableDict.Add("ADRC", typeof(ADRCManager));
            #endregion

            log.Debug("-----------------------------------------------------------------------------------------");
            log.Debug("Sync Begin");
            log.Debug("-----------------------------------------------------------------------------------------");
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
                        Console.WriteLine("Table [" + instance._tableName + "] has been synced.");
                        log.Debug("Table ["+ instance._tableName+ "] has been synced.");
                    }
                    else
                    {
                        Console.WriteLine("Table [" + instance._tableName + "] ERROR occured.");
                        log.Error("Table [" + instance._tableName + "] ERROR occured.");
                    }
                }
            }
            #endregion
            log.Debug("-----------------------------------------------------------------------------------------");
            log.Debug("Sync End");
            log.Debug("-----------------------------------------------------------------------------------------");
            log.Debug(Environment.NewLine);
        }
    }
}
