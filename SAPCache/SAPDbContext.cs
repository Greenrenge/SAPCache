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
        public virtual DbSet<T134T> T134T { get; set; }
        public virtual DbSet<T006A> T006A { get; set; }
        public virtual DbSet<T001K> T001K { get; set; }
        public virtual DbSet<T190ST> T190ST { get; set; }
        public virtual DbSet<TWSPR> TWSPR { get; set; }
        public virtual DbSet<T023T> T023T { get; set; }
        public virtual DbSet<TSPAT> TSPAT { get; set; }
        public virtual DbSet<TVSMT> TVSMT { get; set; }
        public virtual DbSet<TVKMT> TVKMT { get; set; }
        public virtual DbSet<TMVFT> TMVFT { get; set; }
        public virtual DbSet<TTGRT> TTGRT { get; set; }
        public virtual DbSet<TLGRT> TLGRT { get; set; }
        public virtual DbSet<T024> T024 { get; set; }
        public virtual DbSet<T438X> T438X { get; set; }
        public virtual DbSet<T438T> T438T { get; set; }
        public virtual DbSet<T439T> T439T { get; set; }
        public virtual DbSet<T024D> T024D { get; set; }
        public virtual DbSet<T001L> T001L { get; set; }
        public virtual DbSet<TQ30T> TQ30T { get; set; }
        public virtual DbSet<TQ08T> TQ08T { get; set; }
        public virtual DbSet<TQ05T> TQ05T { get; set; }
        public virtual DbSet<T025> T025 { get; set; }
        public virtual DbSet<T025T> T025T { get; set; }
        public virtual DbSet<TCK14> TCK14 { get; set; }
        public virtual DbSet<TCK15> TCK15 { get; set; }
        public virtual DbSet<CEPCT> CEPCT { get; set; }
        public virtual DbSet<MBEW> MBEW { get; set; }
        public virtual DbSet<T077X> T077X { get; set; }
        public virtual DbSet<T151T> T151T { get; set; }
        public virtual DbSet<TZONT> TZONT { get; set; }
        public virtual DbSet<T005U> T005U { get; set; }
        public virtual DbSet<T052U> T052U { get; set; }
        public virtual DbSet<PA0001> PA0001 { get; set; }
        public virtual DbSet<T005T> T005T { get; set; }
        public virtual DbSet<T014T> T014T { get; set; }
        public virtual DbSet<ADRC> ADRC { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}