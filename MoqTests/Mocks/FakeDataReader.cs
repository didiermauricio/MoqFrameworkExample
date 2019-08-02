using BreakingDependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInyByParameters.Mocks
{
    public class FakeDataReader : IDataReader
    {
        public string ReadUserInfoFromDB(string id)
        {
            return null;
        }
    }
}
