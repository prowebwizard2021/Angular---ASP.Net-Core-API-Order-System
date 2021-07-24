using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.ModelsDB
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalOrderInformation> AdditionalOrderInformations { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentsContactPerson> AgentsContactPersons { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentsContainer> AppointmentsContainers { get; set; }
        public virtual DbSet<AppointmentsFactory> AppointmentsFactories { get; set; }
        public virtual DbSet<AppointmentsOrder> AppointmentsOrders { get; set; }
        public virtual DbSet<ArticleVariation> ArticleVariations { get; set; }
        public virtual DbSet<AuditingCompany> AuditingCompanies { get; set; }
        public virtual DbSet<BuyingAgent> BuyingAgents { get; set; }
        public virtual DbSet<CapacityGroup> CapacityGroups { get; set; }
        public virtual DbSet<CertificationBody> CertificationBodies { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ConfigActualSeason> ConfigActualSeasons { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<ContainerContent> ContainerContents { get; set; }
        public virtual DbSet<CountryShortcut> CountryShortcuts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Dbo> Dbos { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentWeb> DepartmentWebs { get; set; }
        public virtual DbSet<Dmlog> Dmlogs { get; set; }
        public virtual DbSet<Dprqb> Dprqbs { get; set; }
        public virtual DbSet<Dprsync> Dprsyncs { get; set; }
        public virtual DbSet<EndCustomer> EndCustomers { get; set; }
        public virtual DbSet<EnquiriesMaterial> EnquiriesMaterials { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }
        public virtual DbSet<EnquiryItem> EnquiryItems { get; set; }
        public virtual DbSet<EnquiryItemsMaterial> EnquiryItemsMaterials { get; set; }
        public virtual DbSet<EnquiryTask> EnquiryTasks { get; set; }
        public virtual DbSet<EnquiryTaskTemplate> EnquiryTaskTemplates { get; set; }
        public virtual DbSet<EnquiryTaskType> EnquiryTaskTypes { get; set; }
        public virtual DbSet<ExchangeAcceptance> ExchangeAcceptances { get; set; }
        public virtual DbSet<FactoriesContactPerson> FactoriesContactPersons { get; set; }
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<FactoryCollaboration> FactoryCollaborations { get; set; }
        public virtual DbSet<FactoryConnection> FactoryConnections { get; set; }
        public virtual DbSet<FactoryFeature> FactoryFeatures { get; set; }
        public virtual DbSet<FactoryVisitPurpose> FactoryVisitPurposes { get; set; }
        public virtual DbSet<ForwardExchangeDealing> ForwardExchangeDealings { get; set; }
        public virtual DbSet<GpRepresentativeMapping> GpRepresentativeMappings { get; set; }
        public virtual DbSet<IncomingTermsOfDelivery> IncomingTermsOfDeliveries { get; set; }
        public virtual DbSet<Initial> Initials { get; set; }
        public virtual DbSet<KeyAccounter> KeyAccounters { get; set; }
        public virtual DbSet<KeywordsForMaterialFeature> KeywordsForMaterialFeatures { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<LicenseAgent> LicenseAgents { get; set; }
        public virtual DbSet<LicenseAgentLicense> LicenseAgentLicenses { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialAbbreveation> MaterialAbbreveations { get; set; }
        public virtual DbSet<MaterialBaseType> MaterialBaseTypes { get; set; }
        public virtual DbSet<MaterialFeature> MaterialFeatures { get; set; }
        public virtual DbSet<MaterialProductLine> MaterialProductLines { get; set; }
        public virtual DbSet<MaterialPurpose> MaterialPurposes { get; set; }
        public virtual DbSet<Motive> Motives { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderGroup> OrderGroups { get; set; }
        public virtual DbSet<OrderMarkup> OrderMarkups { get; set; }
        public virtual DbSet<OrderResultDatum> OrderResultData { get; set; }
        public virtual DbSet<OrderStyle> OrderStyles { get; set; }
        public virtual DbSet<OrderStyleMotive> OrderStyleMotives { get; set; }
        public virtual DbSet<OrderTask> OrderTasks { get; set; }
        public virtual DbSet<OrderTaskTemplate> OrderTaskTemplates { get; set; }
        public virtual DbSet<OrderTaskType> OrderTaskTypes { get; set; }
        public virtual DbSet<ProductionStatus> ProductionStatuses { get; set; }
        public virtual DbSet<ProductsInPortfolio> ProductsInPortfolios { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public virtual DbSet<SuppliersOfGpClient> SuppliersOfGpClients { get; set; }
        public virtual DbSet<TAldipurchaseOrga> TAldipurchaseOrgas { get; set; }
        public virtual DbSet<TabDetailgruppenConfig> TabDetailgruppenConfigs { get; set; }
        public virtual DbSet<TabImportOldDataFromAccess> TabImportOldDataFromAccesses { get; set; }
        public virtual DbSet<TabReportNachVertreterAccessDatum> TabReportNachVertreterAccessData { get; set; }
        public virtual DbSet<TaskInstancesEnquiry> TaskInstancesEnquiries { get; set; }
        public virtual DbSet<TermsOfDelivery> TermsOfDeliveries { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPhoto> UserPhotos { get; set; }
        public virtual DbSet<UserProductGroup> UserProductGroups { get; set; }
        public virtual DbSet<UserVertreter> UserVertreters { get; set; }
        public virtual DbSet<UserVertreterAlt> UserVertreterAlts { get; set; }
        public virtual DbSet<UserVertreterBackup20200915> UserVertreterBackup20200915s { get; set; }
        public virtual DbSet<UserVertreterDelete> UserVertreterDeletes { get; set; }
        public virtual DbSet<VAgentsCapacity> VAgentsCapacities { get; set; }
        public virtual DbSet<VAmxGetEnquiryItemByOrderId> VAmxGetEnquiryItemByOrderIds { get; set; }
        public virtual DbSet<VAuftragsbestandZeitvergleich> VAuftragsbestandZeitvergleiches { get; set; }
        public virtual DbSet<VChefliste> VCheflistes { get; set; }
        public virtual DbSet<VChefliste3> VChefliste3s { get; set; }
        public virtual DbSet<VCheflistenSync> VCheflistenSyncs { get; set; }
        public virtual DbSet<VCreationDateAccess> VCreationDateAccesses { get; set; }
        public virtual DbSet<VCubeFactory> VCubeFactories { get; set; }
        public virtual DbSet<VCubeReportNachVertreter> VCubeReportNachVertreters { get; set; }
        public virtual DbSet<VCubeReportNachVertreterNonUnique> VCubeReportNachVertreterNonUniques { get; set; }
        public virtual DbSet<VCubeSupplier> VCubeSuppliers { get; set; }
        public virtual DbSet<VDeliveryDate> VDeliveryDates { get; set; }
        public virtual DbSet<VDpr> VDprs { get; set; }
        public virtual DbSet<VDpr2> VDpr2s { get; set; }
        public virtual DbSet<VDprBackup> VDprBackups { get; set; }
        public virtual DbSet<VDprExport> VDprExports { get; set; }
        public virtual DbSet<VDprqb> VDprqbs { get; set; }
        public virtual DbSet<VDprqbBi> VDprqbBis { get; set; }
        public virtual DbSet<VDprqbBiDev> VDprqbBiDevs { get; set; }
        public virtual DbSet<VDprqbLast> VDprqbLasts { get; set; }
        public virtual DbSet<VDprqbLastTimeline> VDprqbLastTimelines { get; set; }
        public virtual DbSet<VEkinEuro> VEkinEuros { get; set; }
        public virtual DbSet<VFactoriesForOrder> VFactoriesForOrders { get; set; }
        public virtual DbSet<VFactoriesForOrders2> VFactoriesForOrders2s { get; set; }
        public virtual DbSet<VFactoriesForOrders2Backup202105> VFactoriesForOrders2Backup202105s { get; set; }
        public virtual DbSet<VFactoriesForOrdersWithSeason> VFactoriesForOrdersWithSeasons { get; set; }
        public virtual DbSet<VFactoryConnectionType> VFactoryConnectionTypes { get; set; }
        public virtual DbSet<VOrdernumberParent> VOrdernumberParents { get; set; }
        public virtual DbSet<VOrdernumberParent202104> VOrdernumberParent202104s { get; set; }
        public virtual DbSet<VOrdersPerFactory> VOrdersPerFactories { get; set; }
        public virtual DbSet<VProcurementQb> VProcurementQbs { get; set; }
        public virtual DbSet<VProductStatus> VProductStatuses { get; set; }
        public virtual DbSet<VProductStatusAccessory> VProductStatusAccessories { get; set; }
        public virtual DbSet<VProductStatusCartonsCompleted> VProductStatusCartonsCompleteds { get; set; }
        public virtual DbSet<VProductStatusCartonsShipped> VProductStatusCartonsShippeds { get; set; }
        public virtual DbSet<VProductStatusCutting> VProductStatusCuttings { get; set; }
        public virtual DbSet<VProductStatusDailyOutput> VProductStatusDailyOutputs { get; set; }
        public virtual DbSet<VProductStatusFabricEx> VProductStatusFabricices { get; set; }
        public virtual DbSet<VProductStatusFabricInhouseStatus> VProductStatusFabricInhouseStatuses { get; set; }
        public virtual DbSet<VProductStatusIroning> VProductStatusIronings { get; set; }
        public virtual DbSet<VProductStatusItemsPacked> VProductStatusItemsPackeds { get; set; }
        public virtual DbSet<VProductStatusKnitting> VProductStatusKnittings { get; set; }
        public virtual DbSet<VProductStatusLinesRunning> VProductStatusLinesRunnings { get; set; }
        public virtual DbSet<VProductStatusMotherVessel> VProductStatusMotherVessels { get; set; }
        public virtual DbSet<VProductStatusPcsSet> VProductStatusPcsSets { get; set; }
        public virtual DbSet<VProductStatusProductionStart> VProductStatusProductionStarts { get; set; }
        public virtual DbSet<VProductStatusSewing> VProductStatusSewings { get; set; }
        public virtual DbSet<VProductStatusWashReceived> VProductStatusWashReceiveds { get; set; }
        public virtual DbSet<VProductStatusWashSent> VProductStatusWashSents { get; set; }
        public virtual DbSet<VProductStatusZipper> VProductStatusZippers { get; set; }
        public virtual DbSet<VQcBd> VQcBds { get; set; }
        public virtual DbSet<VReportAnschlussLaenderNord> VReportAnschlussLaenderNords { get; set; }
        public virtual DbSet<VReportAuftragsbestandNachAbtUndProdGroup> VReportAuftragsbestandNachAbtUndProdGroups { get; set; }
        public virtual DbSet<VReportAuftragsvolumenNachMonat> VReportAuftragsvolumenNachMonats { get; set; }
        public virtual DbSet<VReportBySeason> VReportBySeasons { get; set; }
        public virtual DbSet<VReportGesamtuebersichtAuftragsbestand> VReportGesamtuebersichtAuftragsbestands { get; set; }
        public virtual DbSet<VReportJahrAbtProdGr> VReportJahrAbtProdGrs { get; set; }
        public virtual DbSet<VReportLieferantenVoluman> VReportLieferantenVolumen { get; set; }
        public virtual DbSet<VReportNachFactoryGroupAndFactory> VReportNachFactoryGroupAndFactories { get; set; }
        public virtual DbSet<VReportNachVertreerOverview> VReportNachVertreerOverviews { get; set; }
        public virtual DbSet<VReportNachVertrerOverview> VReportNachVertrerOverviews { get; set; }
        public virtual DbSet<VReportNachVertreter> VReportNachVertreters { get; set; }
        public virtual DbSet<VReportNachVertreterAufbereitenSharepoint> VReportNachVertreterAufbereitenSharepoints { get; set; }
        public virtual DbSet<VReportNachVertreterCumulatedFal> VReportNachVertreterCumulatedFals { get; set; }
        public virtual DbSet<VReportNachVertreterFal> VReportNachVertreterFals { get; set; }
        public virtual DbSet<VReportNachVertreterGruppiert> VReportNachVertreterGruppierts { get; set; }
        public virtual DbSet<VReportNachVertreterKundenGruppe> VReportNachVertreterKundenGruppes { get; set; }
        public virtual DbSet<VReportNachVertreterOverview> VReportNachVertreterOverviews { get; set; }
        public virtual DbSet<VReportNordOrdersWithAttachment> VReportNordOrdersWithAttachments { get; set; }
        public virtual DbSet<VReportOrdersByDate> VReportOrdersByDates { get; set; }
        public virtual DbSet<VReportPriceNotFilled> VReportPriceNotFilleds { get; set; }
        public virtual DbSet<VReportShipmentDate> VReportShipmentDates { get; set; }
        public virtual DbSet<VSeasonsAll> VSeasonsAlls { get; set; }
        public virtual DbSet<VSeasonsWithOrder> VSeasonsWithOrders { get; set; }
        public virtual DbSet<VSeasonsWithOrderLongHistory> VSeasonsWithOrderLongHistories { get; set; }
        public virtual DbSet<VShipmentDateRevicedOrOriginal> VShipmentDateRevicedOrOriginals { get; set; }
        public virtual DbSet<VUseFactoryForEmptyAgent> VUseFactoryForEmptyAgents { get; set; }
        public virtual DbSet<VUseFactoryForEmptyAgentsAccess> VUseFactoryForEmptyAgentsAccesses { get; set; }
        public virtual DbSet<VwRmgproduction> VwRmgproductions { get; set; }
        public virtual DbSet<WeAndWa> WeAndWas { get; set; }
        public virtual DbSet<WorkingArea> WorkingAreas { get; set; }
        public virtual DbSet<XSpEnquiry> XSpEnquiries { get; set; }
        public virtual DbSet<XSpEnquiryItem> XSpEnquiryItems { get; set; }
        public virtual DbSet<XSpOrder> XSpOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS_KS_WS");

            modelBuilder.Entity<AdditionalOrderInformation>(entity =>
            {
                entity.ToTable("AdditionalOrderInformation");

                entity.Property(e => e.AirFreightCosts).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Ba)
                    .HasColumnType("date")
                    .HasColumnName("BA");

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdexDate)
                    .HasColumnType("date")
                    .HasColumnName("CDexDate");

                entity.Property(e => e.FabricsFromCountry).HasMaxLength(50);

                entity.Property(e => e.FmreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("FMReceivedDate");

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(50);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(50);

                entity.Property(e => e.Fri1date)
                    .HasColumnType("date")
                    .HasColumnName("FRI1Date");

                entity.Property(e => e.Fri1quantity).HasColumnName("FRI1Quantity");

                entity.Property(e => e.Fri1result)
                    .HasMaxLength(50)
                    .HasColumnName("FRI1Result");

                entity.Property(e => e.Fri2date)
                    .HasColumnType("date")
                    .HasColumnName("FRI2Date");

                entity.Property(e => e.Fri2quantity).HasColumnName("FRI2Quantity");

                entity.Property(e => e.Fri2result)
                    .HasMaxLength(50)
                    .HasColumnName("FRI2Result");

                entity.Property(e => e.Fri3date)
                    .HasColumnType("date")
                    .HasColumnName("FRI3Date");

                entity.Property(e => e.Fri3quantity).HasColumnName("FRI3Quantity");

                entity.Property(e => e.Fri3result)
                    .HasMaxLength(50)
                    .HasColumnName("FRI3Result");

                entity.Property(e => e.Frilaboratory)
                    .HasMaxLength(255)
                    .HasColumnName("FRILaboratory");

                entity.Property(e => e.InspectionCosts).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.LatestEta)
                    .HasColumnType("date")
                    .HasColumnName("LatestETA");

                entity.Property(e => e.LatestFridate)
                    .HasColumnType("date")
                    .HasColumnName("LatestFRIDate");

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.NewSamplePickDate).HasColumnType("date");

                entity.Property(e => e.OriginalSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PackingQb)
                    .HasMaxLength(50)
                    .HasColumnName("PackingQB");

                entity.Property(e => e.ProcurementQb)
                    .HasMaxLength(255)
                    .HasColumnName("ProcurementQB");

                entity.Property(e => e.Qc)
                    .HasMaxLength(255)
                    .HasColumnName("QC");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SamplePickShortResult).HasMaxLength(50);

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SupplierDeliveryDateOriginal).HasColumnType("date");

                entity.Property(e => e.TestingLaboratory).HasMaxLength(255);

                entity.Property(e => e.Vessel).HasMaxLength(255);

                entity.HasOne(d => d.EndCustomer)
                    .WithMany(p => p.AdditionalOrderInformations)
                    .HasForeignKey(d => d.EndCustomerId)
                    .HasConstraintName("FK_AdditionalOrderInformation_EndCustomer");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.AdditionalOrderInformations)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("FK_AdditionalOrderInformation_Orders");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.Abc).HasMaxLength(255);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AgentNameChiefList).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMail");

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Province).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);
            });

            modelBuilder.Entity<AgentsContactPerson>(entity =>
            {
                entity.ToTable("Agents_ContactPersons");

                entity.HasIndex(e => e.AgentId, "IX_Agents_ContactPersons_AgentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ContactPersonId, "IX_Agents_ContactPersons_ContactPersonId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.AgentsContactPeople)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_AgentsContactPersons_Agents");

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.AgentsContactPeople)
                    .HasForeignKey(d => d.ContactPersonId)
                    .HasConstraintName("FK_AgentsContactPersons_ContactPersons");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasIndex(e => e.CertificationBodyId, "IX_Appointments_CertificationBodyId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.PurposeOfFactoryVisitId, "IX_Appointments_PurposeOfFactoryVisitId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.AppointmentEnd).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FactoryVisitId).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PlaceOfFactoryVisit).HasMaxLength(255);

                entity.HasOne(d => d.CertificationBody)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CertificationBodyId)
                    .HasConstraintName("FK_Appointments_CertificationBodies");

                entity.HasOne(d => d.PurposeOfFactoryVisit)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PurposeOfFactoryVisitId)
                    .HasConstraintName("FK_Appointments_FactoryVisitPurposes");
            });

            modelBuilder.Entity<AppointmentsContainer>(entity =>
            {
                entity.ToTable("Appointments_Containers");

                entity.HasIndex(e => e.AppointmentId, "IX_Appointments_Containers_AppointmentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ContainerId, "IX_Appointments_Containers_ContainerId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentsContainers)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_AppointmentsContainers_Appointments");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.AppointmentsContainers)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_AppointmentsContainers_Containers");
            });

            modelBuilder.Entity<AppointmentsFactory>(entity =>
            {
                entity.ToTable("Appointments_Factories");

                entity.HasIndex(e => e.AppointmentId, "IX_Appointments_Factories_AppointmentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.FactoryId, "IX_Appointments_Factories_FactoryId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentsFactories)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_AppointmentsFactories_Appointments");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.AppointmentsFactories)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_AppointmentsFactories_Factories");
            });

            modelBuilder.Entity<AppointmentsOrder>(entity =>
            {
                entity.ToTable("Appointments_Orders");

                entity.HasIndex(e => e.AppointmentId, "IX_Appointments_Orders_AppointmentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.OrderId, "IX_Appointments_Orders_OrderId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentsOrders)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_AppointmentsOrders_Appointments");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AppointmentsOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_AppointmentsOrders_Orders");
            });

            modelBuilder.Entity<ArticleVariation>(entity =>
            {
                entity.Property(e => e.ArticleNumber).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ArticleVariations)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_ArticleVariations_Orders");
            });

            modelBuilder.Entity<AuditingCompany>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMail");

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);
            });

            modelBuilder.Entity<BuyingAgent>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_BuyingAgents_ClientId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BuyingAgentResponsibleFor).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.IdBuyingAgent).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Province).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.BuyingAgents)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_BuyingAgents_Clients");
            });

            modelBuilder.Entity<CapacityGroup>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificationBody>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientNameChiefList).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdClient).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ConfigActualSeason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Config_ActualSeason");

                entity.Property(e => e.SeasonTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Season_Title");
            });

            modelBuilder.Entity<ContactPerson>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.IdContactPerson).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.HasIndex(e => e.ShippingCompanyId, "IX_Containers_ShippingCompanyId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.AtbNumber).HasMaxLength(255);

                entity.Property(e => e.AtcNumber).HasMaxLength(255);

                entity.Property(e => e.ContainerPin).HasMaxLength(255);

                entity.Property(e => e.ContainerType).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EstimatedTimeOfArrival).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Vessel).HasMaxLength(255);

                entity.Property(e => e.Warehouse).HasMaxLength(255);

                entity.HasOne(d => d.ShippingCompany)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.ShippingCompanyId)
                    .HasConstraintName("FK_Containers_ShippingCompanies");
            });

            modelBuilder.Entity<ContainerContent>(entity =>
            {
                entity.HasIndex(e => e.ContainerId, "IX_ContainerContents_ContainerId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DepartmentWeb).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OrderItemId).HasMaxLength(255);

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ContainerContents)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_ContainerContents_Containers");
            });

            modelBuilder.Entity<CountryShortcut>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CountryShortcut1)
                    .HasMaxLength(255)
                    .HasColumnName("CountryShortcut");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Dbo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbo");

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eMail");

                entity.Property(e => e.GesperrtRls).HasColumnName("Gesperrt_RLS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Userprincipalname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<DepartmentWeb>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Dmlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_DMLOG");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<Dprqb>(entity =>
            {
                entity.ToTable("DPRQB");

                entity.Property(e => e.Dprqbid).HasColumnName("DPRQBId");

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.FabricsFrom).HasMaxLength(50);

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(100);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(100);

                entity.Property(e => e.Fri1Date).HasColumnType("date");

                entity.Property(e => e.Fri1Qty).HasColumnName("Fri1QTY");

                entity.Property(e => e.Fri1Result).HasMaxLength(50);

                entity.Property(e => e.Fri2Date).HasColumnType("date");

                entity.Property(e => e.Fri2Qty).HasColumnName("Fri2QTY");

                entity.Property(e => e.Fri2Result).HasMaxLength(50);

                entity.Property(e => e.Fri3Date).HasColumnType("date");

                entity.Property(e => e.Fri3Qty).HasColumnName("Fri3QTY");

                entity.Property(e => e.Fri3Result).HasMaxLength(50);

                entity.Property(e => e.Frilab)
                    .HasMaxLength(50)
                    .HasColumnName("FRILab");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ReSamplePick).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SpshortResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPShortResult");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.TestingLab).HasMaxLength(50);
            });

            modelBuilder.Entity<Dprsync>(entity =>
            {
                entity.ToTable("DPRSync");

                entity.Property(e => e.DprsyncId).HasColumnName("DPRSyncId");

                entity.Property(e => e.Direction).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EndCustomer>(entity =>
            {
                entity.ToTable("EndCustomer");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<EnquiriesMaterial>(entity =>
            {
                entity.ToTable("Enquiries_Materials");

                entity.HasIndex(e => e.EnquiryId, "IX_Enquiries_Materials_EnquiryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.MaterialId, "IX_Enquiries_Materials_MaterialId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiriesMaterials)
                    .HasForeignKey(d => d.EnquiryId)
                    .HasConstraintName("FK_EnquiriesMaterials_Enquiries");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.EnquiriesMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_EnquiriesMaterials_Materials");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasIndex(e => e.BuyingAgentId, "IX_Enquiries_BuyingAgentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ClientId, "IX_Enquiries_ClientId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.SeasonId, "IX_Enquiries_SeasonId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.ArticleNumberOfClient).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DocumentsReceivedFromSourcing).HasColumnType("datetime");

                entity.Property(e => e.EnquiryCompleted).HasColumnType("datetime");

                entity.Property(e => e.EnquiryInduced).HasColumnType("datetime");

                entity.Property(e => e.EnquiryTaskConnector).HasMaxLength(255);

                entity.Property(e => e.IdEnquiry).HasMaxLength(255);

                entity.Property(e => e.LaunchAtClient).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OfferMade).HasColumnType("datetime");

                entity.Property(e => e.PresentationUntil).HasColumnType("datetime");

                entity.Property(e => e.ProbableSellingPriceGp).HasMaxLength(255);

                entity.Property(e => e.ShortInformationAboutMaterial).HasMaxLength(255);

                entity.Property(e => e.ShrinkingFactorFromOffer).HasMaxLength(255);

                entity.Property(e => e.ShrinkingFactorToOffer).HasMaxLength(255);

                entity.Property(e => e.SupplierOfGpClient).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.BuyingAgent)
                    .WithMany(p => p.Enquiries)
                    .HasForeignKey(d => d.BuyingAgentId)
                    .HasConstraintName("FK_Enquiries_BuyingAgents");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Enquiries)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Enquiries_Clients");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Enquiries)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_Enquiries_Seasons");
            });

            modelBuilder.Entity<EnquiryItem>(entity =>
            {
                entity.HasIndex(e => e.AgentId, "IX_EnquiryItems_AgentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CurrencyEk, "IX_EnquiryItems_CurrencyEk")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CurrencyOfGpSellingPrices, "IX_EnquiryItems_CurrencyOfGpSellingPrices")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CurrencyPurchPrSurcharge, "IX_EnquiryItems_CurrencyPurchPrSurcharge")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CurrencyVkClient, "IX_EnquiryItems_CurrencyVkClient")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.EnquiryId, "IX_EnquiryItems_EnquiryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.FactoryId, "IX_EnquiryItems_FactoryId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionShort).HasMaxLength(255);

                entity.Property(e => e.EnquirySentToFactoryOrAgent).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PurchPrSurcharge).HasColumnType("money");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.EnquiryItems)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_EnquiryItems_Agents");

                entity.HasOne(d => d.CurrencyEkNavigation)
                    .WithMany(p => p.EnquiryItemCurrencyEkNavigations)
                    .HasForeignKey(d => d.CurrencyEk)
                    .HasConstraintName("FK_EnquiryItems_Currencies_EK");

                entity.HasOne(d => d.CurrencyOfGpSellingPricesNavigation)
                    .WithMany(p => p.EnquiryItemCurrencyOfGpSellingPricesNavigations)
                    .HasForeignKey(d => d.CurrencyOfGpSellingPrices);

                entity.HasOne(d => d.CurrencyPurchPrSurchargeNavigation)
                    .WithMany(p => p.EnquiryItemCurrencyPurchPrSurchargeNavigations)
                    .HasForeignKey(d => d.CurrencyPurchPrSurcharge);

                entity.HasOne(d => d.CurrencyVkClientNavigation)
                    .WithMany(p => p.EnquiryItemCurrencyVkClientNavigations)
                    .HasForeignKey(d => d.CurrencyVkClient)
                    .HasConstraintName("FK_EnquiryItems_Currencies_VkClient");

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiryItems)
                    .HasForeignKey(d => d.EnquiryId)
                    .HasConstraintName("FK_EnquiryItems_Enquiries");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.EnquiryItems)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_EnquiryItems_Factories");
            });

            modelBuilder.Entity<EnquiryItemsMaterial>(entity =>
            {
                entity.ToTable("EnquiryItems_Materials");

                entity.HasIndex(e => e.EnquiryItemId, "IX_EnquiryItems_Materials_EnquiryItemId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.MaterialId, "IX_EnquiryItems_Materials_MaterialId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.EnquiryItem)
                    .WithMany(p => p.EnquiryItemsMaterials)
                    .HasForeignKey(d => d.EnquiryItemId)
                    .HasConstraintName("FK_EnquiryItemsMaterials_EnquiryItems");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.EnquiryItemsMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_EnquiryItemsMaterials_Materials");
            });

            modelBuilder.Entity<EnquiryTask>(entity =>
            {
                entity.HasIndex(e => e.EnquiryId, "IX_EnquiryTasks_EnquiryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.TemplateId, "IX_EnquiryTasks_TemplateId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DoneOn).HasColumnType("datetime");

                entity.Property(e => e.EnquiryDeadline).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiryTasks)
                    .HasForeignKey(d => d.EnquiryId)
                    .HasConstraintName("FK_EnquiryTasks_Enquiries");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.EnquiryTasks)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_EnquiryTasks_Templates");
            });

            modelBuilder.Entity<EnquiryTaskTemplate>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OfficialInChargeField).HasMaxLength(255);

                entity.Property(e => e.OffsetPrimaryField).HasMaxLength(255);

                entity.Property(e => e.OffsetSecondaryField).HasMaxLength(255);
            });

            modelBuilder.Entity<EnquiryTaskType>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ExchangeAcceptance>(entity =>
            {
                entity.HasIndex(e => e.CurrencyId, "IX_ExchangeAcceptances_CurrencyId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.SeasonId, "IX_ExchangeAcceptances_SeasonId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateAcceptance).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ExchangeAcceptances)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_ExchangeAcceptances_Currencies");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.ExchangeAcceptances)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_ExchangeAcceptances_Seasons");
            });

            modelBuilder.Entity<FactoriesContactPerson>(entity =>
            {
                entity.ToTable("Factories_ContactPersons");

                entity.HasIndex(e => e.ContactPersonId, "IX_Factories_ContactPersons_ContactPersonId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.FactoryId, "IX_Factories_ContactPersons_FactoryId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.FactoriesContactPeople)
                    .HasForeignKey(d => d.ContactPersonId)
                    .HasConstraintName("FK_FactoriesContactPersons_ContactPersons");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FactoriesContactPeople)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_FactoriesContactPersons_Factories");
            });

            modelBuilder.Entity<Factory>(entity =>
            {
                entity.HasIndex(e => e.Agent2Id, "IX_Factories_Agent2Id")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.AgentId, "IX_Factories_AgentId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AldiFacilityCode).HasMaxLength(255);

                entity.Property(e => e.AppliedForNewBoilerLicenceOn).HasColumnType("datetime");

                entity.Property(e => e.AppliedForNewFireLicenceOn).HasColumnType("datetime");

                entity.Property(e => e.AppliedForNewGeneratorLicenceOn).HasColumnType("datetime");

                entity.Property(e => e.AuditCompanyOfLast3rdPartyAudit).HasMaxLength(255);

                entity.Property(e => e.AuditNumberOfLastBsciAudit).HasMaxLength(255);

                entity.Property(e => e.BoilerLicenceValidUntil).HasColumnType("datetime");

                entity.Property(e => e.BsciDatabaseId).HasColumnType("text");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CommentsAboutAccord).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateLastExtChemManAuditRep).HasColumnType("datetime");

                entity.Property(e => e.DateOfCapFinalizationForGpReAudit).HasColumnType("datetime");

                entity.Property(e => e.DateOfLastInternalGpAudit).HasColumnType("datetime");

                entity.Property(e => e.DateOfSelfAssessment).HasColumnType("datetime");

                entity.Property(e => e.DateOfTestReportDischargeData).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMail");

                entity.Property(e => e.EstimatedDateOfNext3rdPartyAudit).HasColumnType("datetime");

                entity.Property(e => e.FactNeededByDepartm).HasMaxLength(255);

                entity.Property(e => e.FireLicenceValidUntil).HasColumnType("datetime");

                entity.Property(e => e.FurtherDescriptionOfProductPortfolio).HasMaxLength(255);

                entity.Property(e => e.GeneratorLicenceValidUntil).HasColumnType("datetime");

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.InspectionDateAccordElectricalSafety).HasColumnType("datetime");

                entity.Property(e => e.InspectionDateAccordFireSafety).HasColumnType("datetime");

                entity.Property(e => e.InspectionDateStructuralSafety).HasColumnType("datetime");

                entity.Property(e => e.IpeUploadOn).HasColumnType("datetime");

                entity.Property(e => e.Last3rdPartyAudit).HasColumnType("datetime");

                entity.Property(e => e.Last3rdPartyBsciFullAudit).HasColumnType("datetime");

                entity.Property(e => e.LastOekoTexStePaudit)
                    .HasColumnType("datetime")
                    .HasColumnName("LastOekoTexSTePAudit");

                entity.Property(e => e.LeadBrandAccord).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameOfFireSafetyOfficer).HasMaxLength(255);

                entity.Property(e => e.NameOfGpLeadAuditor).HasMaxLength(255);

                entity.Property(e => e.Next3rdPartyAuditBookedOn).HasColumnType("datetime");

                entity.Property(e => e.OekoTexStePcertificateValidUntil)
                    .HasColumnType("datetime")
                    .HasColumnName("OekoTexSTePCertificateValidUntil");

                entity.Property(e => e.OrdersPlacedInFactory).HasMaxLength(255);

                entity.Property(e => e.OtherClientsOfFactory).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Province).HasMaxLength(255);

                entity.Property(e => e.ReceivingDateAccordFireSafetyReport).HasColumnType("datetime");

                entity.Property(e => e.ReceivingDateAccordStructuralSafetyReport).HasColumnType("datetime");

                entity.Property(e => e.ReceivingDateElectricalSafetyReport).HasColumnType("datetime");

                entity.Property(e => e.RegisteredAtIpe).HasColumnName("RegisteredAtIPe");

                entity.Property(e => e.Sa8000CertificateNumber).HasMaxLength(255);

                entity.Property(e => e.SedexReferenceNumber).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.ValidityOfCertificateOrLastAudit).HasColumnType("datetime");

                entity.Property(e => e.WovenOrKnitFactory).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);

                entity.HasOne(d => d.Agent2)
                    .WithMany(p => p.FactoryAgent2s)
                    .HasForeignKey(d => d.Agent2Id)
                    .HasConstraintName("FK_Factories_Agents_Agent2");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.FactoryAgents)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_Factories_Agents");
            });

            modelBuilder.Entity<FactoryCollaboration>(entity =>
            {
                entity.HasIndex(e => e.CollaborationFactoryId, "IX_FactoryCollaborations_CollaborationFactoryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.FactoryId, "IX_FactoryCollaborations_FactoryId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.HasOne(d => d.CollaborationFactory)
                    .WithMany(p => p.FactoryCollaborationCollaborationFactories)
                    .HasForeignKey(d => d.CollaborationFactoryId)
                    .HasConstraintName("FK_FactoryCollaborations_Factories_Factory2");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FactoryCollaborationFactories)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_FactoryCollaborations_Factories");
            });

            modelBuilder.Entity<FactoryConnection>(entity =>
            {
                entity.HasIndex(e => e.FactoryId, "IX_FactoryConnections_FactoryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.OrderId, "IX_FactoryConnections_OrderId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FactoryWasReportedToCustomerOn).HasColumnType("datetime");

                entity.Property(e => e.IdTypeOfFactoryInvolvementId).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductionStatusOfFactoryInvolvement).HasMaxLength(255);

                entity.Property(e => e.UnitOfDailyOutput).HasMaxLength(255);

                entity.Property(e => e.UnitOfFabricQuantity).HasMaxLength(255);

                entity.Property(e => e.WebTitle).HasMaxLength(255);

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FactoryConnections)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_FactoryConnections_Factories");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.FactoryConnections)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_FactoryConnections_Orders");
            });

            modelBuilder.Entity<FactoryFeature>(entity =>
            {
                entity.HasIndex(e => e.FactoryId, "IX_FactoryFeatures_FactoryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductLineOfMaterialId, "IX_FactoryFeatures_ProductLineOfMaterialId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductWithinPortfolioId, "IX_FactoryFeatures_ProductWithinPortfolioId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.ContentTypeName).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameOfMashineType).HasMaxLength(255);

                entity.Property(e => e.ProductLineOfFinishedGoods).HasMaxLength(255);

                entity.Property(e => e.ProductionStage).HasMaxLength(255);

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FactoryFeatures)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_FactoryFeatures_Factories");

                entity.HasOne(d => d.ProductLineOfMaterial)
                    .WithMany(p => p.FactoryFeatures)
                    .HasForeignKey(d => d.ProductLineOfMaterialId)
                    .HasConstraintName("FK_FactoryFeatures_MaterialProductLines");

                entity.HasOne(d => d.ProductWithinPortfolio)
                    .WithMany(p => p.FactoryFeatures)
                    .HasForeignKey(d => d.ProductWithinPortfolioId)
                    .HasConstraintName("FK_FactoryFeatures_ProductsInPortfolio");
            });

            modelBuilder.Entity<FactoryVisitPurpose>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ForwardExchangeDealing>(entity =>
            {
                entity.HasIndex(e => e.CurrencyId, "IX_ForwardExchangeDealings_CurrencyId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.SeasonId, "IX_ForwardExchangeDealings_SeasonId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Bank).HasMaxLength(255);

                entity.Property(e => e.CallAt).HasColumnType("datetime");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ExertionFrom).HasColumnType("datetime");

                entity.Property(e => e.ExertionTo).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Tradingdate).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ForwardExchangeDealings)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_ForwardExchangeDealings_Currencies");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.ForwardExchangeDealings)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_ForwardExchangeDealings_Seasons");
            });

            modelBuilder.Entity<GpRepresentativeMapping>(entity =>
            {
                entity.ToTable("GpRepresentativeMapping");

                entity.HasIndex(e => e.ClientId, "IX_GpRepresentativeMapping_ClientID")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(255)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GpRepresentativeMappings)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_GpRepresentativeMapping_Clients");
            });

            modelBuilder.Entity<IncomingTermsOfDelivery>(entity =>
            {
                entity.ToTable("IncomingTermsOfDelivery");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Initial>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.SettingsOwner).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<KeyAccounter>(entity =>
            {
                entity.ToTable("KeyAccounter");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KeywordsForMaterialFeature>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.ToTable("License");

                entity.Property(e => e.LicenseName).HasMaxLength(255);
            });

            modelBuilder.Entity<LicenseAgent>(entity =>
            {
                entity.ToTable("LicenseAgent");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LicenseAgentLicense>(entity =>
            {
                entity.ToTable("LicenseAgentLicense");

                entity.Property(e => e.AgentFee).HasColumnType("decimal(8, 4)");

                entity.HasOne(d => d.LicenseAgent)
                    .WithMany(p => p.LicenseAgentLicenses)
                    .HasForeignKey(d => d.LicenseAgentId)
                    .HasConstraintName("FK_LicenseAgentLicense_LicenseAgent");

                entity.HasOne(d => d.License)
                    .WithMany(p => p.LicenseAgentLicenses)
                    .HasForeignKey(d => d.LicenseId)
                    .HasConstraintName("FK_LicenseAgentLicense_License");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasIndex(e => e.GeneralTypeOfMaterialId, "IX_Materials_GeneralTypeOfMaterialId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.PurposeOfMaterialId, "IX_Materials_PurposeOfMaterialId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EffectiveWidth).HasMaxLength(255);

                entity.Property(e => e.FurtherCommentsRegardingThreadDensity).HasMaxLength(255);

                entity.Property(e => e.MaterialDescription).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.SampleReceived).HasColumnType("datetime");

                entity.Property(e => e.ShrinkingFactorWarpFrom).HasMaxLength(255);

                entity.Property(e => e.ShrinkingFactorWarpTo).HasMaxLength(255);

                entity.Property(e => e.ShrinkingFactorWeftFrom).HasMaxLength(255);

                entity.Property(e => e.ShrinkingFactorWeftTo).HasMaxLength(255);

                entity.Property(e => e.UnitOfFiberMassDensity).HasMaxLength(255);

                entity.Property(e => e.UnitOfRelativeWeightOfMaterial).HasMaxLength(255);

                entity.Property(e => e.UnitOfThreadDensities).HasMaxLength(255);

                entity.Property(e => e.UnitOfYarnMassDensity).HasMaxLength(255);

                entity.HasOne(d => d.GeneralTypeOfMaterial)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.GeneralTypeOfMaterialId)
                    .HasConstraintName("FK_Materials_MaterialBaseTypes");

                entity.HasOne(d => d.PurposeOfMaterial)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.PurposeOfMaterialId)
                    .HasConstraintName("FK_Materials_MaterialPurposes");
            });

            modelBuilder.Entity<MaterialAbbreveation>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<MaterialBaseType>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<MaterialFeature>(entity =>
            {
                entity.HasIndex(e => e.AgentId, "IX_MaterialFeatures_AgentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CurrencyOfFabricPurchasingPriceId, "IX_MaterialFeatures_CurrencyOfFabricPurchasingPriceId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.FactoryId, "IX_MaterialFeatures_FactoryId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.IncotermForFabricPurchasingPriceId, "IX_MaterialFeatures_IncotermForFabricPurchasingPriceId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.KeywordForMaterialFeatureId, "IX_MaterialFeatures_KeywordForMaterialFeatureId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.MaterialAbbreveationId, "IX_MaterialFeatures_MaterialAbbreveationId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.AssociatedMaterialId).HasMaxLength(255);

                entity.Property(e => e.BaseOfFabricPurchasingPrice).HasMaxLength(255);

                entity.Property(e => e.ContentTypeName).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateOfFabricPurchasingPriceEnquiry).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameOfTreatmentSymbol).HasMaxLength(255);

                entity.Property(e => e.PaymentTermsForFabricPurchasingPrice).HasMaxLength(255);

                entity.Property(e => e.QuickInfoIfNewAgent).HasMaxLength(255);

                entity.Property(e => e.QuickInfoIfNewFactory).HasMaxLength(255);

                entity.Property(e => e.UnitOfFabricPurchasingQuantity).HasMaxLength(255);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_MaterialFeatures_Agents");

                entity.HasOne(d => d.CurrencyOfFabricPurchasingPrice)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.CurrencyOfFabricPurchasingPriceId)
                    .HasConstraintName("FK_MaterialFeatures_Currencies");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_MaterialFeatures_Factories");

                entity.HasOne(d => d.IncotermForFabricPurchasingPrice)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.IncotermForFabricPurchasingPriceId)
                    .HasConstraintName("FK_MaterialFeatures_IncomingTermsOfDelivery");

                entity.HasOne(d => d.KeywordForMaterialFeature)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.KeywordForMaterialFeatureId)
                    .HasConstraintName("FK_MaterialFeatures_KeywordsForMaterialFeatures");

                entity.HasOne(d => d.MaterialAbbreveation)
                    .WithMany(p => p.MaterialFeatures)
                    .HasForeignKey(d => d.MaterialAbbreveationId)
                    .HasConstraintName("FK_MaterialFeatures_MaterialAbbreveations");
            });

            modelBuilder.Entity<MaterialProductLine>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<MaterialPurpose>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Motive>(entity =>
            {
                entity.ToTable("Motive");

                entity.Property(e => e.RoyaltyRateDat)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("RoyaltyRateDAT");

                entity.Property(e => e.RoyaltyRateFob)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("RoyaltyRateFOB");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.License)
                    .WithMany(p => p.Motives)
                    .HasForeignKey(d => d.LicenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Motive_License");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.BuyingAgentId, "IX_Orders_BuyingAgentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ClientId, "IX_Orders_ClientId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.EnquiryItemId, "IX_Orders_EnquiryItemId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.SeasonId, "IX_Orders_SeasonId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.AdditionalCode).HasMaxLength(255);

                entity.Property(e => e.AdditionalTestRequirementsAccordingToCustomerContractReceipt).HasMaxLength(255);

                entity.Property(e => e.ArticleNumberOfClient).HasMaxLength(255);

                entity.Property(e => e.CartonType).HasMaxLength(255);

                entity.Property(e => e.ContractNumberClient).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomerDeliveryDateFrom).HasColumnType("datetime");

                entity.Property(e => e.CustomerDeliveryDateTill).HasColumnType("datetime");

                entity.Property(e => e.DateOfDuPro).HasColumnType("datetime");

                entity.Property(e => e.DateOfFabric).HasColumnType("datetime");

                entity.Property(e => e.DatePlacementOfOrderByClient).HasColumnType("datetime");

                entity.Property(e => e.DuProLaboratory).HasMaxLength(255);

                entity.Property(e => e.IdOrder).HasMaxLength(255);

                entity.Property(e => e.InternalOrderMeeting).HasColumnType("datetime");

                entity.Property(e => e.LabOekoTexRequiredByCustomerUntil).HasColumnType("datetime");

                entity.Property(e => e.LabOekoTexSubmittedToCustomer).HasColumnType("datetime");

                entity.Property(e => e.LastShipmentOfOrder).HasColumnType("datetime");

                entity.Property(e => e.LatestDuProDate).HasColumnType("datetime");

                entity.Property(e => e.LatestEtaGermany).HasColumnType("datetime");

                entity.Property(e => e.LcState).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OekoTexApplicationSentOut).HasMaxLength(255);

                entity.Property(e => e.OrderDetailsAlignedWithCustomer).HasColumnType("datetime");

                entity.Property(e => e.OrderFixedWithSupplier).HasColumnType("datetime");

                entity.Property(e => e.OrderKombi).HasMaxLength(255);

                entity.Property(e => e.OrderTaskConnector).HasMaxLength(255);

                entity.Property(e => e.ProductLineId)
                    .HasMaxLength(255)
                    .HasColumnName("ProductLineID");

                entity.Property(e => e.ShipName).HasMaxLength(255);

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDateRevised).HasColumnType("datetime");

                entity.Property(e => e.SizesFrom).HasMaxLength(255);

                entity.Property(e => e.SizesTo).HasMaxLength(255);

                entity.Property(e => e.SourceLocationOfTruckDeliveryToPort).HasMaxLength(255);

                entity.Property(e => e.SupplierRevisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.TermsOfDeliveryToClient).HasMaxLength(255);

                entity.Property(e => e.TermsOfDeliveryToGp).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.WebTitle).HasMaxLength(255);

                entity.Property(e => e._3rdPartyInspectionCompany)
                    .HasMaxLength(255)
                    .HasColumnName("3rdPartyInspectionCompany");

                entity.HasOne(d => d.BuyingAgent)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BuyingAgentId)
                    .HasConstraintName("FK_Orders_BuyingAgents");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Orders_Clients");

                entity.HasOne(d => d.EnquiryItem)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EnquiryItemId)
                    .HasConstraintName("FK_Orders_EnquiryItems");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_Orders_Seasons");
            });

            modelBuilder.Entity<OrderGroup>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_OrderGroups_OrderId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateControllingSheetClosed).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.TypeOfOrderGroup).HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderGroups)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderGroups_Orders");
            });

            modelBuilder.Entity<OrderMarkup>(entity =>
            {
                entity.ToTable("OrderMarkup");

                entity.Property(e => e.Markup).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.MarkupExchangeRate).HasColumnType("decimal(8, 4)");

                entity.HasOne(d => d.MarkupCurrencyNavigation)
                    .WithMany(p => p.OrderMarkups)
                    .HasForeignKey(d => d.MarkupCurrency)
                    .HasConstraintName("FK_OrderMarkup_Currencies");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderMarkups)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderMarkup_Orders");
            });

            modelBuilder.Entity<OrderResultDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrderResultData");

                entity.Property(e => e.AdditionalCode).HasMaxLength(255);

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.ClientTitle).HasMaxLength(255);

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(255);

                entity.Property(e => e.ProductGroupTitle).HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderStyle>(entity =>
            {
                entity.HasKey(e => e.OrderStylesId);

                entity.Property(e => e.ExchangeRateSellingPrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.GpsellingPrice)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("GPSellingPrice");

                entity.Property(e => e.PurchasePrice1).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.PurchasePrice2).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.PurchasePrice3).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.RateOfDuty).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SellingPriceInclIncoTerm).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.CurrencyPurchasePriceNavigation)
                    .WithMany(p => p.OrderStyleCurrencyPurchasePriceNavigations)
                    .HasForeignKey(d => d.CurrencyPurchasePrice)
                    .HasConstraintName("FK_OrderStyles_Currencies_PP");

                entity.HasOne(d => d.CurrencySellingPriceNavigation)
                    .WithMany(p => p.OrderStyleCurrencySellingPriceNavigations)
                    .HasForeignKey(d => d.CurrencySellingPrice)
                    .HasConstraintName("FK_OrderStyles_Currencies_SP");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderStyles)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderStyles_Orders");
            });

            modelBuilder.Entity<OrderStyleMotive>(entity =>
            {
                entity.ToTable("OrderStyleMotive");

                entity.HasOne(d => d.Motive)
                    .WithMany(p => p.OrderStyleMotives)
                    .HasForeignKey(d => d.MotiveId)
                    .HasConstraintName("FK_OrderStyleMotive_Motive");

                entity.HasOne(d => d.OrderStyle)
                    .WithMany(p => p.OrderStyleMotives)
                    .HasForeignKey(d => d.OrderStyleId)
                    .HasConstraintName("FK_OrderStyleMotive_OrderStyles");
            });

            modelBuilder.Entity<OrderTask>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_OrderTasks_OrderId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.TemplateId, "IX_OrderTasks_TemplateId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DoneOn).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FinishedAt).HasColumnType("datetime");

                entity.Property(e => e.InternalNameCompleted).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OrderDescription).HasMaxLength(255);

                entity.Property(e => e.OrderTaskConnector).HasMaxLength(255);

                entity.Property(e => e.ParentItemlink).HasMaxLength(255);

                entity.Property(e => e.SeasonName).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderTasks)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderTasks_Orders");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OrderTasks)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_OrderTasks_OrderTaskTemplates");
            });

            modelBuilder.Entity<OrderTaskTemplate>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OfficialInChargeField).HasMaxLength(255);

                entity.Property(e => e.OffsetPrimaryField).HasMaxLength(255);

                entity.Property(e => e.OffsetSecondaryField).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderTaskType>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ProductionStatus>(entity =>
            {
                entity.ToTable("ProductionStatus");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductionStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionStatus_Orders");
            });

            modelBuilder.Entity<ProductsInPortfolio>(entity =>
            {
                entity.ToTable("ProductsInPortfolio");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ShippingCompany>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<SuppliersOfGpClient>(entity =>
            {
                entity.ToTable("SuppliersOfGpClient");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<TAldipurchaseOrga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_ALDIPurchaseOrga", "Matching");

                entity.Property(e => e.AldipurchOrga)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALDIPurchOrga");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabDetailgruppenConfig>(entity =>
            {
                entity.HasKey(e => e.Artikelbezeichnung)
                    .HasName("PK_Detailgruppen_Config");

                entity.ToTable("tab_Detailgruppen_Config");

                entity.Property(e => e.Artikelbezeichnung).HasMaxLength(255);

                entity.Property(e => e.Geschlecht)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Produktart)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TabImportOldDataFromAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tab_Import_OldDataFromAccess");

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.BaKdI).HasMaxLength(255);

                entity.Property(e => e.BaKdIi)
                    .HasMaxLength(255)
                    .HasColumnName("BaKdII");

                entity.Property(e => e.BaKdIii)
                    .HasMaxLength(255)
                    .HasColumnName("BaKdIII");

                entity.Property(e => e.Bemerkung).HasMaxLength(255);

                entity.Property(e => e.Daterstellt).HasColumnName("daterstellt");

                entity.Property(e => e.Ek1).HasColumnName("EK 1");

                entity.Property(e => e.Ek2).HasColumnName("EK 2");

                entity.Property(e => e.Ek3).HasColumnName("EK 3");

                entity.Property(e => e.Ekrem).HasColumnName("EKREM");

                entity.Property(e => e.Erledigt).HasColumnName("erledigt");

                entity.Property(e => e.Foto).HasColumnName("foto");

                entity.Property(e => e.ItemGuid).HasMaxLength(255);

                entity.Property(e => e.Kdlt)
                    .HasColumnType("datetime")
                    .HasColumnName("kdlt");

                entity.Property(e => e.Kennzeichen)
                    .HasMaxLength(255)
                    .HasColumnName("kennzeichen");

                entity.Property(e => e.Kkplatz).HasColumnName("kkplatz");

                entity.Property(e => e.Kkus).HasColumnName("kkus");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Kw)
                    .HasMaxLength(255)
                    .HasColumnName("KW");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lbed1)
                    .HasMaxLength(255)
                    .HasColumnName("lbed1");

                entity.Property(e => e.Lbed2)
                    .HasMaxLength(255)
                    .HasColumnName("lbed2");

                entity.Property(e => e.Lbkontr).HasColumnName("lbkontr");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC");

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.LtBis).HasColumnName("LT bis");

                entity.Property(e => e.LtVon).HasColumnName("LT von");

                entity.Property(e => e.Menge2).HasColumnName("menge2");

                entity.Property(e => e.Mengeopt1).HasColumnName("mengeopt1");

                entity.Property(e => e.Mengeopt2).HasColumnName("mengeopt2");

                entity.Property(e => e.Order).HasMaxLength(255);

                entity.Property(e => e.Orig).HasColumnName("orig");

                entity.Property(e => e.Pg)
                    .HasMaxLength(255)
                    .HasColumnName("pg");

                entity.Property(e => e.Plaziert)
                    .HasColumnType("datetime")
                    .HasColumnName("plaziert");

                entity.Property(e => e.Prod)
                    .HasMaxLength(255)
                    .HasColumnName("prod");

                entity.Property(e => e.Prod2)
                    .HasMaxLength(255)
                    .HasColumnName("prod2");

                entity.Property(e => e.Prod3)
                    .HasMaxLength(40)
                    .HasColumnName("prod3");

                entity.Property(e => e.Projekt)
                    .HasMaxLength(255)
                    .HasColumnName("projekt");

                entity.Property(e => e.Quali).HasColumnName("quali");

                entity.Property(e => e.Sachb)
                    .HasMaxLength(255)
                    .HasColumnName("sachb");

                entity.Property(e => e.Saison).HasMaxLength(6);

                entity.Property(e => e.Siegel).HasColumnName("siegel");

                entity.Property(e => e.Techniker).HasMaxLength(255);

                entity.Property(e => e.Ursprungslmeter)
                    .HasMaxLength(255)
                    .HasColumnName("ursprungslmeter");

                entity.Property(e => e.Us).HasColumnName("US $");

                entity.Property(e => e.VerschTermin).HasColumnName("Versch-Termin");

                entity.Property(e => e.Verschiff2)
                    .HasColumnType("datetime")
                    .HasColumnName("verschiff2");

                entity.Property(e => e.Verschmenge).HasColumnName("verschmenge");

                entity.Property(e => e.Vertreter).HasMaxLength(255);

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.Vkaud).HasColumnName("VKAUD");

                entity.Property(e => e.Vkbr).HasColumnName("VKbr");

                entity.Property(e => e.Vkgbp).HasColumnName("VKGBP");

                entity.Property(e => e.Vkkurs).HasColumnName("VKKurs");
            });

            modelBuilder.Entity<TabReportNachVertreterAccessDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tab_ReportNachVertreter_AccessData");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.ContEur).HasColumnName("Cont_EUR");

                entity.Property(e => e.ContPercent).HasColumnName("Cont_Percent");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreationDateNorm)
                    .HasColumnType("date")
                    .HasColumnName("CreationDate_Norm");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.DeliveryMonth).HasColumnName("Delivery_Month");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.DepartmentNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Department_Number");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryCity)
                    .HasMaxLength(255)
                    .HasColumnName("Factory_City");

                entity.Property(e => e.FactoryFixed).HasColumnName("Factory_Fixed");

                entity.Property(e => e.FactoryId).HasColumnName("Factory_ID");

                entity.Property(e => e.FxrateePurchasePrice).HasColumnName("FXRateePurchasePrice");

                entity.Property(e => e.KeyAccount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.OrderNumber).HasMaxLength(255);

                entity.Property(e => e.OrderstatusDeleted).HasColumnName("Orderstatus_Deleted");

                entity.Property(e => e.ProductGroup).HasMaxLength(255);

                entity.Property(e => e.PurchasePriceEur).HasColumnName("PurchasePrice_EUR");

                entity.Property(e => e.PurchasePriceFixed).HasColumnName("PurchasePrice_Fixed");

                entity.Property(e => e.PurchasePriceUsd).HasColumnName("PurchasePrice_USD");

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("date");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermOfDeliveryToGp)
                    .HasMaxLength(255)
                    .HasColumnName("TermOfDeliveryToGP");

                entity.Property(e => e.TitleDep)
                    .HasMaxLength(255)
                    .HasColumnName("Title_Dep");
            });

            modelBuilder.Entity<TaskInstancesEnquiry>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<TermsOfDelivery>(entity =>
            {
                entity.ToTable("TermsOfDelivery");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.KnownAs).HasColumnName("knownAs");
            });

            modelBuilder.Entity<UserPhoto>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPhotos)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserProductGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserProductGroup");

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eMail");

                entity.Property(e => e.GesperrtRls).HasColumnName("Gesperrt_RLS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroup).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Userprincipalname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserVertreter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserVertreter");

                entity.HasIndex(e => new { e.UserName, e.Vertreter }, "#idxUserVertreter")
                    .IsUnique()
                    .HasFillFactor((byte)80);

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eMail");

                entity.Property(e => e.GesperrtRls).HasColumnName("Gesperrt_RLS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Userprincipalname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<UserVertreterAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserVertreter_Alt");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<UserVertreterBackup20200915>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserVertreter_Backup20200915");

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eMail");

                entity.Property(e => e.GesperrtRls).HasColumnName("Gesperrt_RLS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Userprincipalname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<UserVertreterDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserVertreter_Delete");

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eMail");

                entity.Property(e => e.GesperrtRls).HasColumnName("Gesperrt_RLS");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Userprincipalname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VAgentsCapacity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AgentsCapacity");
            });

            modelBuilder.Entity<VAmxGetEnquiryItemByOrderId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_amx_GetEnquiryItemByOrderId");

                entity.Property(e => e.IdOrder).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<VAuftragsbestandZeitvergleich>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AuftragsbestandZeitvergleich");

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Produktgruppe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.UmsatzinEur).HasColumnName("UmsatzinEUR");

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VChefliste>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Chefliste");

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.BaKdI)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BaKdIi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdII");

                entity.Property(e => e.BaKdIii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdIII");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Daterstellt)
                    .HasColumnType("date")
                    .HasColumnName("daterstellt");

                entity.Property(e => e.Ek1).HasColumnName("EK 1");

                entity.Property(e => e.Ek2).HasColumnName("EK 2");

                entity.Property(e => e.Ek3).HasColumnName("EK 3");

                entity.Property(e => e.Ekrem).HasColumnName("EKREM");

                entity.Property(e => e.Erledigt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("erledigt");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Itemguid).HasColumnName("itemguid");

                entity.Property(e => e.Kdlt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kdlt");

                entity.Property(e => e.Kennzeichen)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kennzeichen");

                entity.Property(e => e.Kkplatz).HasColumnName("kkplatz");

                entity.Property(e => e.Kkus).HasColumnName("kkus");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Kurs).HasColumnType("money");

                entity.Property(e => e.Kw)
                    .HasMaxLength(255)
                    .HasColumnName("KW");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lbed1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbed2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbkontr).HasColumnName("lbkontr");

                entity.Property(e => e.Lc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LC");

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.LtBis)
                    .HasColumnType("datetime")
                    .HasColumnName("LT bis");

                entity.Property(e => e.LtVon)
                    .HasColumnType("datetime")
                    .HasColumnName("LT von");

                entity.Property(e => e.Menge2).HasColumnName("menge2");

                entity.Property(e => e.Mengeopt1).HasColumnName("mengeopt1");

                entity.Property(e => e.Mengeopt2).HasColumnName("mengeopt2");

                entity.Property(e => e.Order).HasMaxLength(510);

                entity.Property(e => e.Orig)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("orig");

                entity.Property(e => e.Pg)
                    .HasMaxLength(255)
                    .HasColumnName("pg");

                entity.Property(e => e.Plaziert)
                    .HasColumnType("datetime")
                    .HasColumnName("plaziert");

                entity.Property(e => e.Prod)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod");

                entity.Property(e => e.Prod2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod2");

                entity.Property(e => e.Prod3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod3");

                entity.Property(e => e.Projekt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("projekt");

                entity.Property(e => e.Quali)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("quali");

                entity.Property(e => e.Sachb)
                    .IsRequired()
                    .HasColumnName("sachb");

                entity.Property(e => e.Saison).HasMaxLength(255);

                entity.Property(e => e.Siegel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siegel");

                entity.Property(e => e.Techniker).IsRequired();

                entity.Property(e => e.Ursprungslmeter)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ursprungslmeter");

                entity.Property(e => e.Us).HasColumnName("US $");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VerschTermin)
                    .HasColumnType("datetime")
                    .HasColumnName("Versch-Termin");

                entity.Property(e => e.Verschiff2)
                    .HasColumnType("datetime")
                    .HasColumnName("verschiff2");

                entity.Property(e => e.Verschmenge).HasColumnName("verschmenge");

                entity.Property(e => e.Vertreter).HasMaxLength(255);

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.Vkaud).HasColumnName("VKAUD");

                entity.Property(e => e.Vkbr).HasColumnName("VKbr");

                entity.Property(e => e.Vkgbp).HasColumnName("VKGBP");

                entity.Property(e => e.Vkkurs).HasColumnName("VKKurs");
            });

            modelBuilder.Entity<VChefliste3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Chefliste3");

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.BaKdI)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BaKdIi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdII");

                entity.Property(e => e.BaKdIii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdIII");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Daterstellt)
                    .HasColumnType("date")
                    .HasColumnName("daterstellt");

                entity.Property(e => e.Ek1).HasColumnName("EK 1");

                entity.Property(e => e.Ek2).HasColumnName("EK 2");

                entity.Property(e => e.Ek3).HasColumnName("EK 3");

                entity.Property(e => e.Ekrem).HasColumnName("EKREM");

                entity.Property(e => e.Erledigt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("erledigt");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Itemguid).HasColumnName("itemguid");

                entity.Property(e => e.Kdlt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kdlt");

                entity.Property(e => e.Kennzeichen)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kennzeichen");

                entity.Property(e => e.Kkplatz).HasColumnName("kkplatz");

                entity.Property(e => e.Kkus).HasColumnName("kkus");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Kw)
                    .HasMaxLength(255)
                    .HasColumnName("KW");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lbed1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbed2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbkontr).HasColumnName("lbkontr");

                entity.Property(e => e.Lc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LC");

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.LtBis)
                    .HasColumnType("datetime")
                    .HasColumnName("LT bis");

                entity.Property(e => e.LtVon)
                    .HasColumnType("datetime")
                    .HasColumnName("LT von");

                entity.Property(e => e.Menge2).HasColumnName("menge2");

                entity.Property(e => e.Mengeopt1).HasColumnName("mengeopt1");

                entity.Property(e => e.Mengeopt2).HasColumnName("mengeopt2");

                entity.Property(e => e.Order).HasMaxLength(510);

                entity.Property(e => e.Orig)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("orig");

                entity.Property(e => e.Pg)
                    .HasMaxLength(255)
                    .HasColumnName("pg");

                entity.Property(e => e.Plaziert)
                    .HasColumnType("datetime")
                    .HasColumnName("plaziert");

                entity.Property(e => e.Prod)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod");

                entity.Property(e => e.Prod2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod2");

                entity.Property(e => e.Prod3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod3");

                entity.Property(e => e.Projekt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("projekt");

                entity.Property(e => e.Quali)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("quali");

                entity.Property(e => e.Sachb)
                    .IsRequired()
                    .HasColumnName("sachb");

                entity.Property(e => e.Saison).HasMaxLength(255);

                entity.Property(e => e.Siegel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siegel");

                entity.Property(e => e.Techniker).IsRequired();

                entity.Property(e => e.Ursprungslmeter)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ursprungslmeter");

                entity.Property(e => e.Us).HasColumnName("US $");

                entity.Property(e => e.VerschTermin)
                    .HasColumnType("datetime")
                    .HasColumnName("Versch-Termin");

                entity.Property(e => e.Verschiff2)
                    .HasColumnType("datetime")
                    .HasColumnName("verschiff2");

                entity.Property(e => e.Verschmenge).HasColumnName("verschmenge");

                entity.Property(e => e.Vertreter).HasMaxLength(255);

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.Vkaud).HasColumnName("VKAUD");

                entity.Property(e => e.Vkbr).HasColumnName("VKbr");

                entity.Property(e => e.Vkgbp).HasColumnName("VKGBP");

                entity.Property(e => e.Vkkurs).HasColumnName("VKKurs");
            });

            modelBuilder.Entity<VCheflistenSync>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CheflistenSync");

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.BaKdI)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BaKdIi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdII");

                entity.Property(e => e.BaKdIii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BaKdIII");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Daterstellt)
                    .HasColumnType("date")
                    .HasColumnName("daterstellt");

                entity.Property(e => e.Ek1).HasColumnName("EK 1");

                entity.Property(e => e.Ek2).HasColumnName("EK 2");

                entity.Property(e => e.Ek3).HasColumnName("EK 3");

                entity.Property(e => e.Ekrem).HasColumnName("EKREM");

                entity.Property(e => e.Erledigt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("erledigt");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Itemguid).HasColumnName("itemguid");

                entity.Property(e => e.Kdlt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kdlt");

                entity.Property(e => e.Kennzeichen)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("kennzeichen");

                entity.Property(e => e.Kkplatz).HasColumnName("kkplatz");

                entity.Property(e => e.Kkus).HasColumnName("kkus");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Kw)
                    .HasMaxLength(255)
                    .HasColumnName("KW");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lbed1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbed2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lbkontr).HasColumnName("lbkontr");

                entity.Property(e => e.Lc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LC");

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.LtBis)
                    .HasColumnType("datetime")
                    .HasColumnName("LT bis");

                entity.Property(e => e.LtVon)
                    .HasColumnType("datetime")
                    .HasColumnName("LT von");

                entity.Property(e => e.Menge2).HasColumnName("menge2");

                entity.Property(e => e.Mengeopt1).HasColumnName("mengeopt1");

                entity.Property(e => e.Mengeopt2).HasColumnName("mengeopt2");

                entity.Property(e => e.Order).HasMaxLength(510);

                entity.Property(e => e.Orig)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("orig");

                entity.Property(e => e.Pg)
                    .HasMaxLength(255)
                    .HasColumnName("pg");

                entity.Property(e => e.Plaziert)
                    .HasColumnType("datetime")
                    .HasColumnName("plaziert");

                entity.Property(e => e.Prod)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod");

                entity.Property(e => e.Prod2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod2");

                entity.Property(e => e.Prod3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prod3");

                entity.Property(e => e.Projekt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("projekt");

                entity.Property(e => e.Quali)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("quali");

                entity.Property(e => e.Sachb)
                    .IsRequired()
                    .HasColumnName("sachb");

                entity.Property(e => e.Saison).HasMaxLength(255);

                entity.Property(e => e.Siegel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siegel");

                entity.Property(e => e.Techniker).IsRequired();

                entity.Property(e => e.Ursprungslmeter)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ursprungslmeter");

                entity.Property(e => e.Us).HasColumnName("US $");

                entity.Property(e => e.VerschTermin)
                    .HasColumnType("datetime")
                    .HasColumnName("Versch-Termin");

                entity.Property(e => e.Verschiff2)
                    .HasColumnType("datetime")
                    .HasColumnName("verschiff2");

                entity.Property(e => e.Verschmenge).HasColumnName("verschmenge");

                entity.Property(e => e.Vertreter).HasMaxLength(255);

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.Vkaud).HasColumnName("VKAUD");

                entity.Property(e => e.Vkbr).HasColumnName("VKbr");

                entity.Property(e => e.Vkgbp).HasColumnName("VKGBP");

                entity.Property(e => e.Vkkurs).HasColumnName("VKKurs");
            });

            modelBuilder.Entity<VCreationDateAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CreationDateAccess");

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VCubeFactory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Cube_Factory");

                entity.Property(e => e.Anschrift)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Bscistatus)
                    .IsRequired()
                    .HasColumnName("BSCIStatus");

                entity.Property(e => e.Bscistatus2)
                    .IsRequired()
                    .HasColumnName("BSCIStatus2");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("eMail");

                entity.Property(e => e.FactoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Factory_ID");

                entity.Property(e => e.Land)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Stadt)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Typ).IsRequired();
            });

            modelBuilder.Entity<VCubeReportNachVertreter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Cube_ReportNachVertreter");

                entity.Property(e => e.Abteilung).HasMaxLength(255);

                entity.Property(e => e.Anlagedatum).HasColumnType("date");

                entity.Property(e => e.AnlagedatumNorm)
                    .HasColumnType("date")
                    .HasColumnName("Anlagedatum_Norm");

                entity.Property(e => e.ArticleNumberOfClient).HasMaxLength(255);

                entity.Property(e => e.Artikelbeschreibung).HasMaxLength(255);

                entity.Property(e => e.Auftragsnummer).HasMaxLength(511);

                entity.Property(e => e.AuslieferungBis)
                    .HasColumnType("date")
                    .HasColumnName("Auslieferung_Bis");

                entity.Property(e => e.AuslieferungVon)
                    .HasColumnType("date")
                    .HasColumnName("Auslieferung_Von");

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DatenBis...");

                entity.Property(e => e.Datenquelle)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EkEur).HasColumnName("EK_EUR");

                entity.Property(e => e.EkFw).HasColumnName("EK_FW");

                entity.Property(e => e.EkWechselkurs).HasColumnName("EK_Wechselkurs");

                entity.Property(e => e.EkWährung)
                    .HasMaxLength(255)
                    .HasColumnName("EK_Währung");

                entity.Property(e => e.FactoryId).HasColumnName("Factory_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Idorder)
                    .HasMaxLength(255)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.KeyAccount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Kostenstelle).HasMaxLength(255);

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.OrderstatusGelöscht).HasColumnName("Orderstatus_Gelöscht");

                entity.Property(e => e.PcsStat).HasColumnName("pcs_Stat");

                entity.Property(e => e.Produktgruppe).HasMaxLength(255);

                entity.Property(e => e.Saison).HasMaxLength(255);

                entity.Property(e => e.SaisonSortierung).HasColumnName("Saison_Sortierung");

                entity.Property(e => e.ShipName).HasMaxLength(255);

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDateRevised).HasColumnType("datetime");

                entity.Property(e => e.SupplierOrder)
                    .HasMaxLength(255)
                    .HasColumnName("Supplier_Order");

                entity.Property(e => e.SupplierRevisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.TermOfDeliveryToGp)
                    .HasMaxLength(255)
                    .HasColumnName("TermOfDeliveryToGP");

                entity.Property(e => e.Verschiffungsdatum).HasColumnType("date");

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.VkFw).HasColumnName("VK_FW");

                entity.Property(e => e.VkWechselkurs).HasColumnName("VK_Wechselkurs");

                entity.Property(e => e.VkWährung)
                    .HasMaxLength(255)
                    .HasColumnName("VK_Währung");
            });

            modelBuilder.Entity<VCubeReportNachVertreterNonUnique>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Cube_ReportNachVertreter_NonUnique");

                entity.Property(e => e.Abteilung).HasMaxLength(255);

                entity.Property(e => e.Anlagedatum).HasColumnType("date");

                entity.Property(e => e.AnlagedatumNorm)
                    .HasColumnType("date")
                    .HasColumnName("Anlagedatum_Norm");

                entity.Property(e => e.ArticleNumberOfClient).HasMaxLength(255);

                entity.Property(e => e.Artikelbeschreibung).HasMaxLength(255);

                entity.Property(e => e.Auftragsnummer).HasMaxLength(511);

                entity.Property(e => e.AuslieferungBis)
                    .HasColumnType("date")
                    .HasColumnName("Auslieferung_Bis");

                entity.Property(e => e.AuslieferungVon)
                    .HasColumnType("date")
                    .HasColumnName("Auslieferung_Von");

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DatenBis...");

                entity.Property(e => e.Datenquelle)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EkEur).HasColumnName("EK_EUR");

                entity.Property(e => e.EkFw).HasColumnName("EK_FW");

                entity.Property(e => e.EkWechselkurs).HasColumnName("EK_Wechselkurs");

                entity.Property(e => e.EkWährung)
                    .HasMaxLength(255)
                    .HasColumnName("EK_Währung");

                entity.Property(e => e.FactoryId).HasColumnName("Factory_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Idorder)
                    .HasMaxLength(255)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.KeyAccount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Kostenstelle).HasMaxLength(255);

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.OrderstatusGelöscht).HasColumnName("Orderstatus_Gelöscht");

                entity.Property(e => e.PcsStat).HasColumnName("pcs_Stat");

                entity.Property(e => e.Produktgruppe).HasMaxLength(255);

                entity.Property(e => e.Saison).HasMaxLength(255);

                entity.Property(e => e.SaisonSortierung).HasColumnName("Saison_Sortierung");

                entity.Property(e => e.ShipName).HasMaxLength(255);

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDateRevised).HasColumnType("datetime");

                entity.Property(e => e.SupplierOrder)
                    .HasMaxLength(255)
                    .HasColumnName("Supplier_Order");

                entity.Property(e => e.SupplierRevisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.TermOfDeliveryToGp)
                    .HasMaxLength(255)
                    .HasColumnName("TermOfDeliveryToGP");

                entity.Property(e => e.Verschiffungsdatum).HasColumnType("date");

                entity.Property(e => e.Vk).HasColumnName("VK");

                entity.Property(e => e.VkFw).HasColumnName("VK_FW");

                entity.Property(e => e.VkWechselkurs).HasColumnName("VK_Wechselkurs");

                entity.Property(e => e.VkWährung)
                    .HasMaxLength(255)
                    .HasColumnName("VK_Währung");
            });

            modelBuilder.Entity<VCubeSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Cube_Supplier");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDeliveryDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeliveryDate");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDpr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPR");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.Crd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(255);

                entity.Property(e => e.Cutting01).HasColumnName("Cutting_01");

                entity.Property(e => e.Cutting02).HasColumnName("Cutting_02");

                entity.Property(e => e.Cutting03).HasColumnName("Cutting_03");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.Eimodified)
                    .HasColumnType("datetime")
                    .HasColumnName("EIModified");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemsPacked01).HasColumnName("ItemsPacked_01");

                entity.Property(e => e.ItemsPacked02).HasColumnName("ItemsPacked_02");

                entity.Property(e => e.ItemsPacked03).HasColumnName("ItemsPacked_03");

                entity.Property(e => e.Knitting01).HasColumnName("Knitting_01");

                entity.Property(e => e.Knitting02).HasColumnName("Knitting_02");

                entity.Property(e => e.Knitting03).HasColumnName("Knitting_03");

                entity.Property(e => e.LastThree).HasMaxLength(3);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.OrderCreationDate).HasColumnType("datetime");

                entity.Property(e => e.OrderModified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrdernumberParent)
                    .HasMaxLength(776)
                    .HasColumnName("Ordernumber_Parent");

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProcurementQb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ProcurementQB");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Sewing01).HasColumnName("Sewing_01");

                entity.Property(e => e.Sewing02).HasColumnName("Sewing_02");

                entity.Property(e => e.Sewing03).HasColumnName("Sewing_03");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.Sort2)
                    .IsRequired()
                    .HasMaxLength(816);

                entity.Property(e => e.StatusAccessoriesDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsCompletedDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsShippedDate).HasColumnType("date");

                entity.Property(e => e.StatusCuttingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_01");

                entity.Property(e => e.StatusCuttingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_02");

                entity.Property(e => e.StatusCuttingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_03");

                entity.Property(e => e.StatusDailyOutputDate).HasColumnType("date");

                entity.Property(e => e.StatusDateOverall)
                    .HasColumnType("date")
                    .HasColumnName("StatusDate_Overall");

                entity.Property(e => e.StatusIroningDate).HasColumnType("date");

                entity.Property(e => e.StatusKnittingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_01");

                entity.Property(e => e.StatusKnittingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_02");

                entity.Property(e => e.StatusKnittingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_03");

                entity.Property(e => e.StatusLinesRunningDate).HasColumnType("date");

                entity.Property(e => e.StatusMotherVesselDate).HasColumnType("date");

                entity.Property(e => e.StatusPackeddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_01");

                entity.Property(e => e.StatusPackeddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_02");

                entity.Property(e => e.StatusPackeddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_03");

                entity.Property(e => e.StatusPcsSetDate).HasColumnType("date");

                entity.Property(e => e.StatusSewingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_01");

                entity.Property(e => e.StatusSewingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_02");

                entity.Property(e => e.StatusSewingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_03");

                entity.Property(e => e.StatusWashReceiveddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_01");

                entity.Property(e => e.StatusWashReceiveddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_02");

                entity.Property(e => e.StatusWashReceiveddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_03");

                entity.Property(e => e.StatusWashSentDate).HasColumnType("date");

                entity.Property(e => e.StatusZipperDate).HasColumnType("date");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermsOfDelivery).HasMaxLength(255);

                entity.Property(e => e.WashReceived01).HasColumnName("WashReceived_01");

                entity.Property(e => e.WashReceived02).HasColumnName("WashReceived_02");

                entity.Property(e => e.WashReceived03).HasColumnName("WashReceived_03");
            });

            modelBuilder.Entity<VDpr2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPR2");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.Crd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(255);

                entity.Property(e => e.Cutting01).HasColumnName("Cutting_01");

                entity.Property(e => e.Cutting02).HasColumnName("Cutting_02");

                entity.Property(e => e.Cutting03).HasColumnName("Cutting_03");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemsPacked01).HasColumnName("ItemsPacked_01");

                entity.Property(e => e.ItemsPacked02).HasColumnName("ItemsPacked_02");

                entity.Property(e => e.ItemsPacked03).HasColumnName("ItemsPacked_03");

                entity.Property(e => e.Knitting01).HasColumnName("Knitting_01");

                entity.Property(e => e.Knitting02).HasColumnName("Knitting_02");

                entity.Property(e => e.Knitting03).HasColumnName("Knitting_03");

                entity.Property(e => e.LastThree).HasMaxLength(3);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProcurementQb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ProcurementQB");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.Responsible)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Sewing01).HasColumnName("Sewing_01");

                entity.Property(e => e.Sewing02).HasColumnName("Sewing_02");

                entity.Property(e => e.Sewing03).HasColumnName("Sewing_03");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.Sort2)
                    .IsRequired()
                    .HasMaxLength(816);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermsOfDelivery).HasMaxLength(255);
            });

            modelBuilder.Entity<VDprBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPR_Backup");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.Crd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(255);

                entity.Property(e => e.Cutting01).HasColumnName("Cutting_01");

                entity.Property(e => e.Cutting02).HasColumnName("Cutting_02");

                entity.Property(e => e.Cutting03).HasColumnName("Cutting_03");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.Eimodified)
                    .HasColumnType("datetime")
                    .HasColumnName("EIModified");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemsPacked01).HasColumnName("ItemsPacked_01");

                entity.Property(e => e.ItemsPacked02).HasColumnName("ItemsPacked_02");

                entity.Property(e => e.ItemsPacked03).HasColumnName("ItemsPacked_03");

                entity.Property(e => e.Knitting01).HasColumnName("Knitting_01");

                entity.Property(e => e.Knitting02).HasColumnName("Knitting_02");

                entity.Property(e => e.Knitting03).HasColumnName("Knitting_03");

                entity.Property(e => e.LastThree).HasMaxLength(3);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.OrderCreationDate).HasColumnType("datetime");

                entity.Property(e => e.OrderModified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Sewing01).HasColumnName("Sewing_01");

                entity.Property(e => e.Sewing02).HasColumnName("Sewing_02");

                entity.Property(e => e.Sewing03).HasColumnName("Sewing_03");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAccessoriesDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsCompletedDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsShippedDate).HasColumnType("date");

                entity.Property(e => e.StatusCuttingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_01");

                entity.Property(e => e.StatusCuttingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_02");

                entity.Property(e => e.StatusCuttingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_03");

                entity.Property(e => e.StatusDailyOutputDate).HasColumnType("date");

                entity.Property(e => e.StatusIroningDate).HasColumnType("date");

                entity.Property(e => e.StatusKnittingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_01");

                entity.Property(e => e.StatusKnittingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_02");

                entity.Property(e => e.StatusKnittingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_03");

                entity.Property(e => e.StatusLinesRunningDate).HasColumnType("date");

                entity.Property(e => e.StatusMotherVesselDate).HasColumnType("date");

                entity.Property(e => e.StatusPackeddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_01");

                entity.Property(e => e.StatusPackeddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_02");

                entity.Property(e => e.StatusPackeddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_03");

                entity.Property(e => e.StatusPcsSetDate).HasColumnType("date");

                entity.Property(e => e.StatusSewingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_01");

                entity.Property(e => e.StatusSewingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_02");

                entity.Property(e => e.StatusSewingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_03");

                entity.Property(e => e.StatusWashReceiveddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_01");

                entity.Property(e => e.StatusWashReceiveddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_02");

                entity.Property(e => e.StatusWashReceiveddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_03");

                entity.Property(e => e.StatusWashSentDate).HasColumnType("date");

                entity.Property(e => e.StatusZipperDate).HasColumnType("date");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermsOfDelivery).HasMaxLength(255);

                entity.Property(e => e.WashReceived01).HasColumnName("WashReceived_01");

                entity.Property(e => e.WashReceived02).HasColumnName("WashReceived_02");

                entity.Property(e => e.WashReceived03).HasColumnName("WashReceived_03");
            });

            modelBuilder.Entity<VDprExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPR_Export");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerDeliveryDateTill).HasColumnType("datetime");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.FactoryGroup).HasMaxLength(255);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MainFactory).HasMaxLength(255);

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.OrderDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Order description");

                entity.Property(e => e.OrderNumber).HasMaxLength(510);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.Productgroup).HasMaxLength(255);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.Responsible)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RevisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Season).HasMaxLength(255);

                entity.Property(e => e.ShipmentDateRevised).HasColumnType("datetime");

                entity.Property(e => e.ShipmentOrig).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VDprqb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPRQB");

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.Dprqbid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DPRQBId");

                entity.Property(e => e.FabricsFrom).HasMaxLength(50);

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(100);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(100);

                entity.Property(e => e.Fri1Date).HasColumnType("date");

                entity.Property(e => e.Fri1Qty).HasColumnName("Fri1QTY");

                entity.Property(e => e.Fri1Result).HasMaxLength(50);

                entity.Property(e => e.Fri2Date).HasColumnType("date");

                entity.Property(e => e.Fri2Qty).HasColumnName("Fri2QTY");

                entity.Property(e => e.Fri2Result).HasMaxLength(50);

                entity.Property(e => e.Fri3Date).HasColumnType("date");

                entity.Property(e => e.Fri3Qty).HasColumnName("Fri3QTY");

                entity.Property(e => e.Fri3Result).HasMaxLength(50);

                entity.Property(e => e.Frilab)
                    .HasMaxLength(50)
                    .HasColumnName("FRILab");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SpshortResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPShortResult");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.TestingLab).HasMaxLength(50);
            });

            modelBuilder.Entity<VDprqbBi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPRQB_BI");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.Crd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(255);

                entity.Property(e => e.Cutting01).HasColumnName("Cutting_01");

                entity.Property(e => e.Cutting02).HasColumnName("Cutting_02");

                entity.Property(e => e.Cutting03).HasColumnName("Cutting_03");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.Dprqbid).HasColumnName("DPRQBId");

                entity.Property(e => e.Eimodified)
                    .HasColumnType("datetime")
                    .HasColumnName("EIModified");

                entity.Property(e => e.FabricsFrom).HasMaxLength(50);

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(100);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(100);

                entity.Property(e => e.Fri1Date).HasColumnType("date");

                entity.Property(e => e.Fri1Qty).HasColumnName("Fri1QTY");

                entity.Property(e => e.Fri1Result).HasMaxLength(50);

                entity.Property(e => e.Fri2Date).HasColumnType("date");

                entity.Property(e => e.Fri2Qty).HasColumnName("Fri2QTY");

                entity.Property(e => e.Fri2Result).HasMaxLength(50);

                entity.Property(e => e.Fri3Date).HasColumnType("date");

                entity.Property(e => e.Fri3Qty).HasColumnName("Fri3QTY");

                entity.Property(e => e.Fri3Result).HasMaxLength(50);

                entity.Property(e => e.Frilab)
                    .HasMaxLength(50)
                    .HasColumnName("FRILab");

                entity.Property(e => e.ItemsPacked01).HasColumnName("ItemsPacked_01");

                entity.Property(e => e.ItemsPacked02).HasColumnName("ItemsPacked_02");

                entity.Property(e => e.ItemsPacked03).HasColumnName("ItemsPacked_03");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.Knitting01).HasColumnName("Knitting_01");

                entity.Property(e => e.Knitting02).HasColumnName("Knitting_02");

                entity.Property(e => e.Knitting03).HasColumnName("Knitting_03");

                entity.Property(e => e.LastThree).HasMaxLength(3);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.MinDeliveryDateFromParent)
                    .HasColumnType("date")
                    .HasColumnName("MinDeliveryDateFrom_Parent");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrderCreationDate).HasColumnType("datetime");

                entity.Property(e => e.OrderModified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrdernumberParent)
                    .HasMaxLength(776)
                    .HasColumnName("Ordernumber_Parent");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ProcurementQb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ProcurementQB");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ReSamplePick).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Sewing01).HasColumnName("Sewing_01");

                entity.Property(e => e.Sewing02).HasColumnName("Sewing_02");

                entity.Property(e => e.Sewing03).HasColumnName("Sewing_03");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.Sort2)
                    .IsRequired()
                    .HasMaxLength(816);

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SpshortResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPShortResult");

                entity.Property(e => e.StatusAccessoriesDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsCompletedDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsShippedDate).HasColumnType("date");

                entity.Property(e => e.StatusCuttingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_01");

                entity.Property(e => e.StatusCuttingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_02");

                entity.Property(e => e.StatusCuttingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_03");

                entity.Property(e => e.StatusDailyOutputDate).HasColumnType("date");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.StatusDateOverall)
                    .HasColumnType("date")
                    .HasColumnName("StatusDate_Overall");

                entity.Property(e => e.StatusIroningDate).HasColumnType("date");

                entity.Property(e => e.StatusKnittingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_01");

                entity.Property(e => e.StatusKnittingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_02");

                entity.Property(e => e.StatusKnittingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_03");

                entity.Property(e => e.StatusLinesRunningDate).HasColumnType("date");

                entity.Property(e => e.StatusMotherVesselDate).HasColumnType("date");

                entity.Property(e => e.StatusPackeddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_01");

                entity.Property(e => e.StatusPackeddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_02");

                entity.Property(e => e.StatusPackeddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_03");

                entity.Property(e => e.StatusPcsSetDate).HasColumnType("date");

                entity.Property(e => e.StatusSewingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_01");

                entity.Property(e => e.StatusSewingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_02");

                entity.Property(e => e.StatusSewingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_03");

                entity.Property(e => e.StatusWashReceiveddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_01");

                entity.Property(e => e.StatusWashReceiveddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_02");

                entity.Property(e => e.StatusWashReceiveddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_03");

                entity.Property(e => e.StatusWashSentDate).HasColumnType("date");

                entity.Property(e => e.StatusZipperDate).HasColumnType("date");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermsOfDelivery).HasMaxLength(255);

                entity.Property(e => e.TestingLab).HasMaxLength(50);

                entity.Property(e => e.WashReceived01).HasColumnName("WashReceived_01");

                entity.Property(e => e.WashReceived02).HasColumnName("WashReceived_02");

                entity.Property(e => e.WashReceived03).HasColumnName("WashReceived_03");
            });

            modelBuilder.Entity<VDprqbBiDev>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPRQB_BI_dev");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.Crd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRD");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(255);

                entity.Property(e => e.Cutting01).HasColumnName("Cutting_01");

                entity.Property(e => e.Cutting02).HasColumnName("Cutting_02");

                entity.Property(e => e.Cutting03).HasColumnName("Cutting_03");

                entity.Property(e => e.DateDiffPlannedActual).HasColumnName("DateDiff_Planned_Actual");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.Dprqbid).HasColumnName("DPRQBId");

                entity.Property(e => e.Eimodified)
                    .HasColumnType("datetime")
                    .HasColumnName("EIModified");

                entity.Property(e => e.FabricsFrom).HasMaxLength(50);

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.FilterRelevant)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Filter_Relevant");

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(100);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(100);

                entity.Property(e => e.Fri1Date).HasColumnType("date");

                entity.Property(e => e.Fri1Qty).HasColumnName("Fri1QTY");

                entity.Property(e => e.Fri1Result).HasMaxLength(50);

                entity.Property(e => e.Fri2Date).HasColumnType("date");

                entity.Property(e => e.Fri2Qty).HasColumnName("Fri2QTY");

                entity.Property(e => e.Fri2Result).HasMaxLength(50);

                entity.Property(e => e.Fri3Date).HasColumnType("date");

                entity.Property(e => e.Fri3Qty).HasColumnName("Fri3QTY");

                entity.Property(e => e.Fri3Result).HasMaxLength(50);

                entity.Property(e => e.Frilab)
                    .HasMaxLength(50)
                    .HasColumnName("FRILab");

                entity.Property(e => e.ItemsPacked01).HasColumnName("ItemsPacked_01");

                entity.Property(e => e.ItemsPacked02).HasColumnName("ItemsPacked_02");

                entity.Property(e => e.ItemsPacked03).HasColumnName("ItemsPacked_03");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.Knitting01).HasColumnName("Knitting_01");

                entity.Property(e => e.Knitting02).HasColumnName("Knitting_02");

                entity.Property(e => e.Knitting03).HasColumnName("Knitting_03");

                entity.Property(e => e.LastThree).HasMaxLength(3);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.MinDeliveryDateFromParent)
                    .HasColumnType("date")
                    .HasColumnName("MinDeliveryDateFrom_Parent");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrderCreationDate).HasColumnType("datetime");

                entity.Property(e => e.OrderModified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrdernumberParent)
                    .HasMaxLength(776)
                    .HasColumnName("Ordernumber_Parent");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ProcurementQb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ProcurementQB");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ReSamplePick).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Sewing01).HasColumnName("Sewing_01");

                entity.Property(e => e.Sewing02).HasColumnName("Sewing_02");

                entity.Property(e => e.Sewing03).HasColumnName("Sewing_03");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.Sort)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.Sort2)
                    .IsRequired()
                    .HasMaxLength(816);

                entity.Property(e => e.SortParentAndDeliveryDate).HasMaxLength(1056);

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SpshortResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPShortResult");

                entity.Property(e => e.StatusAccessoriesDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsCompletedDate).HasColumnType("date");

                entity.Property(e => e.StatusCartonsShippedDate).HasColumnType("date");

                entity.Property(e => e.StatusCuttingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_01");

                entity.Property(e => e.StatusCuttingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_02");

                entity.Property(e => e.StatusCuttingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusCuttingdate_03");

                entity.Property(e => e.StatusDailyOutputDate).HasColumnType("date");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.StatusDateOverall)
                    .HasColumnType("date")
                    .HasColumnName("StatusDate_Overall");

                entity.Property(e => e.StatusIroningDate).HasColumnType("date");

                entity.Property(e => e.StatusKnittingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_01");

                entity.Property(e => e.StatusKnittingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_02");

                entity.Property(e => e.StatusKnittingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusKnittingdate_03");

                entity.Property(e => e.StatusLinesRunningDate).HasColumnType("date");

                entity.Property(e => e.StatusMotherVesselDate).HasColumnType("date");

                entity.Property(e => e.StatusPackeddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_01");

                entity.Property(e => e.StatusPackeddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_02");

                entity.Property(e => e.StatusPackeddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusPackeddate_03");

                entity.Property(e => e.StatusPcsSetDate).HasColumnType("date");

                entity.Property(e => e.StatusSewingdate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_01");

                entity.Property(e => e.StatusSewingdate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_02");

                entity.Property(e => e.StatusSewingdate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusSewingdate_03");

                entity.Property(e => e.StatusWashReceiveddate01)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_01");

                entity.Property(e => e.StatusWashReceiveddate02)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_02");

                entity.Property(e => e.StatusWashReceiveddate03)
                    .HasColumnType("date")
                    .HasColumnName("StatusWashReceiveddate_03");

                entity.Property(e => e.StatusWashSentDate).HasColumnType("date");

                entity.Property(e => e.StatusZipperDate).HasColumnType("date");

                entity.Property(e => e.Sub03KeyAccounter)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_03_KeyAccounter");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermsOfDelivery).HasMaxLength(255);

                entity.Property(e => e.TestingLab).HasMaxLength(50);

                entity.Property(e => e.WashReceived01).HasColumnName("WashReceived_01");

                entity.Property(e => e.WashReceived02).HasColumnName("WashReceived_02");

                entity.Property(e => e.WashReceived03).HasColumnName("WashReceived_03");
            });

            modelBuilder.Entity<VDprqbLast>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPRQB_Last");

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.Dprqbid).HasColumnName("DPRQBId");

                entity.Property(e => e.FabricsFrom).HasMaxLength(50);

                entity.Property(e => e.ForwarderDelivery).HasMaxLength(100);

                entity.Property(e => e.ForwarderFreight).HasMaxLength(100);

                entity.Property(e => e.Fri1Date).HasColumnType("date");

                entity.Property(e => e.Fri1Qty).HasColumnName("Fri1QTY");

                entity.Property(e => e.Fri1Result).HasMaxLength(50);

                entity.Property(e => e.Fri2Date).HasColumnType("date");

                entity.Property(e => e.Fri2Qty).HasColumnName("Fri2QTY");

                entity.Property(e => e.Fri2Result).HasMaxLength(50);

                entity.Property(e => e.Fri3Date).HasColumnType("date");

                entity.Property(e => e.Fri3Qty).HasColumnName("Fri3QTY");

                entity.Property(e => e.Fri3Result).HasMaxLength(50);

                entity.Property(e => e.Frilab)
                    .HasMaxLength(50)
                    .HasColumnName("FRILab");

                entity.Property(e => e.KnitWoven).HasMaxLength(50);

                entity.Property(e => e.MerchandiserSupplier).HasMaxLength(255);

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ReSamplePick).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.SpfinalResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPFinalResult");

                entity.Property(e => e.SpshortResult)
                    .HasMaxLength(50)
                    .HasColumnName("SPShortResult");

                entity.Property(e => e.StatusDate).HasColumnType("date");

                entity.Property(e => e.TestingLab).HasMaxLength(50);
            });

            modelBuilder.Entity<VDprqbLastTimeline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DPRQB_Last_Timeline");

                entity.Property(e => e.BlreceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("BLReceivedDate");

                entity.Property(e => e.CdExDate).HasColumnType("date");

                entity.Property(e => e.CustomerDeliveryDateFrom).HasColumnType("datetime");

                entity.Property(e => e.CustomerDeliveryDateTill).HasColumnType("datetime");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.NewSamplePickDate)
                    .HasColumnType("date")
                    .HasColumnName("newSamplePickDate");

                entity.Property(e => e.OnSaleDate).HasColumnType("date");

                entity.Property(e => e.OrigSamplePickDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleDueDate).HasColumnType("date");

                entity.Property(e => e.PhotoSampleRevisedDate).HasColumnType("date");

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ReportAldiDate).HasColumnType("date");

                entity.Property(e => e.RevisedEta)
                    .HasColumnType("date")
                    .HasColumnName("revisedETA");

                entity.Property(e => e.RevisedEtd)
                    .HasColumnType("date")
                    .HasColumnName("revisedETD");

                entity.Property(e => e.ShipmentDateOriginal).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDateRevised).HasColumnType("datetime");

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VEkinEuro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_EKInEuro");

                entity.Property(e => e.Ekeuro).HasColumnName("EKEURO");

                entity.Property(e => e.Ekusd).HasColumnName("EKUSD");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VFactoriesForOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FactoriesForOrders");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.Idorder)
                    .HasMaxLength(510)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.T1).HasMaxLength(255);
            });

            modelBuilder.Entity<VFactoriesForOrders2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FactoriesForOrders2");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.Idorder)
                    .HasMaxLength(510)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.T1).HasMaxLength(255);
            });

            modelBuilder.Entity<VFactoriesForOrders2Backup202105>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FactoriesForOrders2_backup_202105");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.Idorder)
                    .HasMaxLength(510)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.T1).HasMaxLength(255);
            });

            modelBuilder.Entity<VFactoriesForOrdersWithSeason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FactoriesForOrdersWithSeason");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.Idorder)
                    .HasMaxLength(510)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.T1).HasMaxLength(255);
            });

            modelBuilder.Entity<VFactoryConnectionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_FactoryConnectionTypes");

                entity.Property(e => e.IdTypeOfFactoryInvolvementId).HasMaxLength(255);
            });

            modelBuilder.Entity<VOrdernumberParent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Ordernumber_Parent");

                entity.Property(e => e.AldipurchOrga)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALDIPurchOrga");

                entity.Property(e => e.AnzahlAufträgeImParent).HasColumnName("AnzahlAufträgeIm_Parent");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.MinDeliveryDateFromParent)
                    .HasColumnType("date")
                    .HasColumnName("MinDeliveryDateFrom_Parent");

                entity.Property(e => e.OrderIdDwh).HasColumnName("OrderID_DWH");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrdernumberParent)
                    .HasMaxLength(776)
                    .HasColumnName("Ordernumber_Parent");

                entity.Property(e => e.Part01Season)
                    .HasMaxLength(255)
                    .HasColumnName("Part01_Season");

                entity.Property(e => e.Part02Customer)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Part02_Customer");

                entity.Property(e => e.Part03Order)
                    .HasMaxLength(511)
                    .HasColumnName("Part03_Order");

                entity.Property(e => e.Sub03KeyAccounter)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_03_KeyAccounter");
            });

            modelBuilder.Entity<VOrdernumberParent202104>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Ordernumber_Parent_2021_04");

                entity.Property(e => e.AldipurchOrga)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALDIPurchOrga");

                entity.Property(e => e.AnzahlAufträgeImParent).HasColumnName("AnzahlAufträgeIm_Parent");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.MinDeliveryDateFromParent)
                    .HasColumnType("date")
                    .HasColumnName("MinDeliveryDateFrom_Parent");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrdernumberParent)
                    .HasMaxLength(776)
                    .HasColumnName("Ordernumber_Parent");

                entity.Property(e => e.Part01Season)
                    .HasMaxLength(255)
                    .HasColumnName("Part01_Season");

                entity.Property(e => e.Part02Customer)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Part02_Customer");

                entity.Property(e => e.Part03Order)
                    .HasMaxLength(511)
                    .HasColumnName("Part03_Order");

                entity.Property(e => e.Sub03KeyAccounter)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_03_KeyAccounter");
            });

            modelBuilder.Entity<VOrdersPerFactory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_OrdersPerFactories");

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.BsciDatabaseId).HasColumnType("text");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Country2).HasMaxLength(255);

                entity.Property(e => e.FactoryConnection).HasMaxLength(255);

                entity.Property(e => e.FactoryTitle).HasMaxLength(255);

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.Ltbis)
                    .HasColumnType("datetime")
                    .HasColumnName("LTBis");

                entity.Property(e => e.OrderId).HasMaxLength(510);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VProcurementQb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProcurementQB");

                entity.Property(e => e.ResponsibleQb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ResponsibleQB");
            });

            modelBuilder.Entity<VProductStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatus");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.Ordernumber).HasMaxLength(255);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.QcResponsible)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("QC_Responsible");

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusAccessory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusAccessories");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusCartonsCompleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusCartonsCompleted");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusCartonsShipped>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusCartonsShipped");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusCutting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusCutting");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusDailyOutput>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusDailyOutput");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusFabricEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusFabricEx");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusFabricInhouseStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusFabricInhouseStatus");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusIroning>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusIroning");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusItemsPacked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusItemsPacked");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusKnitting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusKnitting");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusLinesRunning>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusLinesRunning");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusMotherVessel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusMotherVessel");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusPcsSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusPCsSet");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusProductionStart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusProductionStart");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusSewing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusSewing");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusWashReceived>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusWashReceived");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusWashSent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusWashSent");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProductStatusZipper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProductStatusZipper");

                entity.Property(e => e.FabricEx).HasColumnType("date");

                entity.Property(e => e.MotherVessel).HasMaxLength(1024);

                entity.Property(e => e.PcsSet).HasMaxLength(50);

                entity.Property(e => e.ProductionStart).HasColumnType("date");

                entity.Property(e => e.ProductionStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusDate).HasColumnType("date");
            });

            modelBuilder.Entity<VQcBd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_QC_BD");

                entity.Property(e => e.Responsible)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VReportAnschlussLaenderNord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportAnschlussLaenderNord");

                entity.Property(e => e.AldiNordId).HasMaxLength(255);

                entity.Property(e => e.AnschlussId)
                    .HasMaxLength(255)
                    .HasColumnName("AnschlussID");

                entity.Property(e => e.ArticleNumberClient).HasMaxLength(255);

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.Client).HasMaxLength(255);

                entity.Property(e => e.DeliveryDateAnschlussFrom).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateAnschlussTo).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateNordFrom).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateNordTo).HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.Etd)
                    .HasColumnType("datetime")
                    .HasColumnName("ETD");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.Kundenliefertermin).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Short).HasMaxLength(3);

                entity.Property(e => e.WebTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportAuftragsbestandNachAbtUndProdGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportAuftragsbestandNachAbtUndProdGroup");

                entity.Property(e => e.Abteilung).HasMaxLength(100);

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.Dbpercent).HasColumnName("DBPercent");
            });

            modelBuilder.Entity<VReportAuftragsvolumenNachMonat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportAuftragsvolumenNachMonat");

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.DeliveryMonth).HasMaxLength(30);

                entity.Property(e => e.Ekusd).HasColumnName("EKUSD");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.UmsatzinEur).HasColumnName("UmsatzinEUR");

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportBySeason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportBySeason");

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.Ekusd).HasColumnName("EKUSD");

                entity.Property(e => e.Gst).HasColumnName("GSt");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Produktgruppe).HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Usdollar).HasColumnName("USDollar");

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportGesamtuebersichtAuftragsbestand>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportGesamtuebersichtAuftragsbestand");

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Season).HasMaxLength(100);

                entity.Property(e => e.Vertreter).HasMaxLength(100);

                entity.Property(e => e.Year).HasMaxLength(2);
            });

            modelBuilder.Entity<VReportJahrAbtProdGr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportJahrAbtProdGr");

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.Year).HasMaxLength(2);
            });

            modelBuilder.Entity<VReportLieferantenVoluman>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportLieferantenVolumen");

                entity.Property(e => e.AgentenName).HasMaxLength(100);

                entity.Property(e => e.EkvolInTeuro).HasColumnName("EKVolInTEURO");

                entity.Property(e => e.StckInTsd).HasColumnName("StckInTSD");

                entity.Property(e => e.UmsatzInTeuro).HasColumnName("UmsatzInTEURO");
            });

            modelBuilder.Entity<VReportNachFactoryGroupAndFactory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachFactoryGroupAndFactory");

                entity.Property(e => e.AdditionalCode).HasMaxLength(255);

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.DeliveryDate)
                    .IsRequired()
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverySort).HasColumnType("datetime");

                entity.Property(e => e.Ekfixed).HasColumnName("EKFixed");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.Fabrik).HasMaxLength(255);

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.Produktgruppe).HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.T1).HasMaxLength(255);

                entity.Property(e => e.TermsOfDeliveryToGp).HasMaxLength(255);

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportNachVertreerOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreer_Overview");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DataUsername)
                    .HasMaxLength(128)
                    .HasColumnName("Data_Username");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("[DatenBis...]");

                entity.Property(e => e.Productgroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VReportNachVertrerOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertrer_Overview");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DataUsername)
                    .HasMaxLength(128)
                    .HasColumnName("Data_Username");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("[DatenBis...]");

                entity.Property(e => e.Productgroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VReportNachVertreter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.Dbpercent).HasColumnName("DBPercent");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.Ek).HasColumnName("EK");

                entity.Property(e => e.Ekfixed).HasColumnName("EKFixed");

                entity.Property(e => e.Ekusd).HasColumnName("EKUSD");

                entity.Property(e => e.Fabrik).HasMaxLength(255);

                entity.Property(e => e.Gst).HasColumnName("GSt");

                entity.Property(e => e.Kunde).HasMaxLength(255);

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.Produktgruppe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("date");

                entity.Property(e => e.TermsOfDeliveryToGp).HasMaxLength(255);

                entity.Property(e => e.UmsatzinEur).HasColumnName("UmsatzinEUR");

                entity.Property(e => e.Usdollar).HasColumnName("USDollar");

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportNachVertreterAufbereitenSharepoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter_Aufbereiten_Sharepoint");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.ContEur).HasColumnName("Cont_EUR");

                entity.Property(e => e.ContPercent).HasColumnName("Cont_Percent");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreationDateNorm)
                    .HasColumnType("date")
                    .HasColumnName("CreationDate_Norm");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DatenBis...");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.DeliveryMonth).HasColumnName("Delivery_Month");

                entity.Property(e => e.DeliveryYearRelativeToSeason)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Delivery_Year_RelativeToSeason");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.DepartmentNumber)
                    .HasMaxLength(1)
                    .HasColumnName("Department_Number");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryCity)
                    .HasMaxLength(255)
                    .HasColumnName("Factory_City");

                entity.Property(e => e.FactoryFixed).HasColumnName("Factory_Fixed");

                entity.Property(e => e.FactoryId).HasColumnName("Factory_ID");

                entity.Property(e => e.FxrateePurchasePrice).HasColumnName("FXRateePurchasePrice");

                entity.Property(e => e.KeyAccount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.OrderIdDwh).HasColumnName("OrderID_DWH");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrderstatusDeleted).HasColumnName("Orderstatus_Deleted");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasePriceEur).HasColumnName("PurchasePrice_EUR");

                entity.Property(e => e.PurchasePriceFixed).HasColumnName("PurchasePrice_Fixed");

                entity.Property(e => e.PurchasePriceUsd).HasColumnName("PurchasePrice_USD");

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("date");

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermOfDeliveryToGp)
                    .HasMaxLength(255)
                    .HasColumnName("TermOfDeliveryToGP");

                entity.Property(e => e.TitleDep)
                    .HasMaxLength(255)
                    .HasColumnName("Title_Dep");
            });

            modelBuilder.Entity<VReportNachVertreterCumulatedFal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter_Cumulated_FAL");

                entity.Property(e => e.KwNorm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KW_Norm");

                entity.Property(e => e.RevenueCum).HasColumnName("Revenue_Cum");

                entity.Property(e => e.SeasonShort)
                    .HasMaxLength(2)
                    .HasColumnName("Season_Short");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportNachVertreterFal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter_FAL");

                entity.Property(e => e.ArticleDescription).HasMaxLength(255);

                entity.Property(e => e.ContEur).HasColumnName("Cont_EUR");

                entity.Property(e => e.ContPercent).HasColumnName("Cont_Percent");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreationDateNorm)
                    .HasColumnType("date")
                    .HasColumnName("CreationDate_Norm");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DataUsername)
                    .HasMaxLength(128)
                    .HasColumnName("Data_Username");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DatenBis...");

                entity.Property(e => e.DeliveryDateFrom).HasColumnType("date");

                entity.Property(e => e.DeliveryDateTo).HasColumnType("date");

                entity.Property(e => e.DeliveryMonth).HasColumnName("Delivery_Month");

                entity.Property(e => e.DeliveryYearRelativeToSeason)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Delivery_Year_RelativeToSeason");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.DepartmentNumber)
                    .HasMaxLength(1)
                    .HasColumnName("Department_Number");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryCity)
                    .HasMaxLength(255)
                    .HasColumnName("Factory_City");

                entity.Property(e => e.FactoryFixed).HasColumnName("Factory_Fixed");

                entity.Property(e => e.FactoryId).HasColumnName("Factory_ID");

                entity.Property(e => e.FxrateePurchasePrice).HasColumnName("FXRateePurchasePrice");

                entity.Property(e => e.KeyAccount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lcstate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("LCState");

                entity.Property(e => e.Lctyp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LCTyp");

                entity.Property(e => e.OrderIdDwh).HasColumnName("OrderID_DWH");

                entity.Property(e => e.OrderNumber).HasMaxLength(511);

                entity.Property(e => e.OrderstatusDeleted).HasColumnName("Orderstatus_Deleted");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasePriceEur).HasColumnName("PurchasePrice_EUR");

                entity.Property(e => e.PurchasePriceFixed).HasColumnName("PurchasePrice_Fixed");

                entity.Property(e => e.PurchasePriceUsd).HasColumnName("PurchasePrice_USD");

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("date");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.TermOfDeliveryToGp)
                    .HasMaxLength(255)
                    .HasColumnName("TermOfDeliveryToGP");

                entity.Property(e => e.TitleDep)
                    .HasMaxLength(255)
                    .HasColumnName("Title_Dep");
            });

            modelBuilder.Entity<VReportNachVertreterGruppiert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreterGruppiert");

                entity.Property(e => e.Db).HasColumnName("DB");

                entity.Property(e => e.PrevDb).HasColumnName("PrevDB");

                entity.Property(e => e.Produktgruppe).HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.UmsatzinEur).HasColumnName("UmsatzinEUR");

                entity.Property(e => e.Vertreter).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportNachVertreterKundenGruppe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter_KundenGruppe");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.KundeGruppe)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Kunde_Gruppe");

                entity.Property(e => e.KundeGruppeShort)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Kunde_Gruppe_Short");
            });

            modelBuilder.Entity<VReportNachVertreterOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNachVertreter_Overview");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreationDateNorm)
                    .HasColumnType("date")
                    .HasColumnName("CreationDate_Norm");

                entity.Property(e => e.DataAsOf).HasColumnType("datetime");

                entity.Property(e => e.DataUsername)
                    .HasMaxLength(128)
                    .HasColumnName("Data_Username");

                entity.Property(e => e.DatenBis)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("[DatenBis...]");

                entity.Property(e => e.Productgroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RevEur).HasColumnName("Rev_EUR");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VReportNordOrdersWithAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportNordOrdersWithAttachment");

                entity.Property(e => e.AldiNordId).HasMaxLength(510);

                entity.Property(e => e.AnschlussId)
                    .HasMaxLength(255)
                    .HasColumnName("AnschlussID");

                entity.Property(e => e.ArticleNumberClient).HasMaxLength(255);

                entity.Property(e => e.Artikel).HasMaxLength(255);

                entity.Property(e => e.Client).HasMaxLength(255);

                entity.Property(e => e.DeliveryDateAnschlussFrom).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateAnschlussTo).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateNordFrom).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateNordTo).HasColumnType("datetime");

                entity.Property(e => e.DuProDate).HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.Etd)
                    .HasColumnType("datetime")
                    .HasColumnName("ETD");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.FabricDate).HasColumnType("datetime");

                entity.Property(e => e.Factory).HasMaxLength(255);

                entity.Property(e => e.FactoryAnschluss).HasMaxLength(255);

                entity.Property(e => e.Kombi).HasMaxLength(255);

                entity.Property(e => e.Kombinationen).IsUnicode(false);

                entity.Property(e => e.Laboratory).HasMaxLength(255);

                entity.Property(e => e.Lieferant).HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Short).HasMaxLength(3);

                entity.Property(e => e.T1).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportOrdersByDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportOrdersByDate");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.ProductLineId)
                    .HasMaxLength(255)
                    .HasColumnName("ProductLineID");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.QtyEkeur).HasColumnName("QtyEKEUR");

                entity.Property(e => e.QtyEkusd).HasColumnName("QtyEKUSD");
            });

            modelBuilder.Entity<VReportPriceNotFilled>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportPriceNotFilled");

                entity.Property(e => e.OrderId).HasMaxLength(510);

                entity.Property(e => e.OrderShort).HasMaxLength(3);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.WebTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<VReportShipmentDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ReportShipmentDates");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate2).HasColumnType("datetime");

                entity.Property(e => e.Fabrikgruppe).HasMaxLength(255);

                entity.Property(e => e.IdOrder).HasMaxLength(255);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(510)
                    .HasColumnName("OrderID");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<VSeasonsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SeasonsAll");

                entity.Property(e => e.Saison)
                    .HasMaxLength(255)
                    .HasColumnName("saison");
            });

            modelBuilder.Entity<VSeasonsWithOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SeasonsWithOrder");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VSeasonsWithOrderLongHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SeasonsWithOrder_LongHistory");

                entity.Property(e => e.FilterSharepointData).HasColumnName("Filter_SharepointData");

                entity.Property(e => e.Season).HasMaxLength(2);

                entity.Property(e => e.SeasonSort).HasColumnName("Season_Sort");

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Year).HasMaxLength(2);

                entity.Property(e => e.YearLong)
                    .HasMaxLength(4)
                    .HasColumnName("Year_Long");

                entity.Property(e => e.YearSeason)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VShipmentDateRevicedOrOriginal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ShipmentDateRevicedOrOriginal");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VUseFactoryForEmptyAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UseFactoryForEmptyAgents");

                entity.Property(e => e.Land).HasMaxLength(255);

                entity.Property(e => e.Lieferant).HasMaxLength(255);
            });

            modelBuilder.Entity<VUseFactoryForEmptyAgentsAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UseFactoryForEmptyAgents_Access");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.OrderNumber).HasMaxLength(255);

                entity.Property(e => e.SeasonTitle).HasMaxLength(255);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<VwRmgproduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RMGProduction");

                entity.Property(e => e.FactoryTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdTypeOfFactoryInvolvementId).HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WeAndWa>(entity =>
            {
                entity.HasIndex(e => e.OrderGroupId, "IX_WeAndWas_OrderGroupId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.OrderId, "IX_WeAndWas_OrderId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GoodsReceivedorIssued).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.OrderGroup)
                    .WithMany(p => p.WeAndWas)
                    .HasForeignKey(d => d.OrderGroupId)
                    .HasConstraintName("FK_WeAndWas_OrderGroups");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.WeAndWas)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_WeAndWas_Orders");
            });

            modelBuilder.Entity<WorkingArea>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<XSpEnquiry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("X_SP_Enquiries");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<XSpEnquiryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("X_SP_EnquiryItems");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<XSpOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("X_SP_Orders");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.WebTitle).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
