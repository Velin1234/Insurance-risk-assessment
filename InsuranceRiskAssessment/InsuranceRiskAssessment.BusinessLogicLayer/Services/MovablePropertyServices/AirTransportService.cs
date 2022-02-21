using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.MovablePropertyServices
{
    public class AirTransportService : IAirTransportService
    {
        public readonly IRepository<AirTransport> _airTransportRepository;
        public AirTransportService(IRepository<AirTransport> airTransportRepository)
        {
            _airTransportRepository = airTransportRepository;
        }
        public bool CreateAirTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, int distanceTraveled,
            double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, string functionality)
        {
            var airTransport = new AirTransport()
            {
                ManifactureYear = manifactureYear,
                SecurityEquipmenPossession = securityEquipmenPossession,
                TechnicalServiceability = technicalServiceability,
                DistanceTraveled = distanceTraveled,
                Height = height,
                Weight = weight,
                Width = width,
                RegisteredCountry = registeredCountry,
                RegisteredRegion = registeredRegion,
                RegisteredCity = registeredCity,
                ClimatZone = climatZone,
                Functionality = functionality
            };
            return _airTransportRepository.Create(airTransport);
        }

        public AirTransport GetAirTransportById(int airTransportId)
        {
            return _airTransportRepository.GetById(airTransportId);
        }

        public List<AirTransport> GetAirTransports()
        {
            return _airTransportRepository.GetAll();
        }

        public bool Remove(int airTransportId)
        {
            return _airTransportRepository.RemoveById(airTransportId);
        }

        public bool UpdateAirTransport(int airTransportId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, string functionality)
        {
            var airTransport = GetAirTransportById(airTransportId);
            if (airTransport == default(AirTransport))
            {
                return false;
            }

            airTransport.ManifactureYear = manifactureYear;
            airTransport.SecurityEquipmenPossession = securityEquipmenPossession;
            airTransport.TechnicalServiceability = technicalServiceability;
            airTransport.DistanceTraveled = distanceTraveled;
            airTransport.Height = height;
            airTransport.Weight = weight;
            airTransport.Width = width;
            airTransport.RegisteredCountry = registeredCountry;
            airTransport.RegisteredRegion = registeredRegion;
            airTransport.RegisteredCity = registeredCity;
            airTransport.ClimatZone = climatZone;
            airTransport.Functionality = functionality;

            return _airTransportRepository.Update(airTransport);
        }
    }
}
