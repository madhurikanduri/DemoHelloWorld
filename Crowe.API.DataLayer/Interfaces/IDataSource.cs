using System;
namespace Crowe.API.DataLayer.Interfaces
{
    public interface IDataSource
    {
        string GetSQLDatabaseContext();
        string GetFlatFileContext();
        string GetXMlFileContext();
    }
}
