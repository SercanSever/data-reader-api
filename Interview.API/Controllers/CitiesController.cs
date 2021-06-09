using Interview.Contracts.Concrete.Models;
using Interview.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace Interview.API.Controllers
{
    public class CitiesController : ApiController
    {
        private readonly IDataConverterManagerService _dataConverterManagerService;
        public CitiesController(IDataConverterManagerService dataConverterManagerService)
        {
            _dataConverterManagerService = dataConverterManagerService;
        }

        [HttpGet]
        [EnableQuery]
        public List<City> GetCities()
        {
            return _dataConverterManagerService.GetConverter().ConvertData();
        }
    }
}
