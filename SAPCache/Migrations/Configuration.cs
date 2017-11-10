namespace SAPCache.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SAPCache.SAPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SAPCache.SAPDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Database.ExecuteSqlCommand(@"
                                      										
                                        IF OBJECT_ID('dbo.VIEW_KNVV_TEXT') IS NULL
                                        BEGIN
                                            EXECUTE('CREATE VIEW dbo.VIEW_KNVV_TEXT
                                            AS
                                                Select 
                                                	 knvv.KUNNR as KUNNR_CustomerNo
                                                	,knvv.VKORG as VKORG_SaleOrg
                                                	,knvv.VTWEG as VTWEG_Channel
                                                	,knvv.SPART as SPART_Division
                                                	,knvv.KDGRP as KDGRP_CustomerGroup
                                                	,knvv.BZIRK as BZIRK_SaleDistrict
                                                	,knvv.VKGRP as VKGRP_SaleGroup
                                                	,knvv.VKBUR as VKBUR_SaleOffice
                                                	,knvv.KVGR1 as KVGR1_CustomerGroup1
                                                	,knvv.KVGR2 as KVGR2_CustomerGroup2
                                                	,knvv.KVGR3 as KVGR3_CustomerGroup3
                                                	
                                                	
                                                	,kna1.NAME1+kna1.NAME2 as CustomerName
                                                	,tvv1t.BEZEI as CustomerGroup1
                                                	,tvv2t.BEZEI  as CustomerGroup2
                                                	,tvv3t.BEZEI  as CustomerGroup3
                                                	,tvtwt.VTEXT as Channel
                                                	,tvgrt.BEZEI as SaleGroup
                                                	,tvkbt.BEZEI as SaleOffice
                                                	,t171t.BZTXT as SaleDistrict
                                                from KNA1 kna1 
                                                inner join KNVV knvv on knvv.KUNNR = kna1.KUNNR 
                                                left join TVV1T tvv1t on tvv1t.KVGR1 = knvv.KVGR1 --customer group1 / join ไม่ครบ
                                                left join TVV2T tvv2t on tvv2t.KVGR2 = knvv.KVGR2 --customer group2
                                                left join TVV3T tvv3t on tvv3t.KVGR3 = knvv.KVGR3 --customer group3
                                                left join TVTWT tvtwt on tvtwt.VTWEG = knvv.VTWEG --sale channel
                                                left join TVKBT tvkbt on tvkbt.VKBUR = knvv.VKBUR --sale office
                                                left join TVGRT tvgrt on tvgrt.VKGRP = knvv.VKGRP --sale group
                                                left join T171T t171t on t171t.BZIRK = knvv.BZIRK --sale district / join ไม่ครบ
                                                left join TVKOT tvkot on tvkot.VKORG = knvv.VKORG --saleorg
                                                left join TSPAT tspat on tspat.SPART = knvv.SPART --division')
                                        
                                        
                                        
                                        
                                        END
                                        ELSE
                                        BEGIN
                                            EXECUTE('ALTER VIEW dbo.VIEW_KNVV_TEXT
                                            AS
                                                Select 
                                                	 knvv.KUNNR as KUNNR_CustomerNo
                                                	,knvv.VKORG as VKORG_SaleOrg
                                                	,knvv.VTWEG as VTWEG_Channel
                                                	,knvv.SPART as SPART_Division
                                                	,knvv.KDGRP as KDGRP_CustomerGroup
                                                	,knvv.BZIRK as BZIRK_SaleDistrict
                                                	,knvv.VKGRP as VKGRP_SaleGroup
                                                	,knvv.VKBUR as VKBUR_SaleOffice
                                                	,knvv.KVGR1 as KVGR1_CustomerGroup1
                                                	,knvv.KVGR2 as KVGR2_CustomerGroup2
                                                	,knvv.KVGR3 as KVGR3_CustomerGroup3
                                                	
                                                	
                                                	,kna1.NAME1+kna1.NAME2 as CustomerName
                                                	,tvv1t.BEZEI as CustomerGroup1
                                                	,tvv2t.BEZEI  as CustomerGroup2
                                                	,tvv3t.BEZEI  as CustomerGroup3
                                                	,tvtwt.VTEXT as Channel
                                                	,tvgrt.BEZEI as SaleGroup
                                                	,tvkbt.BEZEI as SaleOffice
                                                	,t171t.BZTXT as SaleDistrict
                                                from KNA1 kna1 
                                                inner join KNVV knvv on knvv.KUNNR = kna1.KUNNR 
                                                left join TVV1T tvv1t on tvv1t.KVGR1 = knvv.KVGR1 --customer group1 / join ไม่ครบ
                                                left join TVV2T tvv2t on tvv2t.KVGR2 = knvv.KVGR2 --customer group2
                                                left join TVV3T tvv3t on tvv3t.KVGR3 = knvv.KVGR3 --customer group3
                                                left join TVTWT tvtwt on tvtwt.VTWEG = knvv.VTWEG --sale channel
                                                left join TVKBT tvkbt on tvkbt.VKBUR = knvv.VKBUR --sale office
                                                left join TVGRT tvgrt on tvgrt.VKGRP = knvv.VKGRP --sale group
                                                left join T171T t171t on t171t.BZIRK = knvv.BZIRK --sale district / join ไม่ครบ
                                                left join TVKOT tvkot on tvkot.VKORG = knvv.VKORG --saleorg
                                                left join TSPAT tspat on tspat.SPART = knvv.SPART --division')
                                        
                                        
                                        
                                       
                                        END
");
        }
    }
}
