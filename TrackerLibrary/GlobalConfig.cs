using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
   public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            // Having two if statments gives use the option of using one opton database or textFiles or a combination of both.
            if (database)
            {
                // TODO: set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text); 
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
