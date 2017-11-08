namespace SAPCache
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SAPDbContext : DbContext
    {
        // Your context has been configured to use a 'Intramart' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SAPCache.Intramart' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Intramart' 
        // connection string in the application configuration file.
        public SAPDbContext()
            : base("name=SAP")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<SAPDbContext, SAPCache.Migrations.Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<KNA1> KNA1 { get; set; }
        public virtual DbSet<COAS> COAS { get; set; }
        public virtual DbSet<V_AUART> V_AUART { get; set; }
        public virtual DbSet<LFA1> LFA1 { get; set; }
        public virtual DbSet<KNVV> KNVV { get; set; }
        public virtual DbSet<TVV1T> TVV1T { get; set; }
        public virtual DbSet<TVV2T> TVV2T { get; set; }
        public virtual DbSet<TVV3T> TVV3T { get; set; }
        public virtual DbSet<TVKOV> TVKOV { get; set; }
        public virtual DbSet<TVKBZ> TVKBZ { get; set; }
        public virtual DbSet<TVTWT> TVTWT { get; set; }
        public virtual DbSet<TVKBT> TVKBT { get; set; }
        public virtual DbSet<TVBVK> TVBVK { get; set; }
        public virtual DbSet<TVGRT> TVGRT { get; set; }
        public virtual DbSet<T171T> T171T { get; set; }
        public virtual DbSet<TVKOT> TVKOT { get; set; }
        public virtual DbSet<MARA> MARA { get; set; }
        public virtual DbSet<MAKT> MAKT { get; set; }
        public virtual DbSet<SKA1> SKA1 { get; set; }
        public virtual DbSet<SKAT> SKAT { get; set; }
        public virtual DbSet<MVKE> MVKE { get; set; }
        public virtual DbSet<T179> T179 { get; set; }
        public virtual DbSet<T179T> T179T { get; set; }
        public virtual DbSet<TVM1T> TVM1T { get; set; }
        public virtual DbSet<TVM2T> TVM2T { get; set; }
        public virtual DbSet<TVM3T> TVM3T { get; set; }
        public virtual DbSet<TVM4T> TVM4T { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}