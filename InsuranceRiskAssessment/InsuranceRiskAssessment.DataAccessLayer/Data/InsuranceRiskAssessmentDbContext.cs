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
        {

        }

        DbSet<AirTransport> AirTransports { get; set; }
        DbSet<SeaTransport> SeaTransports { get; set; }
        DbSet<VehicleByLand> VehiclesByLand { get; set; }
        DbSet<BusinessEnterprise> BusinessEnterprises { get; set; }
        DbSet<CommercialProperty> CommercialProperties { get; set; }
        DbSet<ResidentialBuilding> ResidentialBuildings { get; set; }
        DbSet<VillaBuilding> VillaBuildings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
