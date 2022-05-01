using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InsuranceRiskAssessment.DataAccessLayer.Data
{
    public class InsuranceRiskAssessmentDbContext : IdentityDbContext<InsuranceBrokerUser>
    {
        public InsuranceRiskAssessmentDbContext(DbContextOptions<InsuranceRiskAssessmentDbContext> options)
            : base(options)
        { }
        public DbSet<AirTransport> AirTransports { get; set; }
        public DbSet<SeaTransport> SeaTransports { get; set; }
        public DbSet<VehicleByLand> VehiclesByLand { get; set; }
        public DbSet<BusinessEnterprise> BusinessEnterprises { get; set; }
        public DbSet<CommercialProperty> CommercialProperties { get; set; }
        public DbSet<ResidentialBuilding> ResidentialBuildings { get; set; }
        public DbSet<VillaBuilding> VillaBuildings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
