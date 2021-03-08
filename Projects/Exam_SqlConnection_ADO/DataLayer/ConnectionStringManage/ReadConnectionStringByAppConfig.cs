using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace DataLayer.ConnectionStringManage
{
    public class ReadConnectionStringByAppConfig : IReadConnectString
    {
        public SqlConnectionStringBuilder ReadConnectionString(string path)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(path);
            string _connectionString = string.Empty ;
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the conection string
                    _connectionString = xElement.FirstChild.Attributes[1].Value; //= connectionString.ToString();
                }
            }
            #region đoạn code đọc file App.Config trong project.
            //var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            #endregion
            connectionStringBuilder.ConnectionString = _connectionString;
            return connectionStringBuilder;
        }

        public void WriteConnectionString(string path, SqlConnectionStringBuilder connectionString)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
//AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
            XmlDoc.Load(path);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the conection string
                    xElement.FirstChild.Attributes[1].Value = connectionString.ToString();
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(path);

        }
    }
}
