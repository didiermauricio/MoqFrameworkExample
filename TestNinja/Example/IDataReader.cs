namespace BreakingDependencies
{ 
    public interface IDataReader
    {
        string ReadUserInfoFromDB(string id);
    }
}