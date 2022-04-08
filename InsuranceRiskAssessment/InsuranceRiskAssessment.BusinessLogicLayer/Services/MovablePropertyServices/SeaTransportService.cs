using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.MovablePropertyServices
{
    public class SeaTransportService : ISeaTransportService
    {
        private readonly IRepository<SeaTransport> _seaTransportRepository;
        public SeaTransportService(IRepository<SeaTransport> seaTransportRepository)
        {
            _seaTransportRepository = seaTransportRepository;
        }

        public bool CreateSeaTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry,
            string registeredRegion, string registeredCity, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability, string name)
        {
            var seaTransport = new SeaTransport()
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
                DoesRoutePassesPirateZones = doesRoutePassesPirateZones,
                Functionality = functionality,
                TypeOfMovability = typeOfMovability
            };
            return _seaTransportRepository.Create(seaTransport);
        }

        public SeaTransport GetSeaTransportById(int seaTransportId)
        {
            return _seaTransportRepository.GetById(seaTransportId);
        }

        public List<SeaTransport> GetSeaTransports()
        {
            return _seaTransportRepository.GetAll();
        }

        public bool Remove(int seaTransportId)
        {
            return _seaTransportRepository.RemoveById(seaTransportId);
        }

        public bool UpdateSeaTransport(int seaTransportId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry,
            string registeredRegion, string registeredCity, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability, string name)
        {
            var seaTransport = GetSeaTransportById(seaTransportId);
            if (seaTransport == default(SeaTransport))
            {
                return false;
            }

            seaTransport.ManifactureYear = manifactureYear;
            seaTransport.SecurityEquipmenPossession = securityEquipmenPossession;
            seaTransport.TechnicalServiceability = technicalServiceability;
            seaTransport.DistanceTraveled = distanceTraveled;
            seaTransport.Height = height;
            seaTransport.Weight = weight;
            seaTransport.Width = width;
            seaTransport.RegisteredCountry = registeredCountry;
            seaTransport.RegisteredRegion = registeredRegion;
            seaTransport.RegisteredCity = registeredCity;
            seaTransport.DoesRoutePassesPirateZones = doesRoutePassesPirateZones;
            seaTransport.Functionality = functionality;
            seaTransport.TypeOfMovability = typeOfMovability;

            return _seaTransportRepository.Update(seaTransport);
        }
    }
}
