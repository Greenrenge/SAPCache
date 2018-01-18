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


            //this is a view for easily select customer detail
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

            context.Database.ExecuteSqlCommand(@"
            IF OBJECT_ID('dbo.VIEW_KNVV_TEXT') IS NULL
                                        BEGIN
                                            EXECUTE('CREATE VIEW dbo.VIEW_CUSTOMER_DETAIL_MASTER
                                            AS
                                                select 	
	dbo.unwrapzero(kna1.KUNNR) as customercode
	,adrc.[NAME1] as name1
	,adrc.[NAME2] as name2
	,adrc.[NAME4] as branch_name
	,adrc.[SORT1] as search_term1
	,adrc.[SORT2] as search_term2
	,adrc.[STR_SUPPL1] as street2
	,adrc.[STR_SUPPL2] as street3
	,adrc.[STR_SUPPL3] as street4
	,adrc.[LOCATION] as street5
	,adrc.[CITY1] as city
	,adrc.[CITY2] as district
	,adrc.[REGION] as region
	,adrc.[COUNTRY] as country
	,adrc.[POST_CODE1] as postal_code
	,adrc.[TRANSPZONE] as transport_zone1
	,adrc.[TEL_NUMBER] as tel_no
	,adrc.[TEL_EXTENS] as tel_ext
	,adrc.[FAX_NUMBER] as fax_no
	,adrc.[FAX_EXTENS] as fax_ext
	,adr2.TEL_NUMBER as mobile_no
	,adr6.SMTP_ADDR as email
	,kna1.KTOKD as account_group
	,kna1.STCD1 as tax_number1
	,kna1.STCD3 as tax_number3
	,kna1.STCEG as vat_register_number
	,kna1.LZONE as transport_zone2
	,kna1.VBUND as trading_partner
	,kna1.AUFSD as kna1_order_block
	,kna1.FAKSD as kna1_bill_block
	,kna1.LIFSD as kna1_delivery_block
	,kna1.CASSD as kna1_sales_block
	
from dbo.KNA1 kna1	
left join dbo.ADRC adrc on kna1.ADRNR = adrc.[ADDRNUMBER] and adrc.NATION <> ''I''
left join dbo.ADR6 adr6 on kna1.ADRNR = adr6.[ADDRNUMBER] and LEN(adr6.PERSNUMBER)=0 and adr6.FLGDEFAULT = ''X''
left join dbo.ADR2 adr2 on kna1.ADRNR = adr2.[ADDRNUMBER] and LEN(adr2.PERSNUMBER)=0 and adr2.FLGDEFAULT = ''X''

                                        
                                        
                                        
                                        
                                        END
                                        ELSE
                                        BEGIN
                                            EXECUTE(''ALTER VIEW dbo.VIEW_KNVV_TEXT
                                            AS
                                                select 	
	dbo.unwrapzero(kna1.KUNNR) as customercode
	,adrc.[NAME1] as name1
	,adrc.[NAME2] as name2
	,adrc.[NAME4] as branch_name
	,adrc.[SORT1] as search_term1
	,adrc.[SORT2] as search_term2
	,adrc.[STR_SUPPL1] as street2
	,adrc.[STR_SUPPL2] as street3
	,adrc.[STR_SUPPL3] as street4
	,adrc.[LOCATION] as street5
	,adrc.[CITY1] as city
	,adrc.[CITY2] as district
	,adrc.[REGION] as region
	,adrc.[COUNTRY] as country
	,adrc.[POST_CODE1] as postal_code
	,adrc.[TRANSPZONE] as transport_zone1
	,adrc.[TEL_NUMBER] as tel_no
	,adrc.[TEL_EXTENS] as tel_ext
	,adrc.[FAX_NUMBER] as fax_no
	,adrc.[FAX_EXTENS] as fax_ext
	,adr2.TEL_NUMBER as mobile_no
	,adr6.SMTP_ADDR as email
	,kna1.KTOKD as account_group
	,kna1.STCD1 as tax_number1
	,kna1.STCD3 as tax_number3
	,kna1.STCEG as vat_register_number
	,kna1.LZONE as transport_zone2
	,kna1.VBUND as trading_partner
	,kna1.AUFSD as kna1_order_block
	,kna1.FAKSD as kna1_bill_block
	,kna1.LIFSD as kna1_delivery_block
	,kna1.CASSD as kna1_sales_block
	
from dbo.KNA1 kna1	
left join dbo.ADRC adrc on kna1.ADRNR = adrc.[ADDRNUMBER] and adrc.NATION <> ''I''
left join dbo.ADR6 adr6 on kna1.ADRNR = adr6.[ADDRNUMBER] and LEN(adr6.PERSNUMBER)=0 and adr6.FLGDEFAULT = ''X''
left join dbo.ADR2 adr2 on kna1.ADRNR = adr2.[ADDRNUMBER] and LEN(adr2.PERSNUMBER)=0 and adr2.FLGDEFAULT = ''X''
')
                                        
                                        
                                        
                                       
                                        END");

            //this is for cutting zero out of the the begining of the string 
            context.Database.ExecuteSqlCommand(@"
                IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE type = 'FN' AND name = 'unwrapzero')
                BEGIN
                    DECLARE @sql NVARCHAR(MAX);
                    SET @sql = N'
                    create function unwrapzero(@sapcode as varchar(500))
                	returns varchar(500)
                	begin
                		return substring(@sapcode ,patindex(''%[^0]%'',@sapcode ),LEN(@sapcode ))
                	end;
                    ';
                    EXEC sp_executesql @sql;
                END
                ");
            //grant execute permission to maleereader
            context.Database.ExecuteSqlCommand(@"GRANT execute on unwrapzero TO MaleeReader;");
        }
    }
}
