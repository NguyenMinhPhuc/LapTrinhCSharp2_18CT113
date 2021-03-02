using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class ReadConnectionString
    {
       string serverName, databaseName, uid=string.Empty, pwd=string.Empty;
       bool winNT = false;
       private string connectionString;

       public string ConnectionString
       {
           get { return connectionString; }
           set { connectionString = value; }
       }
       public string DocChuoiKetNoiTuFile(string path)
       {
           if (File.Exists(path))
           {
               using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
               {
                   using (StreamReader sw = new StreamReader(fs))
                   {
                       string line = string.Empty;
                       while((line=sw.ReadLine())!=null)
                       {
                           switch (line.Substring(0,line.IndexOf("=")).Trim().ToLower())
                           {
                               case "server":
                                   serverName = line.Substring(line.IndexOf("=") + 1);
                                   break;
                               case "database":
                                   databaseName = line.Substring(line.IndexOf("=") + 1);
                                   break;
                               case "uid":
                                   uid = line.Substring(line.IndexOf("=") + 1);
                                   break;
                               case "pwd":
                                   pwd = line.Substring(line.IndexOf("=") + 1);
                                   break;
                               case "winnt":
                                   winNT = Convert.ToBoolean(line.Substring(line.IndexOf("=") + 1));
                                   break;
                           }
                       }
                   }
               }
            
           }  
           return GhepChuoiKetNoi();
       }

       private string GhepChuoiKetNoi()
       {
           if(winNT)
               //ket noi theo window
               connectionString=string.Format("server={0};database={1};integrated security=true",serverName,databaseName);
           else
           //ket noi theo sql
               connectionString = string.Format("server={0};database={1};uid={2};pwd={3}", serverName, databaseName,uid,pwd);
           return connectionString;
       }
       public void GhiChuoiKetNoiVaoFile(string path)
       {
           using(FileStream fs =new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write))
           {
               using (StreamWriter sw = new StreamWriter(fs))
               {
                   sw.WriteLine(string.Format("server={0}", serverName));
                   sw.WriteLine(string.Format("database={0}", databaseName));
                   sw.WriteLine(string.Format("uid={0}", uid));
                   sw.WriteLine(string.Format("pwd={0}", pwd));
                   sw.Write(string.Format("winnt={0}", winNT.ToString()));
               }
           }
       }
    }
}
