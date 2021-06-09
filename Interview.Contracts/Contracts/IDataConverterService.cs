using Interview.Contracts.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Contracts.Contracts
{
    public interface IDataConverterService
    {
        List<City> ConvertData();
    }
}
