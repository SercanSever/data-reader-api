using Interview.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Interview.API.Controllers
{
    public class ConvertersController : ApiController
    {
        private readonly IDataConverterManagerService _dataConverterManagerService;
        public ConvertersController(IDataConverterManagerService dataConverterManagerService)
        {
            _dataConverterManagerService = dataConverterManagerService;
        }

        [HttpGet]
        [Route("api/Converters/Source/Set/Csv")]
        public void SetDataSourceToCsv()
        {
            _dataConverterManagerService.SetDataSourceToCsv();
        }
        [HttpGet]
        [Route("api/Converters/Source/Set/Xml")]
        public void SetDataSourceToXml()
        {
            _dataConverterManagerService.SetDataSourceToXml();
        }
    }
}
