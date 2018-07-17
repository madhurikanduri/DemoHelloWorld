using System;
using Crowe.API.DataLayer.Interfaces;
using Crowe.API.Common;
using System.Configuration;

namespace Crowe.API.DataLayer
{
    public class DataSource : IDataSource
    {
        public DataSource()
        {
        }

        public string GetFlatFileContext()
        {
            //var flatfilepath =  System.Configuration.ConfigurationManager.AppSettings[ConfigSettingsKeys.FileKey];
            var flatfilepath = System.Configuration.ConfigurationManager.AppSettings["message.txt"];


            return flatfilepath;
        }

        public string GetSQLDatabaseContext()
        {
            throw new NotImplementedException();
        }

        public string GetXMlFileContext()
        {
            throw new NotImplementedException();
        }
    }
}
