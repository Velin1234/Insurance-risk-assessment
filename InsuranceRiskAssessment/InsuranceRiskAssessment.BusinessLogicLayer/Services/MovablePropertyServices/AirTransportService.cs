using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.MovablePropertyServices
{
    public class AirTransportService : IAirTransportService
    {
        private readonly IRepository<AirTransport> _airTransportRepository;
        public AirTransportService(IRepository<AirTransport> airTransportRepository)
        {
            _airTransportRepository = airTransportRepository;
        }
        public bool CreateAirTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, bool previousIncidents, int distanceTraveled,
            double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string functionality, string name)
        {
            var airTransport = new AirTransport()
            {
                ManifactureYear = manifactureYear,
                SecurityEquipmenPossession = securityEquipmenPossession,
                TechnicalServiceability = technicalServiceability,
                PreviousAccidents = previousIncidents,
                DistanceTraveled = distanceTraveled,
                Height = height,
                Weight = weight,
                Width = width,
                RegisteredCountry = registeredCountry,
                RegisteredRegion = registeredRegion,
                RegisteredCity = registeredCity,
                Functionality = functionality,
                Name = name,
                ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability, previousIncidents, distanceTraveled, functionality)
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

        public bool UpdateAirTransport(int airTransportId, DateTime manifactureYear, bool securityEquipmenPossession,
            bool technicalServiceability, bool previousIncidents, int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string functionality, string name)
        {
            var airTransport = GetAirTransportById(airTransportId);
            if (airTransport == default(AirTransport))
            {
                return false;
            }

            airTransport.ManifactureYear = manifactureYear;
            airTransport.SecurityEquipmenPossession = securityEquipmenPossession;
            airTransport.PreviousAccidents = previousIncidents;
            airTransport.TechnicalServiceability = technicalServiceability;
            airTransport.DistanceTraveled = distanceTraveled;
            airTransport.Height = height;
            airTransport.Weight = weight;
            airTransport.Width = width;
            airTransport.RegisteredCountry = registeredCountry;
            airTransport.RegisteredRegion = registeredRegion;
            airTransport.RegisteredCity = registeredCity;
            airTransport.Functionality = functionality;
            airTransport.Name = name;
            airTransport.ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability, previousIncidents, distanceTraveled, functionality);

            return _airTransportRepository.Update(airTransport);
        }

        private int GetResultValue(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, bool previousIncidents, int distanceTraveled, string functionality)
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
                initialResultValue -= 10;
            }
            else if (yearDifference > 10 && yearDifference <= 15)
            {
                initialResultValue -= 15;
            }
            else if (yearDifference > 15)
            {
                initialResultValue -= 20;
            }
            if (!securityEquipmenPossession)
            {
                initialResultValue -= 15;
            }
            if (!technicalServiceability)
            {
                initialResultValue -= 20;
            }
            if (distanceTraveled >= 100000 && distanceTraveled < 200000)
            {
                initialResultValue -= 10;
            }
            else if (distanceTraveled >= 200000)
            {
                initialResultValue -= 20;
            }

            switch (functionality)
            {
                case "Търговски":
                    initialResultValue -= 5;
                    break;
                case "Военен":
                    initialResultValue -= 20;
                    break;
                case "Товарен":
                    initialResultValue  -= 10;
                    break;
            }


            return initialResultValue;
        }
    }
}
