using Interview.Contracts.Concrete.Dtos;
using Interview.Contracts.Concrete.Models;
using Interview.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Service.Services
{
    public class CsvDataConverterService : IDataConverterService
    {
        public List<City> ConvertData()
        {
            string path = ConfigurationManager.AppSettings["csvPath"];
            var cities = System.IO.File.ReadAllLines(path).Skip(1).Select(x => GetCityOfLine(x)).ToList();
            var result = ConvertCsvCitiesToCities(cities);
            return result;
        }

        private CsvCityDto GetCityOfLine(string line)
        {
            string[] values = line.Split(',');
            CsvCityDto city = new CsvCityDto()
            {
                CityName = values[0],
                CityCode = values[1],
                DistrictName = values[2],
                ZipCode = values[3],
            };
            return city;
        }

        private List<City> ConvertCsvCitiesToCities(List<CsvCityDto> csvCityDtos)
        {
            var cities = csvCityDtos.GroupBy(t => new { t.CityName, t.CityCode }).Select(s => new CsvCityDto() { CityCode = s.Key.CityCode, CityName = s.Key.CityName }).ToList();
            List<City> result = new List<City>();
            foreach (var item in cities)
            {
                var city = new City();
                city.Name = item.CityName;
                city.Code = item.CityCode;
                var districts = csvCityDtos.Where(x => x.CityCode == item.CityCode).Select(y => y.DistrictName).Distinct().ToList();
                foreach (var district in districts)
                {
                    var cityDistrict = new District();
                    cityDistrict.Name = district;
                    var zipCodes = csvCityDtos.Where(x => x.CityCode == item.CityCode && x.DistrictName == district).Select(t => new Zip() { Code = t.ZipCode }).ToList();
                    cityDistrict.Zips = zipCodes;
                    city.Districts.Add(cityDistrict);
                }
                result.Add(city);
            }
            return result;
        }
    }
}
