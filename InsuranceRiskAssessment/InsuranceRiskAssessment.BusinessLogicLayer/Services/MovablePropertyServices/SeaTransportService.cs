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
            string registeredRegion, string registeredCity,
            bool doesRoutePassesPirateZones, string functionality, string typeOfMovability, string name,
            bool previousIncidents, string brokerId)
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
                Name = name,
                RegisteredCity = registeredCity,
                DoesRoutePassesPirateZones = doesRoutePassesPirateZones,
                PreviousAccidents = previousIncidents,
                ModifiedAt = DateTime.Now,
                Functionality = functionality,
                TypeOfMovability = typeOfMovability,
                ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability,
                previousIncidents, distanceTraveled, functionality, doesRoutePassesPirateZones, typeOfMovability),
                InsuranceBroker = brokerId
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
            string registeredRegion, string registeredCity, bool doesRoutePassesPirateZones,
            string functionality, string typeOfMovability, string name, bool previousIncidents)
        {
            var seaTransport = GetSeaTransportById(seaTransportId);
            if (seaTransport == default(SeaTransport))
            {
                return false;
            }

            seaTransport.ManifactureYear = manifactureYear;
            seaTransport.SecurityEquipmenPossession = securityEquipmenPossession;
            seaTransport.TechnicalServiceability = technicalServiceability;
            seaTransport.PreviousAccidents = previousIncidents;
            seaTransport.DistanceTraveled = distanceTraveled;
            seaTransport.Height = height;
            seaTransport.Weight = weight;
            seaTransport.Width = width;
            seaTransport.Name = name;
            seaTransport.RegisteredCountry = registeredCountry;
            seaTransport.RegisteredRegion = registeredRegion;
            seaTransport.RegisteredCity = registeredCity;
            seaTransport.DoesRoutePassesPirateZones = doesRoutePassesPirateZones;
            seaTransport.Functionality = functionality;
            seaTransport.TypeOfMovability = typeOfMovability;
            seaTransport.ModifiedAt = DateTime.Now;
            seaTransport.ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability,
                previousIncidents, distanceTraveled, functionality, doesRoutePassesPirateZones, typeOfMovability);
            return _seaTransportRepository.Update(seaTransport);
        }
        private int GetResultValue(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            bool previousIncidents, int distanceTraveled, string functionality,
            bool doesRoutePassesPirateZones, string typeOfMovability)
        {
            int initialResultValue = 100;
            int currentYear = DateTime.Now.Year;
            int manifacture_year = manifactureYear.Year;
            int yearDifference = currentYear - manifacture_year;

            if (previousIncidents)
            {
                initialResultValue -= 5;
            }
            if (yearDifference >= 5 && yearDifference <= 10)
            {
                initialResultValue -= 5;
            }
            else if (yearDifference > 10 && yearDifference <= 15)
            {
                initialResultValue -= 10;
            }
            else if (yearDifference > 15)
            {
                initialResultValue -= 15;
            }
            if (!securityEquipmenPossession)
            {
                initialResultValue -= 15;
            }
            if (!technicalServiceability)
            {
                initialResultValue -= 15;
            }
            if (distanceTraveled >= 100000 && distanceTraveled < 200000)
            {
                initialResultValue -= 5;
            }
            else if (distanceTraveled >= 200000)
            {
                initialResultValue -= 10;
            }
            switch (functionality)
            {
                case "Търговски":
                    initialResultValue -= 5;
                    break;
                case "Военен":
                    initialResultValue -= 15;
                    break;
                case "Товарен":
                    initialResultValue -= 10;
                    break;
            }
            if (doesRoutePassesPirateZones)
            {
                initialResultValue -= 15;
            }
            switch (typeOfMovability)
            {
                case "Ветроходен":
                    initialResultValue -= 5;
                    break;
                case "Моторен":
                    initialResultValue -= 10;
                    break;
            }

            return initialResultValue;
        }
    }
}
