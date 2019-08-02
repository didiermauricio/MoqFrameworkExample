using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingDependencies
{
    public class DataReader : IDataReader
    {
        public string ReadUserInfoFromDB(string id)
        {
            string result = ExecuteQuery(id);
            return result;
        }

        private string ExecuteQuery(string id)
        {
            throw new NotImplementedException();
        }
    }
}
