using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BreakingDependencies.Example
    {
    public class InformationService
    {
        private IDataReader _dataReader;

        public InformationService(IDataReader dataReader = null)
        {
            _dataReader = dataReader ?? new DataReader();
        }

        public bool RequestInfomation()
        {
            //var Info = ReadUserInfoFromDB("123456");
            var info = _dataReader.ReadUserInfoFromDB("123456");
            if (info == string.Empty)
                return false;
            else
                return true;
            
        }
        
    }
}
