using System;

namespace Crowe.API.DataLayer
{
    public static class DbContext
    {
        public static string Dbcon;

        static DbContext()
        {
            DataSource db = new DataSource();
            Dbcon = db.GetFlatFileContext();
        }

    }
}
