using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Contracts.Contracts
{
    public interface IDataConverterManagerService
    {
        IDataConverterService GetConverter();
        void SetDataSourceToCsv();
        void SetDataSourceToXml();
    }
}
