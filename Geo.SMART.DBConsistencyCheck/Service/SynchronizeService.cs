using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geo.Grid.Common.Interceptor.WebForm.Attribute;

namespace Geo.SMART.DBConsistencyCheck.Service
{
    [ExceptionHandler]
    [ExecuteTime]
    public class SynchronizeService : MarshalByRefObject
    {

    }
}
